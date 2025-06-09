using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Padaria.Forms.Components
{
    public partial class RelatorioVendaSelecionarDia : Form
    {
        public DateTime DataSelecionada
        {
            get { return dateTimePicker2.Value.Date; } 
        }


        public RelatorioVendaSelecionarDia()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
