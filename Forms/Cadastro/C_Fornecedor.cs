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
using WindowsForm_Padaria.Services;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_Fornecedor : Form
    {
        private readonly Fornecedor_Service fs;
        private readonly Pagamento_Service ps;
        public C_Fornecedor()
        {
            fs = new Fornecedor_Service();
            ps = new Pagamento_Service();
            InitializeComponent();
            AtualizarGrid();
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
            Fornecedor f = new Fornecedor
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                CNPJ = txtCnpj.Text,
                Telefone = txtTelefone.Text,
                Endereco = txtEndereco.Text,
                Bairro = txtBairro.Text,
                NumeroEndereco = txtNumero.Text,
                PagamentoId = (int)cmbPagamento.SelectedValue,
            };

            fs.Criar(f);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarGrid()
        {
            cmbPagamento.Items.Clear();
            cmbPagamento.ValueMember = "Id";
            cmbPagamento.DisplayMember = "Descricao";
            cmbPagamento.DataSource = ps.ListarTodos();
        }
    }
}
