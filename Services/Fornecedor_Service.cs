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

        private void criar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK);
                return;
            }

            _context.Fornecedor.Add(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi criado com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }

        private List<Fornecedor> listarTodos()
        {
            List<Fornecedor> Fornecedores = new List<Fornecedor>();
                
            Fornecedores = _context.Fornecedor.ToList();

            return Fornecedores;
        }

        private void atualizar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK);
                return;
            }

            _context.Fornecedor.Update(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }

        private void deletar(Fornecedor f)
        {
            ResultadoValidacao res = _valido.Fornecedor(f);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK);
                return;
            }

            _context.Fornecedor.Remove(f);
            _context.SaveChanges();

            MessageBox.Show($"O fornecedor {f.Nome} foi deletado com sucesso!", "Sucesso", MessageBoxButtons.OK);
        }
    }
}
