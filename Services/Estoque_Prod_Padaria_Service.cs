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
    public class Estoque_Prod_Padaria_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Estoque_Prod_Padaria_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar(Estoque_Prod_Padaria epp)
        {
            ResultadoValidacao res = _valido.Estoque_Prod_Padaria(epp);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao criar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Estoque_Prod_Padaria.Add(epp);
            _context.SaveChanges();
        }

        public List<Estoque_Prod_Padaria> ListarTodos()
        {
            List<Estoque_Prod_Padaria> epp = new List<Estoque_Prod_Padaria>();
            epp = _context.Estoque_Prod_Padaria
                                .Include(p => p.Produto)
                                .OrderByDescending(o => o.Id)
                                .ToList();

            return epp;
        }

        public void PopularBanco()
        {
            if (_context.Estoque_Prod_Padaria.Any())
            {
                return;
            }

            VendaData.GerarVendas(_context);
        }
    }
}
