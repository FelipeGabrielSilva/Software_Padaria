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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(805, 58);
            label1.TabIndex = 1;
            label1.Text = "Estoque - Produto (Fornecedor)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 58);
            label2.TabIndex = 2;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(51, 58);
            label3.TabIndex = 3;
            label3.Text = "A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(51, 58);
            label4.TabIndex = 4;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 366);
            label5.Name = "label5";
            label5.Size = new Size(51, 58);
            label5.TabIndex = 5;
            label5.Text = "A";
            // 
            // E_Prod_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "E_Prod_Fornecedor";
            Text = "Estoque_Prod_Fornecedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}