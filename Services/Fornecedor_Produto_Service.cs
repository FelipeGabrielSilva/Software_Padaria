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
    public class Fornecedor_Produto_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Fornecedor_Produto_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar(Fornecedor_Produto f)
        {
            ResultadoValidacao res = _valido.Fornecedor_Produto(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor_Produto.Add(f);
            _context.SaveChanges();

            MessageBox.Show($"O produto de fornecedor {f.Nome} foi criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Fornecedor_Produto> ListarTodos()
        {
            List<Fornecedor_Produto> fp = new List<Fornecedor_Produto>();

            fp = _context.Fornecedor_Produto.ToList();

            return fp;
        }

        public void Atualizar(Fornecedor_Produto f)
        {
            ResultadoValidacao res = _valido.Fornecedor_Produto(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor_Produto.Update(f);
            _context.SaveChanges();

            MessageBox.Show($"O produto de fornecedor {f.Nome} foi atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Deletar(Fornecedor_Produto f)
        {
            ResultadoValidacao res = _valido.Fornecedor_Produto(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Fornecedor_Produto.Remove(f);
            _context.SaveChanges();

            MessageBox.Show($"O produto do fornecedor {f.Nome} foi deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void PopularFornecedorProduto()
        {
            //if (_context.Fornecedor.Any())
            //{
            //    MessageBox.Show("O banco de dados já contém fornecedores.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //var fornecedores = FornecedorData.GetFornecedores();

            //try
            //{
            //    _context.Fornecedor.AddRange(fornecedores);
            //    _context.SaveChanges();

            //    MessageBox.Show($"Foram adicionados {fornecedores.Count} fornecedores ao banco de dados com sucesso!",
            //                   "Sucesso",
            //                   MessageBoxButtons.OK,
            //                   MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ocorreu um erro ao popular o banco de dados: {ex.Message}",
            //                   "Erro",
            //                   MessageBoxButtons.OK,
            //                   MessageBoxIcon.Error);
            //}
        }
    }
}
