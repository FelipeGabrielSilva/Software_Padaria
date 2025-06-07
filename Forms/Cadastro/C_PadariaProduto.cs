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
    public partial class C_PadariaProduto : Form
    {
        private readonly Padaria_Produto_Service pps;
        private readonly Categoria_Service cs;
        public C_PadariaProduto()
        {
            pps = new Padaria_Produto_Service();
            cs = new Categoria_Service();
            InitializeComponent();
            AtualizarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Padaria_Produto p = new Padaria_Produto
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                Preco = decimal.Parse(txtPreco.Text),
                CategoriaId = (int)cmbCategoria.SelectedValue,
            };

            pps.Criar(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarGrid()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.DataSource = cs.ListarTodos();
        }
    }
}
