namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_Receita
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
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(519, 58);
            label1.TabIndex = 0;
            label1.Text = "CADASTRO DE RECEITA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(155, 58);
            label2.TabIndex = 1;
            label2.Text = "NOME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(285, 58);
            label3.TabIndex = 2;
            label3.Text = "DESCRIÇÃO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 65);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(303, 308);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 300);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 780);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 6;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1662, 780);
            button2.Name = "button2";
            button2.Size = new Size(250, 64);
            button2.TabIndex = 4;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(259, 58);
            label4.TabIndex = 8;
            label4.Text = "PRODUTOS:";
            // 
            // C_Receita
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "C_Receita";
            Text = "C_Receita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}