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
    public partial class DataView_PadariaProduto : Form
    {
        private readonly Padaria_Produto_Service _service;
        public DataView_PadariaProduto()
        {
            _service = new Padaria_Produto_Service();
            InitializeComponent();
            _service.PopularBanco();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            List<Padaria_Produto> pp = new List<Padaria_Produto>();
            pp = _service.ListarTodos();

            dataGridView1.DataSource = pp;
        }
    }
}
