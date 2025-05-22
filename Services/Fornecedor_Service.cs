using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void criar(Fornecedor f)
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

        public List<Fornecedor> listarTodos()
        {
            List<Fornecedor> Fornecedores = new List<Fornecedor>();
                
            Fornecedores = _context.Fornecedor.ToList();

            return Fornecedores;
        }

        public void atualizar(Fornecedor f)
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

        public void deletar(Fornecedor f)
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

        public void popularBanco()
        {
            // Verifica se já existem fornecedores no banco
            if (_context.Fornecedor.Any())
            {
                MessageBox.Show("O banco de dados já contém fornecedores.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtém a lista de fornecedores fictícios
            var fornecedores = FornecedorData.GetFornecedores();

            try
            {
                // Adiciona todos os fornecedores de uma vez
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
