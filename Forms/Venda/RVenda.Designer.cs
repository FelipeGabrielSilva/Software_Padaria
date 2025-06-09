namespace WindowsForm_Padaria.Forms.Venda
{
    partial class RVenda
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            txtQuantidade = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            vendaBindingSource = new BindingSource(components);
            dataGridViewItensVenda = new DataGridView();
            codigoProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemVendaBindingSource = new BindingSource(components);
            lblTotalVenda = new Label();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItensVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 0;
            label1.Text = "Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 105);
            label2.Name = "label2";
            label2.Size = new Size(188, 47);
            label2.TabIndex = 1;
            label2.Text = "Produto:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(551, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(600, 55);
            comboBox1.TabIndex = 100;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(1467, 102);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(150, 53);
            txtQuantidade.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1210, 105);
            label3.Name = "label3";
            label3.Size = new Size(251, 47);
            label3.TabIndex = 4;
            label3.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 16F);
            button1.Location = new Point(1700, 105);
            button1.Name = "button1";
            button1.Size = new Size(200, 48);
            button1.TabIndex = 3;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 101);
            label4.Name = "label4";
            label4.Size = new Size(167, 47);
            label4.TabIndex = 1;
            label4.Text = "Código:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 53);
            textBox2.TabIndex = 1;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Model.CVenda);
            // 
            // dataGridViewItensVenda
            // 
            dataGridViewItensVenda.AllowUserToResizeRows = false;
            dataGridViewItensVenda.AutoGenerateColumns = false;
            dataGridViewItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewItensVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewItensVenda.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItensVenda.Columns.AddRange(new DataGridViewColumn[] { codigoProdutoDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, precoUnitarioDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn });
            dataGridViewItensVenda.DataSource = itemVendaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewItensVenda.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItensVenda.Location = new Point(222, 230);
            dataGridViewItensVenda.Name = "dataGridViewItensVenda";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewItensVenda.Size = new Size(1500, 400);
            dataGridViewItensVenda.TabIndex = 6;
            // 
            // codigoProdutoDataGridViewTextBoxColumn
            // 
            codigoProdutoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProduto";
            codigoProdutoDataGridViewTextBoxColumn.HeaderText = "Código";
            codigoProdutoDataGridViewTextBoxColumn.Name = "codigoProdutoDataGridViewTextBoxColumn";
            codigoProdutoDataGridViewTextBoxColumn.Width = 116;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.Width = 168;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preço Un.";
            precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            precoUnitarioDataGridViewTextBoxColumn.Width = 155;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            subtotalDataGridViewTextBoxColumn.Width = 142;
            // 
            // itemVendaBindingSource
            // 
            itemVendaBindingSource.DataSource = typeof(Model.ItemVenda);
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.AutoSize = true;
            lblTotalVenda.Location = new Point(1471, 667);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(251, 47);
            lblTotalVenda.TabIndex = 7;
            lblTotalVenda.Text = "Preço total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1315, 667);
            label5.Name = "label5";
            label5.Size = new Size(146, 47);
            label5.TabIndex = 101;
            label5.Text = "TOTAL:";
            // 
            // button2
            // 
            button2.Font = new Font("JetBrains Mono", 16F);
            button2.Location = new Point(222, 800);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 102;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 167);
            label6.Name = "label6";
            label6.Size = new Size(209, 47);
            label6.TabIndex = 103;
            label6.Text = "CPF/CNPJ:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 53);
            textBox1.TabIndex = 104;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("JetBrains Mono", 16F);
            button3.Location = new Point(1522, 800);
            button3.Name = "button3";
            button3.Size = new Size(200, 48);
            button3.TabIndex = 105;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(847, 725);
            label7.Name = "label7";
            label7.Size = new Size(419, 47);
            label7.TabIndex = 106;
            label7.Text = "Forma de pagamento:";
            label7.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1272, 722);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(450, 55);
            comboBox2.TabIndex = 107;
            // 
            // RVenda
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2400, 1061);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(lblTotalVenda);
            Controls.Add(dataGridViewItensVenda);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtQuantidade);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(9);
            Name = "RVenda";
            Text = "Venda";
            Load += RVenda_Load_1;
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItensVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemVendaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox txtQuantidade;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private BindingSource vendaBindingSource;
        private DataGridView dataGridViewItensVenda;
        private Label lblTotalVenda;
        private Label label5;
        private BindingSource itemVendaBindingSource;
        private Button button2;
        private DataGridViewTextBoxColumn codigoProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private Label label6;
        private TextBox textBox1;
        private Button button3;
        private Label label7;
        private ComboBox comboBox2;
    }
}