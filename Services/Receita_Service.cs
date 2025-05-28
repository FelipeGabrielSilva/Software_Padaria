using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.GerarDados;
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

        public void Criar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Receita.Add(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Receita> ListarTodos()
        {
            List<Receita> receitas = new List<Receita>();

            receitas = _context.Receita.ToList();

            return receitas;
        }

        public void Atualizar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Receita.Update(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Deletar(Receita r)
        {
            ResultadoValidacao res = _valido.Receita(r);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Receita.Remove(r);
            _context.SaveChanges();

            MessageBox.Show($"A receita {r.Nome} foi deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PopularBanco()
        {
            if (_context.Receita.Any())
            {
                return;
            }

            List<Receita> receitas = ReceitaData.GetReceitas();

            try
            {
                _context.Receita.AddRange(receitas);
                _context.SaveChanges();

                MessageBox.Show($"Foram adicionados {receitas.Count} fornecedores ao banco de dados com sucesso!",
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
