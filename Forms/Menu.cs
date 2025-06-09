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
using WindowsForm_Padaria.Forms.DataView;
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
            return;
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
            panel1.Controls.Clear();
            C_FornecedorProduto fp = new C_FornecedorProduto();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;

            panel1.Controls.Add(fp);
            fp.Show();
        }

        private void pRODUTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            C_PadariaProduto pp = new C_PadariaProduto();
            pp.TopLevel = false;
            pp.FormBorderStyle = FormBorderStyle.None;
            pp.Dock = DockStyle.Fill;

            panel1.Controls.Add(pp);
            pp.Show();
        }

        private void pADARIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            E_Prod_Padaria ep = new E_Prod_Padaria();
            ep.TopLevel = false;
            ep.FormBorderStyle = FormBorderStyle.None;
            ep.Dock = DockStyle.Fill;

            panel1.Controls.Add(ep);
            ep.Show();
        }

        private void fORNECEDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            E_Prod_Fornecedor ef = new E_Prod_Fornecedor();
            ef.TopLevel = false;
            ef.FormBorderStyle = FormBorderStyle.None;
            ef.Dock = DockStyle.Fill;

            panel1.Controls.Add(ef);
            ef.Show();
        }

        private void cATEGORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Categoria dvc = new DataView_Categoria();
            dvc.TopLevel = false;
            dvc.FormBorderStyle = FormBorderStyle.None;
            dvc.Dock = DockStyle.Fill;

            panel1.Controls.Add(dvc);
            dvc.Show();
        }

        private void fORNECEDORToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Dataview_Fornecedor dvf = new Dataview_Fornecedor();
            dvf.TopLevel = false;
            dvf.FormBorderStyle = FormBorderStyle.None;
            dvf.Dock = DockStyle.Fill;

            panel1.Controls.Add(dvf);
            dvf.Show();
        }

        private void pAGAMENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Pagamento dvp = new DataView_Pagamento();
            dvp.TopLevel = false;
            dvp.FormBorderStyle = FormBorderStyle.None;
            dvp.Dock = DockStyle.Fill;

            panel1.Controls.Add(dvp);
            dvp.Show();
        }

        private void rECEITAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Receita dvr = new DataView_Receita();
            dvr.TopLevel = false;
            dvr.FormBorderStyle = FormBorderStyle.None;
            dvr.Dock = DockStyle.Fill;

            panel1.Controls.Add(dvr);
            dvr.Show();
        }

        private void vENDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_Venda dvv = new DataView_Venda();
            dvv.TopLevel = false;
            dvv.FormBorderStyle = FormBorderStyle.None;
            dvv.Dock = DockStyle.Fill;

            panel1.Controls.Add(dvv);
            dvv.Show();
        }

        private void padariaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_PadariaProduto dtpp = new DataView_PadariaProduto();
            dtpp.TopLevel = false;
            dtpp.FormBorderStyle = FormBorderStyle.None;
            dtpp.Dock = DockStyle.Fill;

            panel1.Controls.Add(dtpp);
            dtpp.Show();
        }

        private void fornecedorProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DataView_FornecedorProduto dtfp = new DataView_FornecedorProduto();
            dtfp.TopLevel = false;
            dtfp.FormBorderStyle = FormBorderStyle.None;
            dtfp.Dock = DockStyle.Fill;

            panel1.Controls.Add(dtfp);
            dtfp.Show();
        }

        private void pADARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
