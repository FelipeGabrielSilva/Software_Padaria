using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Padaria.Forms.Estoque
{
    public partial class E_Prod_Fornecedor : Form
    {
        public E_Prod_Fornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
