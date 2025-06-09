using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Padaria.Forms.Components;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Services;

namespace WindowsForm_Padaria.Forms.Estoque
{
    public partial class E_Prod_Fornecedor : Form
    {
        private readonly Fornecedor_Produto_Service fps;
        private readonly Estoque_Prod_Fornecedor_Service epfs;
        private List<Fornecedor_Produto> lfp = new List<Fornecedor_Produto>();

        public E_Prod_Fornecedor()
        {
            fps = new Fornecedor_Produto_Service();
            epfs = new Estoque_Prod_Fornecedor_Service();
            lfp = new List<Fornecedor_Produto>();
            InitializeComponent();
            epfs.PopularBanco();
            AtualizarGrid();
            AtualizarTabela();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                AdcFornecedorProduto apf = new AdcFornecedorProduto((int)comboBox1.SelectedValue);

                if (apf.ShowDialog() == DialogResult.OK)
                {
                    AtualizarTabela();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto na lista antes de adicionar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void AtualizarGrid()
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Descricao";
            lfp = fps.ListarTodos();
            comboBox1.DataSource = lfp;
            comboBox1.SelectedIndex = -1;
        }

        private void AtualizarTabela()
        {
            List<Estoque_Prod_Fornecedor> e = new List<Estoque_Prod_Fornecedor>();
            e = epfs.ListarTodos();

            dataGridView2.DataSource = e;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AplicarFiltroProdutos()
        {
        }
    }
}
