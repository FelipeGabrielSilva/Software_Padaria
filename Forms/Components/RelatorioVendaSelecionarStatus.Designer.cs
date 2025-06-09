namespace WindowsForm_Padaria.Forms.Components
{
    partial class RelatorioVendaSelecionarStatus
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
            cmbStatusVenda = new ComboBox();
            label1 = new Label();
            cancelar = new Button();
            confirmar = new Button();
            label2 = new Label();
            dtpDataVenda = new DateTimePicker();
            SuspendLayout();
            // 
            // cmbStatusVenda
            // 
            cmbStatusVenda.FormattingEnabled = true;
            cmbStatusVenda.Location = new Point(185, 20);
            cmbStatusVenda.Name = "cmbStatusVenda";
            cmbStatusVenda.Size = new Size(485, 55);
            cmbStatusVenda.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 47);
            label1.TabIndex = 1;
            label1.Text = "Status:";
            // 
            // cancelar
            // 
            cancelar.Font = new Font("JetBrains Mono", 16F);
            cancelar.Location = new Point(12, 209);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(200, 48);
            cancelar.TabIndex = 2;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // confirmar
            // 
            confirmar.Font = new Font("JetBrains Mono", 16F);
            confirmar.Location = new Point(470, 209);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(200, 48);
            confirmar.TabIndex = 3;
            confirmar.Text = "Confirmar";
            confirmar.UseVisualStyleBackColor = true;
            confirmar.Click += confirmar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 47);
            label2.TabIndex = 4;
            label2.Text = "Dia:";
            // 
            // dtpDataVenda
            // 
            dtpDataVenda.Font = new Font("JetBrains Mono", 16F);
            dtpDataVenda.Location = new Point(122, 119);
            dtpDataVenda.Name = "dtpDataVenda";
            dtpDataVenda.Size = new Size(548, 36);
            dtpDataVenda.TabIndex = 5;
            // 
            // RelatorioVendaSelecionarStatus
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 269);
            Controls.Add(dtpDataVenda);
            Controls.Add(label2);
            Controls.Add(confirmar);
            Controls.Add(cancelar);
            Controls.Add(label1);
            Controls.Add(cmbStatusVenda);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(9);
            Name = "RelatorioVendaSelecionarStatus";
            Text = "RelatorioVendaSelecionarStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatusVenda;
        private Label label1;
        private Button cancelar;
        private Button confirmar;
        private Label label2;
        private DateTimePicker dtpDataVenda;
    }
}