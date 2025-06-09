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
    }
}
