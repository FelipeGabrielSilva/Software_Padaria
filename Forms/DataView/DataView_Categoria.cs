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
using WindowsForm_Padaria.Resources;
using WindowsForm_Padaria.Services;

namespace WindowsForm_Padaria.Forms.Tabela
{
    public partial class DataView_Categoria : Form
    {
        private readonly Categoria_Service categoria_Service;
        public DataView_Categoria()
        {
            categoria_Service = new Categoria_Service();
            InitializeComponent();
            categoria_Service.PopularBanco();
            AtualizarGrid();
        }

        private void AtualizarGrid() 
        { 
            List<Categoria> c = new List<Categoria>();
            c = categoria_Service.ListarTodos();

            dataGridView1.DataSource = c;
        }
    }
}
