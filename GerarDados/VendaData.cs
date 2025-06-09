using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;
using Microsoft.EntityFrameworkCore; // Para .Include() se necessário, e outros recursos

namespace WindowsForm_Padaria.GerarDados
{
    internal class VendaData
    {
        public static void GerarVendas(AppDbContext context, int quantidadeVendas = 200)
        {
            // Evita a reinserção de dados
            // Use o DbSet correto para Venda (context.Vendas se for plural, context.Venda se for singular)
            if (context.Venda.Any()) // Supondo que Venda é o DbSet no singular
            {
                Console.WriteLine("Vendas já existentes. Pulando geração.");
                return;
            }

            // --- 1. Obter Dados Base Necessários ---
            // Use o DbSet correto para Padaria_Produto (context.PadariaProdutos se plural, context.Padaria_Produto se singular)
            List<Padaria_Produto> produtosPadaria = context.Padaria_Produto.ToList();
            // Use o DbSet correto para Pagamento (context.Pagamentos se plural, context.Pagamento se singular)
            List<Pagamento> tiposPagamento = context.Pagamento.ToList();

            if (!produtosPadaria.Any() || !tiposPagamento.Any())
            {
                Console.WriteLine("Dados de Padaria_Produto ou Pagamento não encontrados. Não é possível gerar vendas.");
                return;
            }

            Random rand = new Random();
            List<CVenda> novasVendas = new List<CVenda>();
            List<Estoque_Prod_Padaria> baixasEstoque = new List<Estoque_Prod_Padaria>(); // Para saídas de estoque

            // Arrays de CPFs/CNPJs de exemplo (para diversificar um pouco)
            string[] cpfsCnpjsExemplo = new string[]
            {
                "123.456.789-00", "987.654.321-00", "111.222.333-44", null,
                "12.345.678/0001-90", "98.765.432/0001-00", "55.444.333/0001-11", null
            };

            // --- 2. Gerar as Vendas ---
            for (int i = 0; i < quantidadeVendas; i++)
            {
                // Data da venda: nos últimos 60 dias
                DateTime dataVenda = DateTime.Now.AddDays(-rand.Next(1, 61)).AddHours(-rand.Next(0, 24)).AddMinutes(-rand.Next(0, 60));

                // Status da venda (certifique-se que o enum 'Status' é o seu enum de StatusVenda)
                Status statusVenda = (Status)rand.Next(0, Enum.GetNames(typeof(Status)).Length); // Ajuste para StatusVenda

                // CPF/CNPJ aleatório (alguns serão nulos)
                string cpfCnpj = cpfsCnpjsExemplo[rand.Next(0, cpfsCnpjsExemplo.Length)];

                // Tipo de pagamento aleatório
                Pagamento tipoPagamentoSelecionado = tiposPagamento[rand.Next(0, tiposPagamento.Count)];

                CVenda novaVenda = new CVenda
                {
                    Data = dataVenda,
                    Status = statusVenda, // Usando o enum StatusVenda
                    CPF_CNPJ = cpfCnpj,
                    TipoPagamentoId = tipoPagamentoSelecionado.Id,
                    Pagamento = tipoPagamentoSelecionado, // Atribui a propriedade de navegação também (opcional, mas bom para seeding)
                    Preco = 0m, // Será calculado após adicionar os itens
                    VendaProdutos = new List<Venda_Produto>() // Inicializa a coleção de itens
                };

                // --- 3. Adicionar Itens de Venda (Venda_Produto) ---
                int numItens = rand.Next(1, 6); // De 1 a 5 produtos por venda
                decimal totalVendaAtual = 0m;

                // Para garantir que não há produtos duplicados na mesma venda
                HashSet<int> produtosJaAdicionados = new HashSet<int>();

                for (int j = 0; j < numItens; j++)
                {
                    Padaria_Produto produtoVendido;
                    int tentativas = 0;
                    do
                    {
                        produtoVendido = produtosPadaria[rand.Next(0, produtosPadaria.Count)];
                        tentativas++;
                    } while (produtosJaAdicionados.Contains(produtoVendido.Id) && tentativas < 5 && produtosPadaria.Count > produtosJaAdicionados.Count); // Evita loop infinito se produtos forem poucos e únicos

                    if (produtosJaAdicionados.Contains(produtoVendido.Id) && tentativas >= 5) continue; // Pula se não conseguiu achar produto único

                    produtosJaAdicionados.Add(produtoVendido.Id);

                    int quantidade = rand.Next(1, 5); // Quantidade de 1 a 4 por item
                    decimal precoUnitario = produtoVendido.Preco; // Preço do produto da padaria

                    // --- CORREÇÃO AQUI: Atribuindo as propriedades de navegação ---
                    // O EF Core vai inferir o VendaId (0 inicialmente) e ProdutoId (do produtoVendido.Id)
                    // e preenchê-los corretamente no SaveChanges, pois Venda e Produto são 'required'.
                    novaVenda.VendaProdutos.Add(new Venda_Produto
                    {
                        Produto = produtoVendido, 
                        ProdutoId = produtoVendido.Id,
                        Quantidade = quantidade,
                        PrecoUnitario = precoUnitario,
                        Venda = novaVenda,
                        VendaId = novaVenda.Id
                    });

                    totalVendaAtual += quantidade * precoUnitario;

                    // --- Opcional: Gerar Baixa de Estoque para cada item vendido ---
                    baixasEstoque.Add(new Estoque_Prod_Padaria
                    {
                        ProdutoId = produtoVendido.Id,
                        Quantidade = quantidade,
                        Tipo = Tipo.Saida, // Usando o enum TipoMovimentacao
                        Saida = dataVenda,
                        Atualizacao = dataVenda,
                        Descricao = $"Saída por Venda"
                    });
                }
                novaVenda.Preco = totalVendaAtual; // Define o preço total da venda

                novasVendas.Add(novaVenda);
            }

            if (novasVendas.Any())
            {
                context.Venda.AddRange(novasVendas);
                Console.WriteLine($"Adicionadas {novasVendas.Count} vendas.");
            }

            if (baixasEstoque.Any())
            {
                context.Estoque_Prod_Padaria.AddRange(baixasEstoque);
                Console.WriteLine($"Adicionadas {baixasEstoque.Count} baixas de estoque relacionadas às vendas.");
            }

            context.SaveChanges();
            Console.WriteLine("Vendas e baixas de estoque geradas e salvas com sucesso!");
        }
    }
}