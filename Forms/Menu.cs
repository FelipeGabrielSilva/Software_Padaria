using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Padaria.Forms.Cadastro;
using WindowsForm_Padaria.Forms.Estoque;
using WindowsForm_Padaria.Forms.Tabela;

namespace WindowsForm_Padaria.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_Fornecedor f = new C_Fornecedor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panel1.Controls.Add(f);
            f.Show();
        }

        private void eMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_Fornecedor f = new C_Fornecedor();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panel1.Controls.Add(f);
            f.Show();
        }

        private void pAGAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_Pagamento p = new C_Pagamento();
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.Fill;

            panel1.Controls.Add(p);
            p.Show();
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_Categoria c = new C_Categoria();
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;

            panel1.Controls.Add(c);
            c.Show();
        }

        private void rECEITAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_Receita r = new C_Receita();
            r.TopLevel = false;
            r.FormBorderStyle = FormBorderStyle.None;
            r.Dock = DockStyle.Fill;

            panel1.Controls.Add(r);
            r.Show();
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pAGAMENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Pagamento dtp = new DataView_Pagamento();
            dtp.TopLevel = false;
            dtp.FormBorderStyle = FormBorderStyle.None;
            dtp.Dock = DockStyle.Fill;

            panel1.Controls.Add(dtp);
            dtp.Show();
        }

        private void fORNECEDORToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dataview_Fornecedor dtf = new Dataview_Fornecedor();
            dtf.TopLevel = false;
            dtf.FormBorderStyle = FormBorderStyle.None;
            dtf.Dock = DockStyle.Fill;

            panel1.Controls.Add(dtf);
            dtf.Show();
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Categoria dtc = new DataView_Categoria();
            dtc.TopLevel = false;
            dtc.FormBorderStyle = FormBorderStyle.None;
            dtc.Dock = DockStyle.Fill;

            panel1.Controls.Add(dtc);
            dtc.Show();
        }
    }
}
