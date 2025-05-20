namespace WindowsForm_Padaria.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip2 = new MenuStrip();
            cADASTROToolStripMenuItem = new ToolStripMenuItem();
            fORNECEDORToolStripMenuItem = new ToolStripMenuItem();
            eMPRESAToolStripMenuItem = new ToolStripMenuItem();
            pRODUTOToolStripMenuItem = new ToolStripMenuItem();
            pADARIAToolStripMenuItem = new ToolStripMenuItem();
            pRODUTOToolStripMenuItem1 = new ToolStripMenuItem();
            rECEITAToolStripMenuItem = new ToolStripMenuItem();
            cATEGORIAToolStripMenuItem = new ToolStripMenuItem();
            pAGAMENTOToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ControlLight;
            menuStrip2.Font = new Font("JetBrains Mono", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { cADASTROToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1563, 66);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // cADASTROToolStripMenuItem
            // 
            cADASTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fORNECEDORToolStripMenuItem, pADARIAToolStripMenuItem, pAGAMENTOToolStripMenuItem });
            cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            cADASTROToolStripMenuItem.Size = new Size(247, 62);
            cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // fORNECEDORToolStripMenuItem
            // 
            fORNECEDORToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { eMPRESAToolStripMenuItem, pRODUTOToolStripMenuItem });
            fORNECEDORToolStripMenuItem.Name = "fORNECEDORToolStripMenuItem";
            fORNECEDORToolStripMenuItem.Size = new Size(384, 62);
            fORNECEDORToolStripMenuItem.Text = "FORNECEDOR";
            fORNECEDORToolStripMenuItem.Click += fORNECEDORToolStripMenuItem_Click;
            // 
            // eMPRESAToolStripMenuItem
            // 
            eMPRESAToolStripMenuItem.Name = "eMPRESAToolStripMenuItem";
            eMPRESAToolStripMenuItem.Size = new Size(306, 62);
            eMPRESAToolStripMenuItem.Text = "EMPRESA";
            eMPRESAToolStripMenuItem.Click += eMPRESAToolStripMenuItem_Click;
            // 
            // pRODUTOToolStripMenuItem
            // 
            pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            pRODUTOToolStripMenuItem.Size = new Size(306, 62);
            pRODUTOToolStripMenuItem.Text = "PRODUTO";
            pRODUTOToolStripMenuItem.Click += pRODUTOToolStripMenuItem_Click;
            // 
            // pADARIAToolStripMenuItem
            // 
            pADARIAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pRODUTOToolStripMenuItem1, rECEITAToolStripMenuItem, cATEGORIAToolStripMenuItem });
            pADARIAToolStripMenuItem.Name = "pADARIAToolStripMenuItem";
            pADARIAToolStripMenuItem.Size = new Size(384, 62);
            pADARIAToolStripMenuItem.Text = "PADARIA";
            // 
            // pRODUTOToolStripMenuItem1
            // 
            pRODUTOToolStripMenuItem1.Name = "pRODUTOToolStripMenuItem1";
            pRODUTOToolStripMenuItem1.Size = new Size(358, 62);
            pRODUTOToolStripMenuItem1.Text = "PRODUTO";
            pRODUTOToolStripMenuItem1.Click += pRODUTOToolStripMenuItem1_Click;
            // 
            // rECEITAToolStripMenuItem
            // 
            rECEITAToolStripMenuItem.Name = "rECEITAToolStripMenuItem";
            rECEITAToolStripMenuItem.Size = new Size(358, 62);
            rECEITAToolStripMenuItem.Text = "RECEITA";
            rECEITAToolStripMenuItem.Click += rECEITAToolStripMenuItem_Click;
            // 
            // cATEGORIAToolStripMenuItem
            // 
            cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            cATEGORIAToolStripMenuItem.Size = new Size(358, 62);
            cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            cATEGORIAToolStripMenuItem.Click += cATEGORIAToolStripMenuItem_Click;
            // 
            // pAGAMENTOToolStripMenuItem
            // 
            pAGAMENTOToolStripMenuItem.Name = "pAGAMENTOToolStripMenuItem";
            pAGAMENTOToolStripMenuItem.Size = new Size(384, 62);
            pAGAMENTOToolStripMenuItem.Text = "PAGAMENTO";
            pAGAMENTOToolStripMenuItem.Click += pAGAMENTOToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 793);
            panel1.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(26F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 859);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Font = new Font("JetBrains Mono", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(10);
            Name = "Menu";
            Text = "SOFTWARE DE PADARIA";
            WindowState = FormWindowState.Maximized;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem cADASTROToolStripMenuItem;
        private ToolStripMenuItem fORNECEDORToolStripMenuItem;
        private ToolStripMenuItem eMPRESAToolStripMenuItem;
        private ToolStripMenuItem pRODUTOToolStripMenuItem;
        private ToolStripMenuItem pADARIAToolStripMenuItem;
        private ToolStripMenuItem pRODUTOToolStripMenuItem1;
        private ToolStripMenuItem rECEITAToolStripMenuItem;
        private ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private ToolStripMenuItem pAGAMENTOToolStripMenuItem;
        private Panel panel1;
    }
}