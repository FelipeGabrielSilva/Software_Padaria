using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Services
{
    public class Receita_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Receita_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        private void criar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK);
                return;
            }

            _context.Receita.Add(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi criada com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }

        private List<Receita> listarTodos()
        {
            List<Receita> receitas = new List<Receita>();

            receitas = _context.Receita.ToList();

            return receitas;
        }

        private void atualizar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK);
                return;
            }

            _context.Receita.Update(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }

        private void deletar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK);
                return;
            }

            _context.Receita.Remove(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi deletada com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }
    }
}
