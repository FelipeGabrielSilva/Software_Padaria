namespace WindowsForm_Padaria.Forms.Components
{
    partial class AdcPadariaProduto
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
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 29);
            label1.TabIndex = 0;
            label1.Text = "Quantidade:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 36);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(164, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(728, 128);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(143, 29);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(200, 48);
            button1.TabIndex = 4;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(692, 221);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 5;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AdcPadariaProduto
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 281);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 16F);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AdcPadariaProduto";
            Text = "Adicionar estoque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}