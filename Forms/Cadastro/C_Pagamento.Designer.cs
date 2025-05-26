namespace WindowsForm_Padaria.Forms.Cadastro
{
    partial class C_Pagamento
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
            txtDescricao = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(303, 95);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(800, 64);
            txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(285, 58);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(545, 58);
            label1.TabIndex = 1;
            label1.Text = "Cadastro - Pagamento";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1662, 780);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(250, 64);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 780);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(250, 64);
            btnSair.TabIndex = 5;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // C_Pagamento
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnSalvar);
            Controls.Add(btnSair);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("JetBrains Mono", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(10, 9, 10, 9);
            Name = "C_Pagamento";
            Text = "Pagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtDescricao;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private Button btnSair;
    }
}