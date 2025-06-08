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
    public class Fornecedor_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Fornecedor_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor.Add(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Fornecedor> ListarTodos()
        {
            List<Fornecedor> Fornecedores = new List<Fornecedor>();

            Fornecedores = _context.Fornecedor.Include(p => p.Pagamento).ToList();

            return Fornecedores;
        }

        public void Atualizar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor.Update(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Deletar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor.Remove(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PopularBanco()
        {
            if (_context.Fornecedor.Any())
            {
                return;
            }

            List<Fornecedor> fornecedores = FornecedorData.GetFornecedores();

            try
            {
                _context.Fornecedor.AddRange(fornecedores);
                _context.SaveChanges();

                MessageBox.Show($"Foram adicionados {fornecedores.Count} fornecedores ao banco de dados com sucesso!",
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
