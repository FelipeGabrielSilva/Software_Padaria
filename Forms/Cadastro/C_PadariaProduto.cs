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

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_PadariaProduto : Form
    {
        public C_PadariaProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            Padaria_Produto P = new Padaria_Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = float.Parse(txtPreco.Text),
                CategoriaId = cmbCategoria.SelectedValue,
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
