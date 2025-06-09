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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            lblTotalVenda = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItensVenda).BeginInit();
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
            vendaBindingSource.DataSource = typeof(Model.Venda);
            // 
            // dataGridViewItensVenda
            // 
            dataGridViewItensVenda.AllowUserToResizeRows = false;
            dataGridViewItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewItensVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewItensVenda.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewItensVenda.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewItensVenda.Location = new Point(222, 192);
            dataGridViewItensVenda.Name = "dataGridViewItensVenda";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewItensVenda.Size = new Size(1500, 400);
            dataGridViewItensVenda.TabIndex = 6;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.AutoSize = true;
            lblTotalVenda.Location = new Point(1471, 617);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(251, 47);
            lblTotalVenda.TabIndex = 7;
            lblTotalVenda.Text = "Preço total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1315, 617);
            label5.Name = "label5";
            label5.Size = new Size(146, 47);
            label5.TabIndex = 101;
            label5.Text = "TOTAL:";
            // 
            // RVenda
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2400, 1061);
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
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItensVenda).EndInit();
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
    }
}