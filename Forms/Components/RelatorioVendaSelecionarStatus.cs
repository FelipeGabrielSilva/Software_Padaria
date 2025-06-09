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

namespace WindowsForm_Padaria.Forms.Components
{
    public partial class RelatorioVendaSelecionarStatus : Form
    {
        public Status StatusSelecionado { get; private set; }
        public DateTime DataSelecionada { get; private set; } 

        public RelatorioVendaSelecionarStatus()
        {
            InitializeComponent();
            CarregarStatusNaComboBox();
            dtpDataVenda.Value = DateTime.Today;
        }

        private void CarregarStatusNaComboBox()
        {
            var statusValores = Enum.GetValues(typeof(Status)).Cast<Status>().ToList();

            cmbStatusVenda.DataSource = statusValores;
            cmbStatusVenda.SelectedIndex = 0;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (cmbStatusVenda.SelectedItem != null)
            {
                StatusSelecionado = (Status)cmbStatusVenda.SelectedItem;
                DataSelecionada = dtpDataVenda.Value.Date;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um status.", "Seleção Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
