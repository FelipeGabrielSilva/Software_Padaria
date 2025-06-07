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
    public partial class C_Receita : Form
    {
        private readonly Receita_Service rs;
        public C_Receita()
        {
            rs = new Receita_Service();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receita r = new Receita { 
                Nome = textBox1.Text, 
                Descricao = richTextBox1.Text 
            };

            rs.Criar(r);
        }
    }
}
