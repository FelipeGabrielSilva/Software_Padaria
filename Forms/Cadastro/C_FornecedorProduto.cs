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
using WindowsForm_Padaria.Services;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_FornecedorProduto : Form
    {
        private readonly Fornecedor_Service fornecedor_service;
        private readonly Fornecedor_Produto_Service fornecedor_produto_service;
        public C_FornecedorProduto()
        {
            fornecedor_service = new Fornecedor_Service();
            fornecedor_produto_service = new Fornecedor_Produto_Service();
            InitializeComponent();
            AtualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarGrid()
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
            comboBox1.DataSource = fornecedor_service.ListarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fornecedor_Produto fp = new Fornecedor_Produto
            {
                Codigo = Convert.ToInt32(textBox1.Text),
                Nome = textBox1.Text,
                Descricao = richTextBox1.Text,
                FornecedorId = (int)comboBox1.SelectedValue,
            };

            fornecedor_produto_service.Criar(fp);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
