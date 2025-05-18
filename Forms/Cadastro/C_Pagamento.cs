using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_Pagamento : Form
    {
        public C_Pagamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validador = new Validacao();

            string desc = txtDescricao.Text;

            Pagamento p = new Pagamento
            {
                Descricao = desc,
            };

            var res = validador.Pagamento(p);

            if (!res.Valido)
            {
                MessageBox.Show(string.Join("\n", res.Erros), "Erro", MessageBoxButtons.OK);
                return;
            }

            using (var context = new AppDbContext())
            {
                context.Pagamento.Add(p);
                context.SaveChanges();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
