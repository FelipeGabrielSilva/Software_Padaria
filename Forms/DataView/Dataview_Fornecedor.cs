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
    public partial class Dataview_Fornecedor : Form
    {
        private readonly Fornecedor_Service fornecedor_Service;

        public Dataview_Fornecedor()
        {
            fornecedor_Service = new Fornecedor_Service();
            fornecedor_Service.PopularBanco();
            InitializeComponent();
            AtualizarGrid();
        }

        private void AtualizarGrid ()
        {
            List<Fornecedor> f = new List<Fornecedor>();
            f = fornecedor_Service.ListarTodos();

            dataGridView1.DataSource = f;

        }
    }
}
