using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsForm_Padaria.GerarDados;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Services
{
    public class Estoque_Prod_Fornecedor_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Estoque_Prod_Fornecedor_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar (Estoque_Prod_Fornecedor epf)
        {
            ResultadoValidacao res = _valido.Estoque_Prod_Fornecedor(epf);

            if(!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao criar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Estoque_Prod_Fornecedor.Add(epf);
            _context.SaveChanges();
        }

        public List<Estoque_Prod_Fornecedor> ListarTodos ()
        {
            List<Estoque_Prod_Fornecedor> epf = _context.Estoque_Prod_Fornecedor
                                    .Include(f => f.Produto)
                                    .Include(f => f.Fornecedor)
                                    .OrderByDescending(o => o.Id)
                                    .ToList();

            return epf;
        }

        public void Deletar() {
        }

        public void PopularBanco()
        {
            if (_context.Estoque_Prod_Fornecedor.Any())
            {
                return;
            }
            
            EstoqueFornecedorProdutoData.GerarMovimentacoesEstoque(_context);

        }
    }
}
