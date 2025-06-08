namespace WindowsForm_Padaria.Forms.Estoque
{
    partial class E_Prod_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_Prod_Fornecedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            estoqueProdFornecedorBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            estoqueProdFornecedorBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // estoqueProdFornecedorBindingSource
            // 
            estoqueProdFornecedorBindingSource.DataSource = typeof(Model.Estoque_Prod_Fornecedor);
            // 
            // button1
            // 
            button1.Location = new Point(12, 800);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 12;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1662, 800);
            button2.Name = "button2";
            button2.Size = new Size(250, 64);
            button2.TabIndex = 13;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(650, 47);
            label1.TabIndex = 1;
            label1.Text = "Estoque - Produto (Fornecedor)";
            // 
            // button3
            // 
            button3.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 86);
            button3.Name = "button3";
            button3.Size = new Size(200, 48);
            button3.TabIndex = 19;
            button3.Text = "Adicionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(291, 86);
            button4.Name = "button4";
            button4.Size = new Size(200, 48);
            button4.TabIndex = 20;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(567, 86);
            button5.Name = "button5";
            button5.Size = new Size(200, 48);
            button5.TabIndex = 21;
            button5.Text = "Atualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(476, 37);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(497, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.DataSource = estoqueProdFornecedorBindingSource1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Location = new Point(12, 217);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Size = new Size(825, 156);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Quantidade";
            dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 168;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FornecedorId";
            dataGridViewTextBoxColumn3.HeaderText = "FornecedorId";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 194;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ProdutoId";
            dataGridViewTextBoxColumn4.HeaderText = "ProdutoId";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 155;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Tipo";
            dataGridViewTextBoxColumn5.HeaderText = "Tipo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 90;
            // 
            // estoqueProdFornecedorBindingSource1
            // 
            estoqueProdFornecedorBindingSource1.DataSource = typeof(Model.Estoque_Prod_Fornecedor);
            // 
            // E_Prod_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "E_Prod_Fornecedor";
            Text = "Estoque_Prod_Fornecedor";
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private BindingSource estoqueProdFornecedorBindingSource;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource estoqueProdFornecedorBindingSource1;
    }
}