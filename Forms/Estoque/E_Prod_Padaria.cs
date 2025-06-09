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
    public partial class E_Prod_Padaria : Form
    {
        private readonly Estoque_Prod_Padaria_Service epps;
        private readonly Padaria_Produto_Service pps;

        public E_Prod_Padaria()
        {
            epps = new Estoque_Prod_Padaria_Service();
            pps = new Padaria_Produto_Service();
            InitializeComponent();
            AtualizarGrid();
            AtualizarTabela();
            epps.PopularBanco();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                AdcPadariaProduto app = new AdcPadariaProduto((int)comboBox1.SelectedValue);

                if (app.ShowDialog() == DialogResult.OK)
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

        private void AtualizarGrid()
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
            comboBox1.DataSource = pps.ListarTodos();
            comboBox1.SelectedIndex = -1;
        }

        private void AtualizarTabela()
        {
            List<Estoque_Prod_Padaria> lepp = new List<Estoque_Prod_Padaria>();
            lepp = epps.ListarTodos();

            dataGridView1.DataSource = lepp;
        }
    }
}
