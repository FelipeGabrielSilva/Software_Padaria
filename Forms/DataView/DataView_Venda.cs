using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;
using WindowsForm_Padaria.Services;
using WindowsForm_Padaria.ViewModels;

namespace WindowsForm_Padaria.Forms.Tabela
{
    public partial class DataView_Venda : Form
    {
        private readonly Venda_Service vs;
        public DataView_Venda()
        {
            vs = new Venda_Service();
            InitializeComponent();
            ConfigurardataGridView1();
            ListarTodasVendasParaGridView();
            AtualizarGrid();
        }

        public List<VendaViewModel> ListarTodasVendasParaGridView()
        {
            using (var context = new AppDbContext()) 
            {
                return context.Venda 
                               .Include(v => v.Pagamento) 
                               .Include(v => v.VendaProdutos) 
                                   .ThenInclude(vp => vp.Produto) 
                               .OrderByDescending(v => v.Data) 
                               .Select(v => new VendaViewModel 
                               {
                                   Id = v.Id,
                                   Data = v.Data,
                                   Status = v.Status.ToString(), 
                                   CPF_CNPJ = v.CPF_CNPJ,
                                   PrecoTotal = v.Preco, 
                                   TipoPagamento = v.Pagamento.Nome, 
                                   ProdutosNaVenda = string.Join(", ", v.VendaProdutos.Select(vp => $"{vp.Produto.Nome} ({vp.Quantidade})"))
                               })
                               .ToList();
            }
        }

        private void ConfigurardataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear(); 

            dataGridView1.DefaultCellStyle.Font = new Font("JetBrains Mono", 16f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("JetBrains Mono", 20f, FontStyle.Regular);

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True; 

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells, 
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colData",
                HeaderText = "DATA",
                DataPropertyName = "Data",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true,
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colStatus",
                HeaderText = "STATUS",
                DataPropertyName = "Status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colCpfCnpj",
                HeaderText = "CPF/CNPJ",
                DataPropertyName = "CPF_CNPJ",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colPrecoTotal",
                HeaderText = "TOTAL",
                DataPropertyName = "PrecoTotal",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true,
                DefaultCellStyle = { Format = "C2", FormatProvider = new System.Globalization.CultureInfo("pt-BR") }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTipoPagamento",
                HeaderText = "PAGAMENTO",
                DataPropertyName = "TipoPagamento",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProdutosNaVenda",
                HeaderText = "PRODUTOS",
                DataPropertyName = "ProdutosNaVenda",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, 
                ReadOnly = true
            });

        }

        private void AtualizarGrid()
        {
            try
            {
                List<VendaViewModel> vendas = ListarTodasVendasParaGridView(); 
                dataGridView1.DataSource = vendas; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar vendas: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
