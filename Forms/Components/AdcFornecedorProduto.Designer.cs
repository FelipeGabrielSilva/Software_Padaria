namespace WindowsForm_Padaria.Forms.Components
{
    partial class AdcFornecedorProduto
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 0;
            label1.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 67);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 1;
            label2.Text = "Fornecedor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(226, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(664, 37);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 36);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 168);
            button1.Name = "button1";
            button1.Size = new Size(200, 48);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(690, 168);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 5;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdcFornecedorProduto
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 240);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdcFornecedorProduto";
            Text = "Estoque de produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}