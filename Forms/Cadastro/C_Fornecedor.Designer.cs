namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_Fornecedor
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtEndereco = new TextBox();
            txtNumero = new TextBox();
            txtBairro = new TextBox();
            txtCnpj = new TextBox();
            cmbPagamento = new ComboBox();
            button1 = new Button();
            btnSair = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(571, 58);
            label1.TabIndex = 0;
            label1.Text = "Cadastro - Fornecedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(155, 58);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 163);
            label3.Name = "label3";
            label3.Size = new Size(181, 58);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 231);
            label4.Name = "label4";
            label4.Size = new Size(259, 58);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(259, 58);
            label5.TabIndex = 4;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 373);
            label6.Name = "label6";
            label6.Size = new Size(207, 58);
            label6.TabIndex = 5;
            label6.Text = "Bairro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 446);
            label7.Name = "label7";
            label7.Size = new Size(207, 58);
            label7.TabIndex = 6;
            label7.Text = "Número:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 516);
            label8.Name = "label8";
            label8.Size = new Size(155, 58);
            label8.TabIndex = 7;
            label8.Text = "CNPJ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 591);
            label9.Name = "label9";
            label9.Size = new Size(285, 58);
            label9.TabIndex = 8;
            label9.Text = "Pagamento:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(173, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(800, 64);
            txtNome.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(800, 64);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(277, 230);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(500, 64);
            txtTelefone.TabIndex = 11;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(277, 300);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(800, 64);
            txtEndereco.TabIndex = 12;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(227, 443);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(300, 64);
            txtNumero.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(227, 370);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(750, 64);
            txtBairro.TabIndex = 13;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(173, 513);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(750, 64);
            txtCnpj.TabIndex = 15;
            txtCnpj.TextChanged += textBox7_TextChanged;
            // 
            // cmbPagamento
            // 
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(303, 588);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(300, 65);
            cmbPagamento.TabIndex = 16;
            cmbPagamento.SelectedIndexChanged += cmbPagamento_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(123, 789);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 780);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(250, 64);
            btnSair.TabIndex = 18;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1662, 780);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(250, 64);
            btnSalvar.TabIndex = 19;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // C_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            Controls.Add(button1);
            Controls.Add(cmbPagamento);
            Controls.Add(txtCnpj);
            Controls.Add(txtBairro);
            Controls.Add(txtNumero);
            Controls.Add(txtEndereco);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(9);
            Name = "C_Fornecedor";
            Text = "Fornecedor";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private TextBox txtCnpj;
        private ComboBox cmbPagamento;
        private Button button1;
        private Button btnSair;
        private Button btnSalvar;
    }
}