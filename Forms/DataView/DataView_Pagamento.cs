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

namespace WindowsForm_Padaria.Forms.Tabela
{
    public partial class DataView_Pagamento : Form
    {
        private readonly AppDbContext _context;

        public DataView_Pagamento()
        {
            InitializeComponent();
            _context = new AppDbContext();
            AtualizarGrid();
        }


        private void AtualizarGrid ()
        {
            List<Pagamento> p = new List<Pagamento>();
            p = _context.Pagamento.ToList();

            dataGridView1.DataSource = p;
        }
    }
}
