using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Services
{
    public class Venda_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Venda_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar(List<ItemVenda> itensVenda, string cpf_cnpj, int pagamentoId)
        {
            if (itensVenda == null || !itensVenda.Any())
            {
                throw new ArgumentException("A venda deve conter pelo menos um item.", nameof(itensVenda));
            }

            if (pagamentoId < 1)
            {
                throw new ArgumentException("Um tipo de pagamento válido deve ser selecionado.", nameof(pagamentoId));
            }

            Pagamento tipoPagamento = _context.Pagamento.Find(pagamentoId);
            if (tipoPagamento == null)
            {
                throw new ArgumentException($"Tipo de pagamento com ID {pagamentoId} não encontrado.", nameof(pagamentoId));
            }

            Venda venda = new Venda
            {
                Data = DateTime.Now,
                Status = Status.Realizada,
                CPF_CNPJ = string.IsNullOrWhiteSpace(cpf_cnpj) ? null : cpf_cnpj.Trim(),
                Preco = itensVenda.Sum(item => item.Subtotal),
                TipoPagamentoId = tipoPagamento.Id,
                Pagamento = tipoPagamento,
            };

            ResultadoValidacao res = _valido.Venda(venda);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (ItemVenda item in itensVenda)
            {
                Padaria_Produto pp = _context.Padaria_Produto.Find(item.ProdutoId);
                if (pp == null)
                {
                    throw new ArgumentException($"Produto com ID {item.ProdutoId} não encontrado para o item da venda.", nameof(item.ProdutoId));
                };

                venda.VendaProdutos.Add(new Venda_Produto
                {
                    ProdutoId = item.ProdutoId,
                    Produto = pp,
                    Quantidade = item.Quantidade,
                    PrecoUnitario = item.PrecoUnitario,
                    Venda = venda,
                    VendaId = venda.Id
                });
            }

            _context.Venda.Add(venda);

            foreach (ItemVenda item in itensVenda)
            {
                _context.Estoque_Prod_Padaria.Add(new Estoque_Prod_Padaria
                {
                    ProdutoId = item.ProdutoId,
                    Quantidade = item.Quantidade,
                    Tipo = Tipo.Saida,
                    Saida = DateTime.Now,
                    Atualizacao = DateTime.Now,
                    Descricao = $"Saída por Venda"
                });
            }

            _context.SaveChanges();
        }

        public List<Venda> ListarTodos()
        {
            List<Venda> Vendas = new List<Venda>();

            Vendas = _context.Venda.Include(v => v.Pagamento).Include(v => v.VendaProdutos).ThenInclude(vp => vp.Produto).OrderByDescending(o => o.Id).ToList();

            return Vendas;
        }

        public void Deletar(Venda r)
        {
            ResultadoValidacao res = _valido.Venda(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Venda.Remove(r);
            _context.SaveChanges();

            MessageBox.Show($"A venda {r.Id} foi deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
