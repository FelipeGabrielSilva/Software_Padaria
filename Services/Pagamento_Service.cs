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

        public void Salvar(Pagamento p)
        {
            var res = _valido.Pagamento(p);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros),"Erro ao cadastrar", MessageBoxButtons.OK);
                return;
            }

            _context.Pagamento.Add(p);
            _context.SaveChanges();
        }
    }
}
