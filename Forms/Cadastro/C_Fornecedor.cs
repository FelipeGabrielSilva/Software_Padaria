using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using WindowsForm_Padaria.Helpers;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Services;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_Fornecedor : Form
    {
        private readonly Validacao _validacao;
        private readonly Fornecedor_Service f_service;
        public C_Fornecedor()
        {
            _validacao = new Validacao();
            f_service = new Fornecedor_Service();
            InitializeComponent();
            getPagamentos();
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
            string nome = txtTelefone.Text;
            string email = txtEmail.Text;
            string tel = txtTelefone.Text;
            string end = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string num = txtNumero.Text;
            string cnpj = txtCnpj.Text;
            int pagId = (int)cmbPagamento.SelectedValue;

            Fornecedor f = new Fornecedor
            {
                Nome = nome,
                Email = email,
                Telefone = tel,
                Endereco = end,
                Bairro = bairro,
                Numero = num,
                CNPJ = cnpj,
                TipoPagamentoId = pagId
            };

            try
            {
                f_service.criar(f);
            }
            catch (Exception ex)
            {
                ExibindoLogError el = new ExibindoLogError();
                el.Exibir(ex);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getPagamentos()
        {
            Pagamento_Service p_service = new Pagamento_Service();

            cmbPagamento.Items.Clear();
            cmbPagamento.ValueMember = "Id";
            cmbPagamento.DisplayMember = "Descricao";

            cmbPagamento.DataSource = p_service.listarTodos();
        }
    }
}
