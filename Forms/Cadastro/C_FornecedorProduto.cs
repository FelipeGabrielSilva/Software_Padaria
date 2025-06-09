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
        private readonly Fornecedor_Service fs;
        private readonly Fornecedor_Produto_Service fps;
        public C_FornecedorProduto()
        {
            fs = new Fornecedor_Service();
            fps = new Fornecedor_Produto_Service();
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
            comboBox1.DataSource = fs.ListarTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                MessageBox.Show("Informe um código para o produto.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedIndex != -1)
            {
                Fornecedor_Produto fp = new Fornecedor_Produto
                {
                    Codigo = Convert.ToInt32(textBox1.Text),
                    Nome = textBox2.Text,
                    Descricao = richTextBox1.Text,
                    FornecedorId = (int)comboBox1.SelectedValue,
                };

                fps.Criar(fp);
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
