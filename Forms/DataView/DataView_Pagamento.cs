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
    public partial class DataView_Pagamento : Form
    {
        private readonly Pagamento_Service ps;

        public DataView_Pagamento()
        {
            ps = new Pagamento_Service();
            InitializeComponent();
            AtualizarGrid();
        }


        private void AtualizarGrid ()
        {
            List<Pagamento> p = new List<Pagamento>();
            p = ps.ListarTodos();

            dataGridView1.DataSource = p;
        }
    }
}
