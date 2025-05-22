namespace WindowsForm_Padaria.Forms.Estoque
{
    partial class Estoque_Fornecedor
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fornecedorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            produtoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estoqueProdFornecedorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 26F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(883, 58);
            label1.TabIndex = 1;
            label1.Text = "ESTOQUE DE PRODUTOS DO FORNECEDOR";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, fornecedorIdDataGridViewTextBoxColumn, fornecedorDataGridViewTextBoxColumn, produtoIdDataGridViewTextBoxColumn, produtoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = estoqueProdFornecedorBindingSource;
            dataGridView1.Location = new Point(12, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(930, 255);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorIdDataGridViewTextBoxColumn
            // 
            fornecedorIdDataGridViewTextBoxColumn.DataPropertyName = "FornecedorId";
            fornecedorIdDataGridViewTextBoxColumn.HeaderText = "FornecedorId";
            fornecedorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorIdDataGridViewTextBoxColumn.Name = "fornecedorIdDataGridViewTextBoxColumn";
            fornecedorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            fornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            fornecedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            produtoIdDataGridViewTextBoxColumn.HeaderText = "ProdutoId";
            produtoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            produtoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            produtoDataGridViewTextBoxColumn.MinimumWidth = 6;
            produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            produtoDataGridViewTextBoxColumn.Width = 125;
            // 
            // estoqueProdFornecedorBindingSource
            // 
            estoqueProdFornecedorBindingSource.DataSource = typeof(Model.Estoque_Prod_Fornecedor);
            // 
            // Estoque_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(25F, 51F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2500, 1148);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 26F);
            Margin = new Padding(9, 8, 9, 8);
            Name = "Estoque_Fornecedor";
            Text = "Estoque_Fornecedor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)estoqueProdFornecedorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource estoqueProdFornecedorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
    }
}