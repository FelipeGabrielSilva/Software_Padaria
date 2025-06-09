namespace WindowsForm_Padaria.Forms.Relatorio
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RelatorioFornecedores = new Button();
            label1 = new Label();
            RelatorioProdutosFornecedores = new Button();
            RelatorioReceita = new Button();
            RelatorioProdutosPadaria = new Button();
            RelatorioEntradaProdutosFornecedores = new Button();
            RelatorioSaidaProdutosPadaria = new Button();
            SuspendLayout();
            // 
            // RelatorioFornecedores
            // 
            RelatorioFornecedores.Font = new Font("JetBrains Mono", 16F);
            RelatorioFornecedores.Location = new Point(12, 91);
            RelatorioFornecedores.Name = "RelatorioFornecedores";
            RelatorioFornecedores.Size = new Size(300, 48);
            RelatorioFornecedores.TabIndex = 0;
            RelatorioFornecedores.Text = "Fornecedores";
            RelatorioFornecedores.UseVisualStyleBackColor = true;
            RelatorioFornecedores.Click += RelatorioFornecedores_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 48F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 84);
            label1.TabIndex = 1;
            label1.Text = "Relatórios:";
            // 
            // RelatorioProdutosFornecedores
            // 
            RelatorioProdutosFornecedores.Font = new Font("JetBrains Mono", 16F);
            RelatorioProdutosFornecedores.Location = new Point(12, 145);
            RelatorioProdutosFornecedores.Name = "RelatorioProdutosFornecedores";
            RelatorioProdutosFornecedores.Size = new Size(300, 48);
            RelatorioProdutosFornecedores.TabIndex = 2;
            RelatorioProdutosFornecedores.Text = "Produtos Fornecedores";
            RelatorioProdutosFornecedores.UseVisualStyleBackColor = true;
            RelatorioProdutosFornecedores.Click += RelatorioProdutosFornecedores_Click;
            // 
            // RelatorioReceita
            // 
            RelatorioReceita.Font = new Font("JetBrains Mono", 16F);
            RelatorioReceita.Location = new Point(12, 253);
            RelatorioReceita.Name = "RelatorioReceita";
            RelatorioReceita.Size = new Size(300, 48);
            RelatorioReceita.TabIndex = 3;
            RelatorioReceita.Text = "Receitas";
            RelatorioReceita.UseVisualStyleBackColor = true;
            RelatorioReceita.Click += RelatorioReceita_Click;
            // 
            // RelatorioProdutosPadaria
            // 
            RelatorioProdutosPadaria.Font = new Font("JetBrains Mono", 16F);
            RelatorioProdutosPadaria.Location = new Point(12, 307);
            RelatorioProdutosPadaria.Name = "RelatorioProdutosPadaria";
            RelatorioProdutosPadaria.Size = new Size(300, 48);
            RelatorioProdutosPadaria.TabIndex = 4;
            RelatorioProdutosPadaria.Text = "Produtos Padaria";
            RelatorioProdutosPadaria.UseVisualStyleBackColor = true;
            RelatorioProdutosPadaria.Click += RelatorioProdutosPadaria_Click;
            // 
            // RelatorioEntradaProdutosFornecedores
            // 
            RelatorioEntradaProdutosFornecedores.Font = new Font("JetBrains Mono", 16F);
            RelatorioEntradaProdutosFornecedores.Location = new Point(12, 199);
            RelatorioEntradaProdutosFornecedores.Name = "RelatorioEntradaProdutosFornecedores";
            RelatorioEntradaProdutosFornecedores.Size = new Size(300, 48);
            RelatorioEntradaProdutosFornecedores.TabIndex = 5;
            RelatorioEntradaProdutosFornecedores.Text = "Entrada - Fornecedor";
            RelatorioEntradaProdutosFornecedores.UseVisualStyleBackColor = true;
            RelatorioEntradaProdutosFornecedores.Click += RelatorioEntradaProdutosFornecedores_Click;
            // 
            // RelatorioSaidaProdutosPadaria
            // 
            RelatorioSaidaProdutosPadaria.Font = new Font("JetBrains Mono", 16F);
            RelatorioSaidaProdutosPadaria.Location = new Point(12, 361);
            RelatorioSaidaProdutosPadaria.Name = "RelatorioSaidaProdutosPadaria";
            RelatorioSaidaProdutosPadaria.Size = new Size(300, 48);
            RelatorioSaidaProdutosPadaria.TabIndex = 6;
            RelatorioSaidaProdutosPadaria.Text = "Saída - Padaria";
            RelatorioSaidaProdutosPadaria.UseVisualStyleBackColor = true;
            RelatorioSaidaProdutosPadaria.Click += RelatorioSaidaProdutosPadaria_Click;
            // 
            // FormRelatorio
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(RelatorioSaidaProdutosPadaria);
            Controls.Add(RelatorioEntradaProdutosFornecedores);
            Controls.Add(RelatorioProdutosPadaria);
            Controls.Add(RelatorioReceita);
            Controls.Add(RelatorioProdutosFornecedores);
            Controls.Add(label1);
            Controls.Add(RelatorioFornecedores);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(9);
            Name = "FormRelatorio";
            Text = "Relatorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RelatorioFornecedores;
        private Label label1;
        private Button RelatorioProdutosFornecedores;
        private Button RelatorioReceita;
        private Button RelatorioProdutosPadaria;
        private Button RelatorioEntradaProdutosFornecedores;
        private Button RelatorioSaidaProdutosPadaria;
    }
}