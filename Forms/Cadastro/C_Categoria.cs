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
    public partial class C_Categoria : Form
    {
        private readonly Categoria_Service cs;
        public C_Categoria()
        {
            cs = new Categoria_Service();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria
            {
                Nome = txtNome.Text,
                Descricao = richTextBox1.Text,
            };
         
            cs.Criar(c);
        }
    }
}
