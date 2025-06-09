using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsForm_Padaria.Model;
using WindowsForm_Padaria.Resources;
using Microsoft.EntityFrameworkCore;
using iText.Kernel.Geom;
using WindowsForm_Padaria.Forms.Components;

namespace WindowsForm_Padaria.Forms.Relatorio
{
    public partial class FormRelatorio : Form
    {
        private readonly AppDbContext context;
        public FormRelatorio()
        {
            context = new AppDbContext();
            InitializeComponent();
        }

        private void RelatorioFornecedores_Click(object sender, EventArgs e)
        {
            string caminhoDoDiretorio = @"C:\Dev\";
            string nomeDoArquivo = $"RelatorioFornecedores_{DateTime.Now:ddMMyyyy_HH}.pdf";
            string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

            List<Fornecedor> fornecedores;

            fornecedores = context.Fornecedor
                                      .Include(f => f.Pagamento)
                                      .OrderBy(f => f.Nome)
                                      .ToList();

            if (fornecedores == null || !fornecedores.Any())
            {
                MessageBox.Show("Não há fornecedores para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // INÍCIO DA GERAÇÃO DO PDF
            using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
            using (var pdfDocument = new PdfDocument(pdfWriter))
            {
                Document doc = new Document(pdfDocument, PageSize.A4.Rotate());

                PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                Paragraph titulo = new Paragraph("RELATÓRIO DE FORNECEDORES - PADARIA")
                                    .SetFont(fontNegrito)
                                    .SetFontSize(18)
                                    .SetFontColor(iText.Kernel.Colors.ColorConstants.BLACK)
                                    .SetTextAlignment(TextAlignment.CENTER)
                                    .SetMarginBottom(20);
                doc.Add(titulo);

                Paragraph subtitulo = new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                        .SetFont(fontPadrao)
                                        .SetFontSize(10)
                                        .SetTextAlignment(TextAlignment.RIGHT)
                                        .SetMarginBottom(15);
                doc.Add(subtitulo);

                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 25, 18, 15, 22, 10, 10 }));
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetMarginBottom(10);

                iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(52, 73, 94);

                table.AddHeaderCell(new Cell().Add(new Paragraph("Nome").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                table.AddHeaderCell(new Cell().Add(new Paragraph("CNPJ").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Telefone").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Email").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Bairro").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Tipo Pgto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                foreach (var fornecedor in fornecedores)
                {
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.Nome).SetFont(fontPadrao).SetFontSize(9)));
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.CNPJ).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.Telefone).SetFont(fontPadrao).SetFontSize(9)));
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.Email).SetFont(fontPadrao).SetFontSize(9)));
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.Bairro).SetFont(fontPadrao).SetFontSize(9)));
                    table.AddCell(new Cell().Add(new Paragraph(fornecedor.Pagamento?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                }

                doc.Add(table);

                doc.Close();
            }

            MessageBox.Show("Relatório de fornecedores gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });

        }

        private void RelatorioProdutosFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Defina o caminho completo do arquivo PDF
                string caminhoDoDiretorio = @"C:\Dev\";
                string nomeDoArquivo = $"RelatorioProdutosFornecedores_{DateTime.Now:ddMMyyyy_HH}.pdf";
                string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                List<Fornecedor_Produto> produtosFornecedores;
                produtosFornecedores = context.Fornecedor_Produto
                                               .Include(fp => fp.Fornecedor)
                                               .OrderBy(fp => fp.Nome)
                                               .ToList();

                if (produtosFornecedores == null || !produtosFornecedores.Any())
                {
                    MessageBox.Show("Não há produtos de fornecedores para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // INÍCIO DA GERAÇÃO DO PDF
                using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    Document doc = new Document(pdfDocument, PageSize.A4.Rotate());

                    PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    Paragraph titulo = new Paragraph("RELATÓRIO DE PRODUTOS DE FORNECEDORES")
                                        .SetFont(fontNegrito)
                                        .SetFontSize(18)
                                        .SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetMarginBottom(20);
                    doc.Add(titulo);

                    Paragraph subtitulo = new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                            .SetFont(fontPadrao)
                                            .SetFontSize(10)
                                            .SetTextAlignment(TextAlignment.RIGHT)
                                            .SetMarginBottom(15);
                    doc.Add(subtitulo);

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 25, 35, 30 }));
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.SetMarginBottom(10);

                    iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(10, 102, 194);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Código").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Nome do Produto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Descrição").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Fornecedor").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                    foreach (var produtoFornecedor in produtosFornecedores)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(produtoFornecedor.Codigo.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoFornecedor.Nome).SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoFornecedor.Descricao).SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoFornecedor.Fornecedor?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                    }

                    doc.Add(table);

                    doc.Close();
                }

                MessageBox.Show("Relatório de produtos de fornecedores gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RelatorioReceita_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoDoDiretorio = @"C:\Dev\";
                string nomeDoArquivo = $"RelatorioReceitas_{DateTime.Now:ddMMyyyy_HH}.pdf";
                string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                List<Receita> receitas;
                receitas = context.Receita
                                   .OrderBy(r => r.Nome)
                                   .ToList();

                if (receitas == null || !receitas.Any())
                {
                    MessageBox.Show("Não há receitas para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // INÍCIO DA GERAÇÃO DO PDF
                using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    Document doc = new Document(pdfDocument, PageSize.A4.Rotate());

                    PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    Paragraph titulo = new Paragraph("RELATÓRIO DE RECEITAS DA PADARIA")
                                        .SetFont(fontNegrito)
                                        .SetFontSize(18)
                                        .SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetMarginBottom(20);
                    doc.Add(titulo);

                    Paragraph subtitulo = new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                            .SetFont(fontPadrao)
                                            .SetFontSize(10)
                                            .SetTextAlignment(TextAlignment.RIGHT)
                                            .SetMarginBottom(15);
                    doc.Add(subtitulo);

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 30, 70 }));
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.SetMarginBottom(10);

                    iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(19, 131, 15);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Nome da Receita").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Descrição").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                    foreach (var receita in receitas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(receita.Nome).SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(receita.Descricao).SetFont(fontPadrao).SetFontSize(9)));
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("Relatório de receitas gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RelatorioProdutosPadaria_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoDoDiretorio = @"C:\Dev\";
                string nomeDoArquivo = $"RelatorioProdutosPadartia_{DateTime.Now:ddMMyyyy_HH}.pdf";
                string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                List<Padaria_Produto> produtosPadaria;

                produtosPadaria = context.Padaria_Produto
                                               .Include(p => p.Categoria)
                                               .OrderBy(p => p.Nome)
                                               .ToList();

                if (produtosPadaria == null || !produtosPadaria.Any())
                {
                    MessageBox.Show("Não há produtos da padaria para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // INÍCIO DA GERAÇÃO DO PDF
                using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    Document doc = new Document(pdfDocument, PageSize.A4.Rotate());

                    PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    Paragraph titulo = new Paragraph("RELATÓRIO DE PRODUTOS DA PADARIA")
                                        .SetFont(fontNegrito)
                                        .SetFontSize(18)
                                        .SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                        .SetTextAlignment(TextAlignment.CENTER)
                                        .SetMarginBottom(20);
                    doc.Add(titulo);

                    Paragraph subtitulo = new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                            .SetFont(fontPadrao)
                                            .SetFontSize(10)
                                            .SetTextAlignment(TextAlignment.RIGHT)
                                            .SetMarginBottom(15);
                    doc.Add(subtitulo);

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 25, 35, 15, 15 }));
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.SetMarginBottom(10);

                    iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(15, 75, 130);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("Código").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Nome do Produto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Descrição").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Preço").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Categoria").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                    foreach (var produtoPadaria in produtosPadaria)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(produtoPadaria.Codigo.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoPadaria.Nome).SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoPadaria.Descricao).SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoPadaria.Preco.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(produtoPadaria.Categoria?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("Relatório de produtos da padaria gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RelatorioEntradaProdutosFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoDoDiretorio = @"C:\Dev\";
                string nomeDoArquivo = $"RelatorioEntradaProdutosFornecedores_{DateTime.Now:ddMMyyyy_HH}.pdf";
                string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                List<Estoque_Prod_Fornecedor> entradasFornecedores;
                using (var dbContext = new AppDbContext())
                {
                    entradasFornecedores = dbContext.Estoque_Prod_Fornecedor
                                                   .Include(e => e.Fornecedor)
                                                   .Include(e => e.Produto)
                                                   .Where(e => e.Tipo == Tipo.Entrada)
                                                   .OrderByDescending(e => e.Entrada)
                                                   .ToList();
                }

                if (entradasFornecedores == null || !entradasFornecedores.Any())
                {
                    MessageBox.Show("Não há registros de entrada de produtos de fornecedores para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // INÍCIO DA GERAÇÃO DO PDF
                using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    Document doc = new Document(pdfDocument, PageSize.A4);

                    PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(139, 0, 0);

                    doc.Add(new Paragraph("RELATÓRIO DE ENTRADA DE PRODUTOS DE FORNECEDORES")
                                .SetFont(fontNegrito).SetFontSize(18).SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                .SetTextAlignment(TextAlignment.CENTER).SetMarginBottom(10));
                    doc.Add(new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                .SetFont(fontPadrao).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT).SetMarginBottom(15));

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 15, 25, 30, 20 })); // 5 colunas
                    table.SetWidth(UnitValue.CreatePercentValue(100)).SetMarginBottom(10);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("ID").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Quantidade").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Fornecedor").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Produto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Data Entrada").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                    foreach (var entrada in entradasFornecedores)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(entrada.Id.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(entrada.Quantidade.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(entrada.Fornecedor?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(entrada.Produto?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9)));
                        table.AddCell(new Cell().Add(new Paragraph(entrada.Entrada?.ToString("dd/MM/yyyy HH:mm") ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("Relatório de entrada de produtos de fornecedores gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RelatorioSaidaProdutosPadaria_Click(object sender, EventArgs e)
        {
            using (RelatorioVendaSelecionarDia formSelecionarDia = new RelatorioVendaSelecionarDia())
            {
                DialogResult resultado = formSelecionarDia.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    DateTime dataFiltro = formSelecionarDia.DataSelecionada;

                    try
                    {
                        string caminhoDoDiretorio = @"C:\Dev\";
                        string nomeDoArquivo = $"RelatorioSaidaProdutosPadaria_{DateTime.Now:ddMMyyyy_HH}.pdf";
                        string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                        List<Estoque_Prod_Padaria> saidasPadaria;
                        using (var dbContext = new AppDbContext())
                        {
                            saidasPadaria = dbContext.Estoque_Prod_Padaria
                                                    .Include(e => e.Produto)
                                                    .Where(e => e.Tipo == Tipo.Saida && e.Saida.Date == dataFiltro.Date)
                                                    .OrderByDescending(e => e.Saida)
                                                    .ToList();
                        }

                        if (saidasPadaria == null || !saidasPadaria.Any())
                        {
                            MessageBox.Show("Não há registros de saída de produtos da padaria para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        int totalQuantidadeSaida = saidasPadaria.Sum(s => s.Quantidade);
                        decimal precoTotalSaida = saidasPadaria.Sum(s => (s.Produto?.Preco ?? 0m) * s.Quantidade);

                        // INÍCIO DA GERAÇÃO DO PDF
                        using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                        using (var pdfDocument = new PdfDocument(pdfWriter))
                        {
                            Document doc = new Document(pdfDocument, PageSize.A4);

                            PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                            PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                            iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(200, 0, 0);

                            doc.Add(new Paragraph("RELATÓRIO DE SAÍDA DE PRODUTOS DA PADARIA")
                                        .SetFont(fontNegrito).SetFontSize(18).SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                        .SetTextAlignment(TextAlignment.CENTER).SetMarginBottom(10));
                            doc.Add(new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                        .SetFont(fontPadrao).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT).SetMarginBottom(15));

                            Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 25, 15, 15, 35 })); // 5 colunas
                            table.SetWidth(UnitValue.CreatePercentValue(100)).SetMarginBottom(10);

                            table.AddHeaderCell(new Cell().Add(new Paragraph("ID").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Produto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Qtd.").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Data Saída").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Descrição").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                            foreach (var saida in saidasPadaria)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(saida.Id.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                                table.AddCell(new Cell().Add(new Paragraph(saida.Produto?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9)));
                                table.AddCell(new Cell().Add(new Paragraph(saida.Quantidade.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                                table.AddCell(new Cell().Add(new Paragraph(saida.Saida.ToString("dd/MM/yyyy HH:mm")).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                                table.AddCell(new Cell().Add(new Paragraph(saida.Descricao ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                            }

                            table.AddCell(new Cell(1, 4)
                                    .Add(new Paragraph("Total Saída:").SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                                    .SetPaddingRight(5));

                            table.AddCell(new Cell()
                                    .Add(new Paragraph(totalQuantidadeSaida.ToString()).SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY));

                            table.AddCell(new Cell(1, 4)
                                    .Add(new Paragraph("VALOR TOTAL:").SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                                    .SetPaddingRight(5));


                            table.AddCell(new Cell()
                                    .Add(new Paragraph(precoTotalSaida.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))).SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER))
                                    .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY));

                            doc.Add(table);
                            doc.Close();
                        }

                        MessageBox.Show("Relatório de saída de produtos da padaria gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
                    }
                    finally
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Operação cancelada. Nenhum relatório será gerado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void RelatorioVendas_Click(object sender, EventArgs e)
        {
            Status statusSelecionadoPeloUsuario;
            DateTime dataDeFiltro;

            using (RelatorioVendaSelecionarStatus formSelecionarStatus = new RelatorioVendaSelecionarStatus())
            {
                DialogResult resultadoDialogo = formSelecionarStatus.ShowDialog();

                if (resultadoDialogo == DialogResult.OK)
                {
                    statusSelecionadoPeloUsuario = formSelecionarStatus.StatusSelecionado;
                    dataDeFiltro = formSelecionarStatus.DataSelecionada;
                }
                else
                {
                    MessageBox.Show("Geração de relatório cancelada pelo usuário.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
            }

            GerarRelatorioVendasPdf(statusSelecionadoPeloUsuario, dataDeFiltro);
        }

        private void GerarRelatorioVendasPdf(Status statusDeFiltro, DateTime dataDeFiltro)
        {
            try
            {
                string caminhoDoDiretorio = @"C:\Dev\";
                string nomeDoArquivo = $"RelatorioVendaStatus{DateTime.Now:ddMMyyyy_HH}.pdf";
                string caminhoCompletoDoArquivo = System.IO.Path.Combine(caminhoDoDiretorio, nomeDoArquivo);

                List<CVenda> vendas;
                using (var dbContext = new AppDbContext())
                {
                    vendas = dbContext.Venda
                                     .Include(v => v.Pagamento)
                                     .Include(v => v.VendaProdutos)
                                         .ThenInclude(vp => vp.Produto)
                                     .Where(v => v.Status == statusDeFiltro && v.Data.Date == dataDeFiltro)
                                     .OrderByDescending(v => v.Data)
                                     .ToList();
                }

                if (vendas == null || !vendas.Any())
                {
                    MessageBox.Show($"Não há vendas com status '{statusDeFiltro.ToString()}' para gerar o relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var pdfWriter = new PdfWriter(caminhoCompletoDoArquivo))
                using (var pdfDocument = new PdfDocument(pdfWriter))
                {
                    Document doc = new Document(pdfDocument, PageSize.A4.Rotate());

                    PdfFont fontPadrao = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                    PdfFont fontNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    iText.Kernel.Colors.Color corHeader = new iText.Kernel.Colors.DeviceRgb(0, 128, 0); 

                    doc.Add(new Paragraph("RELATÓRIO DE VENDAS")
                                .SetFont(fontNegrito).SetFontSize(18).SetFontColor(iText.Kernel.Colors.ColorConstants.DARK_GRAY)
                                .SetTextAlignment(TextAlignment.CENTER).SetMarginBottom(10));
                    doc.Add(new Paragraph($"Vendas com Status: {statusDeFiltro.ToString()}") 
                                .SetFont(fontPadrao).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).SetMarginBottom(5));
                    doc.Add(new Paragraph($"Gerado em: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}")
                                .SetFont(fontPadrao).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT).SetMarginBottom(15));

                    Table table = new Table(UnitValue.CreatePercentArray(new float[] { 10, 10, 10, 15, 15, 35 })); 
                    table.SetWidth(UnitValue.CreatePercentValue(100)).SetMarginBottom(10);

                    table.AddHeaderCell(new Cell().Add(new Paragraph("ID").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Data").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Status").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Total Venda").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Forma Pgto").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));
                    table.AddHeaderCell(new Cell().Add(new Paragraph("Produtos").SetFont(fontNegrito).SetFontColor(iText.Kernel.Colors.ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(corHeader));

                    foreach (var venda in vendas)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(venda.Id.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(venda.Data.ToString("dd/MM/yyyy HH:mm")).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(venda.Status.ToString()).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(venda.Preco.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))).SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));
                        table.AddCell(new Cell().Add(new Paragraph(venda.Pagamento?.Nome ?? "N/A").SetFont(fontPadrao).SetFontSize(9).SetTextAlignment(TextAlignment.CENTER)));

                        string produtosVendidos = string.Join(", ", venda.VendaProdutos.Select(vp => $"{vp.Produto?.Nome ?? "N/A"} ({vp.Quantidade})"));
                        table.AddCell(new Cell().Add(new Paragraph(produtosVendidos).SetFont(fontPadrao).SetFontSize(7)));
                    }

                    decimal totalVendasPreco = vendas.Sum(v => v.Preco);

                    table.AddCell(new Cell(1, 3) 
                        .Add(new Paragraph("Total Vendas:").SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT))
                        .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                        .SetPaddingRight(5));
                    table.AddCell(new Cell() 
                        .Add(new Paragraph(totalVendasPreco.ToString("C2", new System.Globalization.CultureInfo("pt-BR"))).SetFont(fontNegrito).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT))
                        .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY));

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show($"Relatório de vendas com status '{statusDeFiltro.ToString()}' gerado com sucesso em:\n" + caminhoCompletoDoArquivo, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(caminhoCompletoDoArquivo) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
