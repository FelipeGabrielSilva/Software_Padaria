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
    public partial class AdcFornecedorProduto : Form
    {
        private int _produtoId;
        private readonly Estoque_Prod_Fornecedor_Service epfs;
        private readonly Fornecedor_Service fs;
        public AdcFornecedorProduto(int pId)
        {
            _produtoId = pId;
            epfs = new Estoque_Prod_Fornecedor_Service();
            fs = new Fornecedor_Service();
            InitializeComponent();
            AtualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estoque_Prod_Fornecedor epf = new Estoque_Prod_Fornecedor
            {
                FornecedorId = (int)comboBox1.SelectedValue,
                ProdutoId = _produtoId,
                Quantidade = Convert.ToInt32(textBox1.Text),
                Tipo = Tipo.Entrada,
                Entrada = DateTime.Now,
                Atualizacao = DateTime.Now,
            };

            epfs.Criar(epf);
            this.DialogResult = DialogResult.OK;
        }

        private void AtualizarGrid()
        {
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
            comboBox1.DataSource = fs.ListarTodos();
        }
    }
}
