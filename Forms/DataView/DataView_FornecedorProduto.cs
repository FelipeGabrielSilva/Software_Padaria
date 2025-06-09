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

namespace WindowsForm_Padaria.Forms.DataView
{
    public partial class DataView_FornecedorProduto : Form
    {
        private readonly Fornecedor_Produto_Service fps;
        public DataView_FornecedorProduto()
        {
            fps = new Fornecedor_Produto_Service();
            fps.PopularBanco();
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            List<Fornecedor_Produto> listFps = new List<Fornecedor_Produto>();
            listFps = fps.ListarTodos();

            dataGridView1.DataSource = listFps;
        }
    }
}
