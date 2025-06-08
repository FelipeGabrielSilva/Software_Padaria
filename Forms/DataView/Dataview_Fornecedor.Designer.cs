namespace WindowsForm_Padaria.Forms.Tabela
{
    partial class Dataview_Fornecedor
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            fornecedorBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enderecoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bairroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cNPJDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Pagamento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 47);
            label1.TabIndex = 0;
            label1.Text = "Fornecedores";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, enderecoDataGridViewTextBoxColumn, bairroDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, cNPJDataGridViewTextBoxColumn, Pagamento });
            dataGridView1.DataSource = fornecedorBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 64;
            dataGridView1.Size = new Size(1800, 500);
            dataGridView1.TabIndex = 1;
            // 
            // fornecedorBindingSource
            // 
            fornecedorBindingSource.DataSource = typeof(Model.Fornecedor);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 64;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 90;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.Width = 142;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 103;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            enderecoDataGridViewTextBoxColumn.MinimumWidth = 6;
            enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            enderecoDataGridViewTextBoxColumn.Width = 142;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            bairroDataGridViewTextBoxColumn.MinimumWidth = 6;
            bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            bairroDataGridViewTextBoxColumn.Width = 116;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.Width = 116;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            cNPJDataGridViewTextBoxColumn.MinimumWidth = 6;
            cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            cNPJDataGridViewTextBoxColumn.Width = 90;
            // 
            // Pagamento
            // 
            Pagamento.DataPropertyName = "Pagamento";
            Pagamento.HeaderText = "Pagamento";
            Pagamento.Name = "Pagamento";
            Pagamento.Width = 155;
            // 
            // Dataview_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "Dataview_Fornecedor";
            Text = "Dataview_Fornecedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fornecedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource fornecedorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Pagamento;
    }
}