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

        public void Criar(Venda v)
        {
            ResultadoValidacao res = _valido.Venda(v);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Venda.Add(v);
            _context.SaveChanges();

            MessageBox.Show($"A venda {v.Id} foi criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
