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
using WindowsForm_Padaria.Services;

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
            Pagamento p = new Pagamento
            {
                Descricao = txtDescricao.Text,
            };

            Pagamento_Service pagamento_Service = new Pagamento_Service();
            pagamento_Service.Salvar(p);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
