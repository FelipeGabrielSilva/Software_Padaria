namespace WindowsForm_Padaria.Forms.Components
{
    partial class RelatorioVendaSelecionarDia
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(618, 316);
            dateTimePicker1.Margin = new Padding(9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(592, 53);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 47);
            label1.TabIndex = 1;
            label1.Text = "Dia:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("JetBrains Mono", 16F);
            dateTimePicker2.Font = new Font("JetBrains Mono", 16F);
            dateTimePicker2.Location = new Point(124, 17);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(538, 36);
            dateTimePicker2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 16F);
            button1.Location = new Point(12, 123);
            button1.Name = "button1";
            button1.Size = new Size(200, 48);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("JetBrains Mono", 16F);
            button2.Location = new Point(372, 123);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 4;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RelatorioVendaSelecionarDia
            // 
            AutoScaleDimensions = new SizeF(21F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 183);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Font = new Font("JetBrains Mono", 26F);
            Margin = new Padding(9);
            Name = "RelatorioVendaSelecionarDia";
            Text = "Selecionar data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button2;
    }
}