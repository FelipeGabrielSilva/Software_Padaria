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
        private readonly Venda_Service vs;
        private readonly Pagamento_Service ps;

        public RVenda()
        {
            pps = new Padaria_Produto_Service();
            vs = new Venda_Service();
            ps = new Pagamento_Service();
            InitializeComponent();
            GetInformacoes();
            itensVendaAtual = new List<ItemVenda>();
            AtualizarDataGridViewItensVenda();
            CalcularTotalVenda();
        }

        private void GetInformacoes()
        {
            try
            {
                List<Padaria_Produto> lp = new List<Padaria_Produto>();
                lp = pps.ListarTodos();

                List<Pagamento> lpg = new List<Pagamento>();
                lpg = ps.ListarTodos();

                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Nome";
                comboBox1.DataSource = lp;
                comboBox1.SelectedIndex = -1;

                comboBox2.ValueMember = "Id";
                comboBox2.DisplayMember = "Nome";
                comboBox2.DataSource = lpg;
                comboBox2.SelectedIndex = -1;
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
            GetInformacoes();
        }

        private void RVenda_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewItensVenda_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            itensVendaAtual.Clear();
            AtualizarDataGridViewItensVenda();
        }

        // Botão para reazlizar a venda
        private void button3_Click(object sender, EventArgs e)
        {
            if (!itensVendaAtual.Any())
            {
                MessageBox.Show("Não é possível finalizar uma venda sem itens.", "Venda Vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox2.SelectedValue == null || (int)comboBox2.SelectedValue <= 0)
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento.", "Forma de Pagamento Necessária", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox2.Focus();
                return;
            }

            string cpfCnpjCliente = textBox1.Text;
            int tipoPagamentoId = (int)comboBox2.SelectedValue;

            if (string.IsNullOrWhiteSpace(cpfCnpjCliente))
            {
                cpfCnpjCliente = null;
            }
            else
            {
                cpfCnpjCliente = cpfCnpjCliente.Replace(".", "").Replace("-", "").Replace("/", "").Trim();

                if (cpfCnpjCliente.Length != 11 && cpfCnpjCliente.Length != 14) 
                {
                    MessageBox.Show("CPF/CNPJ inválido. Digite 11 ou 14 dígitos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return;
                }
            }

            try
            {
                vs.Criar(itensVendaAtual, cpfCnpjCliente, tipoPagamentoId);

                MessageBox.Show("Venda finalizada e salva com sucesso!", "Sucesso na Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparTelaParaNovaVenda();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Erro de validação: {argEx.Message}", "Erro de Venda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao finalizar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparTelaParaNovaVenda()
        {
            itensVendaAtual.Clear();
            AtualizarDataGridViewItensVenda();

            textBox1.Clear();
            textBox2.Clear();
            txtQuantidade.Text = "0";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            textBox2.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
