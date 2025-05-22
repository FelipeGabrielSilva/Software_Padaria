namespace WindowsForm_Padaria.Forms.Estoque
{
    partial class E_Prod_Pararia
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
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            label1.Size = new Size(805, 58);
            label1.TabIndex = 0;
            label1.Text = "ESTOQUE DE PRODUTOS DA PADARIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(233, 58);
            label2.TabIndex = 1;
            label2.Text = "PRODUTO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(155, 58);
            label3.TabIndex = 2;
            label3.Text = "TIPO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 282);
            label4.Name = "label4";
            label4.Size = new Size(311, 58);
            label4.TabIndex = 3;
            label4.Text = "QUANTIDADE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 373);
            label5.Name = "label5";
            label5.Size = new Size(155, 58);
            label5.TabIndex = 4;
            label5.Text = "DATA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 462);
            label6.Name = "label6";
            label6.Size = new Size(311, 58);
            label6.TabIndex = 5;
            label6.Text = "OBSERVAÇÃO:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(251, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(566, 65);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(173, 192);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(288, 65);
            comboBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 65);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 65);
            textBox2.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(329, 462);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(488, 228);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 780);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 11;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1662, 780);
            button2.Name = "button2";
            button2.Size = new Size(250, 64);
            button2.TabIndex = 12;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // E_Prod_Pararia
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
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "E_Prod_Pararia";
            Text = "Estoque_Prod_Pararia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}