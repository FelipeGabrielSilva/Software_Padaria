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

namespace WindowsForm_Padaria.Forms.Venda
{
    public partial class RVenda : Form
    {
        private readonly Padaria_Produto_Service pps;
        public RVenda()
        {
            pps = new Padaria_Produto_Service();
            InitializeComponent();
            GetProdutos();
        }

        private void GetProdutos()
        {
            try
            {
                List<Padaria_Produto> lp = new List<Padaria_Produto>();
                lp = pps.ListarTodos();

                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Nome";
                comboBox1.DataSource = lp;
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos na ComboBox: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                PesquisarESelecionarProdutoPorCodigo();
            }
        }

        private void PesquisarESelecionarProdutoPorCodigo()
        {
            // Renomeie 'textBox1' no designer para 'textBox2' para maior clareza
            if (string.IsNullOrWhiteSpace(textBox2.Text)) // Usando o nome claro
            {
                comboBox1.SelectedIndex = -1; // Limpa a seleção na ComboBox
                return;
            }

            int codigoDigitado;
            if (!int.TryParse(textBox2.Text, out codigoDigitado)) // Usando o nome claro
            {
                MessageBox.Show("Por favor, digite um código de produto numérico válido.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.SelectedIndex = -1;
                return;
            }

            List<Padaria_Produto> produtosNaComboBox = comboBox1.DataSource as List<Padaria_Produto>;

            if (produtosNaComboBox == null)
            {
                MessageBox.Show("Erro interno: A lista de produtos não foi carregada corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Padaria_Produto produtoEncontrado = produtosNaComboBox.FirstOrDefault(p => p.Codigo == codigoDigitado);

            if (produtoEncontrado != null)
            {
                comboBox1.SelectedValue = produtoEncontrado.Id;
            }
            else
            {
                MessageBox.Show($"Produto com código '{codigoDigitado}' não encontrado.", "Produto Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.SelectedIndex = -1; 
                textBox2.Clear(); 
                textBox2.Focus(); 
            }
        }
    }
}
