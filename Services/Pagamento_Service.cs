using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Services
{
    public class Pagamento_Service
    {
        private readonly AppDbContext _context;
        private readonly Validacao _valido;

        public Pagamento_Service()
        {
            _context = new AppDbContext();
            _valido = new Validacao();
        }

        public void Criar(Pagamento p)
        {
            ResultadoValidacao res = _valido.Pagamento(p);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao criar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Pagamento.Add(p);
            _context.SaveChanges();

            MessageBox.Show($"O pagamento {p.Nome} foi criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Pagamento> ListarTodos()
        {
            List<Pagamento> pagamentos = new List<Pagamento>();

            pagamentos = _context.Pagamento.ToList();

            return pagamentos;
        }

        public void Atualizar(Pagamento p)
        {
            ResultadoValidacao res = _valido.Pagamento(p);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Pagamento.Update(p);
            _context.SaveChanges();

            MessageBox.Show($"O pagamento {p.Nome} foi atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Deletar(Pagamento p)
        {
            ResultadoValidacao res = _valido.Pagamento(p);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _context.Pagamento.Remove(p);
            _context.SaveChanges();

            MessageBox.Show($"O pagamento {p.Nome} foi deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
