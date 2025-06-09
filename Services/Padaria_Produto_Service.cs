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
    public class Padaria_Produto_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Padaria_Produto_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }
        public void Criar(Padaria_Produto pp)
        {
            ResultadoValidacao res = _valido.Padaria_Produto(pp);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Padaria_Produto.Add(pp);
            _context.SaveChanges();

            MessageBox.Show($"A categoria {pp.Nome} foi criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public List<Padaria_Produto> ListarTodos()
        {
            List<Padaria_Produto> pp = new List<Padaria_Produto>();
            pp = _context.Padaria_Produto.Include(a => a.Categoria).ToList();

            return pp;
        }

        public void PopularBanco()
        {
            if (_context.Padaria_Produto.Any())
            {
                return;
            }

            List<Padaria_Produto> pp = PadariaProdutoData.GetProdutos();

            try
            {
                _context.Padaria_Produto.AddRange(pp);
                _context.SaveChanges();

                MessageBox.Show($"Foram adicionados {pp.Count} fornecedores ao banco de dados com sucesso!",
                               "Sucesso",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao popular o banco de dados: {ex.Message}",
                               "Erro",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}
