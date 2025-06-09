using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            MessageBox.Show($"Quantidade adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Estoque_Prod_Fornecedor> ListarTodos ()
        {
            List<Estoque_Prod_Fornecedor> epf = _context.Estoque_Prod_Fornecedor.OrderByDescending(o => o.Id).ToList();

            return epf;
        }

        public void Deletar() {
        }
    }
}
