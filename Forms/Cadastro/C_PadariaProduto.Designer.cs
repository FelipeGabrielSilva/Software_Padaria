namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_PadariaProduto
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
            txtDescricao = new RichTextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            cmbCategoria = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(519, 58);
            label1.TabIndex = 1;
            label1.Text = "CADASTRO DE PRODUTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(155, 58);
            label2.TabIndex = 2;
            label2.Text = "NOME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 320);
            label3.Name = "label3";
            label3.Size = new Size(285, 58);
            label3.TabIndex = 3;
            label3.Text = "DESCRIÇÃO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(181, 58);
            label4.TabIndex = 4;
            label4.Text = "PREÇO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(285, 58);
            label5.TabIndex = 5;
            label5.Text = "CATEGORIA:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(303, 320);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(455, 304);
            txtDescricao.TabIndex = 4;
            txtDescricao.Text = "";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(585, 65);
            txtNome.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(199, 161);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(225, 65);
            txtPreco.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(303, 243);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(455, 65);
            cmbCategoria.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 780);
            button1.Name = "button1";
            button1.Size = new Size(250, 64);
            button1.TabIndex = 8;
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
            // C_PadariaProduto
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbCategoria);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtDescricao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(10, 9, 10, 9);
            Name = "C_PadariaProduto";
            Text = "C_PadariaProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtPreco;
        private ComboBox cmbCategoria;
        private Button button1;
        private Button button2;
    }
}