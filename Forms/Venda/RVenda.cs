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
        private List<ItemVenda> itensVendaAtual;

        public RVenda()
        {
            pps = new Padaria_Produto_Service();
            InitializeComponent();
            GetProdutos();
            itensVendaAtual = new List<ItemVenda>();
            AtualizarDataGridViewItensVenda();
            CalcularTotalVenda();
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
                txtQuantidade.Focus();
            }
        }

        private void PesquisarESelecionarProdutoPorCodigo()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                comboBox1.SelectedIndex = -1;
                return;
            }

            int codigoDigitado;
            if (!int.TryParse(textBox2.Text, out codigoDigitado))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || (int)comboBox1.SelectedValue == -1)
            {
                MessageBox.Show("Por favor, selecione um produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantidade;
            if (!int.TryParse(txtQuantidade.Text, out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Por favor, digite uma quantidade válida (número inteiro maior que zero).", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
                return;
            }

            Padaria_Produto produtoSelecionado = comboBox1.SelectedItem as Padaria_Produto;

            if (produtoSelecionado == null)
            {
                MessageBox.Show("Produto selecionado inválido. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ItemVenda itemExistente = itensVendaAtual.FirstOrDefault(item => item.ProdutoId == produtoSelecionado.Id);

            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                ItemVenda novoItem = new ItemVenda
                {
                    ProdutoId = produtoSelecionado.Id,
                    CodigoProduto = produtoSelecionado.Codigo.ToString(),
                    NomeProduto = produtoSelecionado.Nome,
                    Quantidade = quantidade,
                    PrecoUnitario = produtoSelecionado.Preco
                };
                itensVendaAtual.Add(novoItem);
            }

            AtualizarDataGridViewItensVenda();

            textBox2.Clear();
            txtQuantidade.Text = "1";
            comboBox1.SelectedIndex = -1;
            textBox2.Focus();
        }

        private void AtualizarDataGridViewItensVenda()
        {
            dataGridViewItensVenda.DataSource = null;
            dataGridViewItensVenda.DataSource = itensVendaAtual;
            CalcularTotalVenda();
        }

        private void CalcularTotalVenda()
        {
            decimal total = itensVendaAtual.Sum(item => item.Subtotal);
            lblTotalVenda.Text = total.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
        }



        private void RVenda_Load(object sender, EventArgs e)
        {
            GetProdutos();
        }

        private void RVenda_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewItensVenda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi dentro de uma célula válida
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Verifica se clicou na coluna do botão "Remover"
            if (dataGridViewItensVenda.Columns[e.ColumnIndex].Name == "btnRemoverItem")
            {
                if (e.RowIndex >= itensVendaAtual.Count)
                {
                    // Índice da linha é inválido para a lista de itens
                    MessageBox.Show("Erro interno: índice fora da lista de itens da venda.");
                    return;
                }

                // Confirmação da exclusão
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja realmente remover este item da venda?",
                    "Confirmar Remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        var item = dataGridViewItensVenda.Rows[e.RowIndex].DataBoundItem as ItemVenda;
                        if (item != null)
                        {
                            itensVendaAtual.Remove(item);
                            AtualizarDataGridViewItensVenda();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao remover item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itensVendaAtual.Clear();
            AtualizarDataGridViewItensVenda();
        }
    }
}
