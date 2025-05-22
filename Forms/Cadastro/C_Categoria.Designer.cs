namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_Categoria
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
            txtNome = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(571, 58);
            label1.TabIndex = 1;
            label1.Text = "CADASTRO DE CATEGORIA";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 78);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(800, 65);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(155, 58);
            label2.TabIndex = 2;
            label2.Text = "NOME:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 780);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 4;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1662, 780);
            button2.Name = "button2";
            button2.Size = new Size(250, 64);
            button2.TabIndex = 5;
            button2.Text = "SALVAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // C_Categoria
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "C_Categoria";
            Text = "C_Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}