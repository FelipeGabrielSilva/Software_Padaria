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

namespace WindowsForm_Padaria.Forms.Components
{
    public partial class AdcPadariaProduto : Form
    {
        private int _produtoId;
        private readonly Estoque_Prod_Padaria_Service epps;
        private readonly Padaria_Produto_Service pps;

        public AdcPadariaProduto(int pId)
        {
            _produtoId = pId;
            epps = new Estoque_Prod_Padaria_Service();
            pps = new Padaria_Produto_Service();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estoque_Prod_Padaria epp = new Estoque_Prod_Padaria
            {
                ProdutoId = _produtoId,
                Quantidade = Convert.ToInt32(textBox1.Text),
                Tipo = Tipo.Entrada,
                Descricao = richTextBox1.Text,
                Entrada = DateTime.Now,
                Atualizacao = DateTime.Now,
            };

            epps.Criar(epp);
            this.DialogResult = DialogResult.OK;
        }
    }
}
