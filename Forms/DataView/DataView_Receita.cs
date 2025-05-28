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

namespace WindowsForm_Padaria.Forms.Tabela
{
    public partial class DataView_Receita : Form
    {
        private readonly Receita_Service receita_Service;
        public DataView_Receita()
        {
            receita_Service = new Receita_Service();
            InitializeComponent();
            receita_Service.PopularBanco();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            List<Receita> r = new List<Receita>();
            r = receita_Service.ListarTodos();

            dataGridView1.DataSource = r;
        }
    }
}
