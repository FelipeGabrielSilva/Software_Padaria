using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Padaria.Helpers;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_Fornecedor : Form
    {
        public C_Fornecedor()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string pj = Formatador.AplicarMascaraCNPJ(txtCnpj.Text);
            txtCnpj.Text = pj;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            string tel = Formatador.AplicarMascaraTelefone(txtTelefone.Text);
            txtTelefone.Text = tel;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            // Coloque aqui o que você quer que aconteça quando clicar no label8
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtTelefone.Text;
                string email = txtEmail.Text;
                string tel = txtTelefone.Text;
                string end = txtEndereco.Text;
                string bairro = txtBairro.Text;
                string num = txtNumero.Text;
                string cnpj = txtCnpj.Text;

            }
            catch
            {

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
