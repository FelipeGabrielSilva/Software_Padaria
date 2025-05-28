using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Padaria.Forms.Components;

namespace WindowsForm_Padaria.Forms.Cadastro
{
    public partial class C_Receita : Form
    {
        public C_Receita()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelecaoProdutos sp = new SelecaoProdutos();
            sp.Show();
        }
    }
}
