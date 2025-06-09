using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.GerarDados
{
    internal class EstoqueFornecedorProdutoData
    {
        public static void GerarMovimentacoesEstoque(AppDbContext context)
        {
            if (context.Estoque_Prod_Fornecedor.Any() || context.Estoque_Prod_Fornecedor.Any())
            {
                return;
            }

            // --- 1. Obter Produtos de Fornecedores e Fornecedores Existentes ---
            // É crucial que Fornecedor_Produto e Fornecedor já estejam populados antes desta etapa.
            List<Fornecedor_Produto> produtosFornecedores = context.Fornecedor_Produto.ToList();
            List<Fornecedor> fornecedores = context.Fornecedor.ToList();
            List<Padaria_Produto> produtosPadaria = context.Padaria_Produto.ToList();

            if (!produtosFornecedores.Any() || !fornecedores.Any() || !produtosPadaria.Any())
            {
                Console.WriteLine("Dados de Fornecedor, Fornecedor_Produto ou Padaria_Produto não encontrados. Não é possível gerar movimentações de estoque.");
                return;
            }

            Random rand = new Random();
            List<Estoque_Prod_Fornecedor> entradasFornecedores = new List<Estoque_Prod_Fornecedor>();
            List<Estoque_Prod_Padaria> saidasPadaria = new List<Estoque_Prod_Padaria>();

            DateTime dataAtual = DateTime.Now;

            // --- 2. Gerar Entradas de Produtos de Fornecedores (Estoque_Prod_Fornecedor) ---
            // Para cada produto de fornecedor, simular algumas entradas ao longo do tempo
            foreach (var prodFornecedor in produtosFornecedores)
            {
                // Exemplo: 1 a 3 entradas por produto de fornecedor
                int numEntradas = rand.Next(1, 4); 

                for (int i = 0; i < numEntradas; i++)
                {
                    int quantidadeEntrada = rand.Next(1, 20) * 5; // Múltiplos de 5, até 100kg/litros/unidades
                    // Atribui a um fornecedor aleatório, mas que seja o fornecedor original do produto.
                    // Isso é importante para a consistência da FK.
                    var fornecedorAssociado = fornecedores.FirstOrDefault(f => f.Id == prodFornecedor.FornecedorId);
                    if (fornecedorAssociado == null) continue; // Pula se o fornecedor do produto não for encontrado (erro de seeding anterior)

                    // Data da entrada: nos últimos 30 dias
                    DateTime dataEntrada = dataAtual.AddDays(-rand.Next(1, 31));

                    entradasFornecedores.Add(new Estoque_Prod_Fornecedor
                    {
                        FornecedorId = fornecedorAssociado.Id,
                        ProdutoId = prodFornecedor.Id,
                        Quantidade = quantidadeEntrada,
                        Tipo = Tipo.Entrada,
                        Entrada = dataEntrada,
                        Atualizacao = dataEntrada
                    });
                }
            }

            // --- 4. Adicionar ao Contexto e Salvar ---
            if (entradasFornecedores.Any())
            {
                context.Estoque_Prod_Fornecedor.AddRange(entradasFornecedores);
                Console.WriteLine($"Adicionadas {entradasFornecedores.Count} entradas de produtos de fornecedores.");
            }

            context.SaveChanges();
            Console.WriteLine("Movimentações de estoque geradas e salvas com sucesso!");
        }
    }
}
            
