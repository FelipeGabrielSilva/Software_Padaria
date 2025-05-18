namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_FornecedorProduto
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(987, 58);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE PRODUTOS DOS FORNECEDORES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(207, 58);
            label2.TabIndex = 1;
            label2.Text = "CÓDIGO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(155, 58);
            label3.TabIndex = 2;
            label3.Text = "NOME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 259);
            label4.Name = "label4";
            label4.Size = new Size(285, 58);
            label4.TabIndex = 3;
            label4.Text = "DESCRIÇÃO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 65);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(800, 65);
            textBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(303, 259);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(670, 300);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(1662, 780);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 7;
            button1.Text = "SALVAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 780);
            button2.Name = "button2";
            button2.Size = new Size(250, 64);
            button2.TabIndex = 8;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // C_FornecedorProduto
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "C_FornecedorProduto";
            Text = "C_FornecedorProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}