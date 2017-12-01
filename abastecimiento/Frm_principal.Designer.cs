namespace abastecimiento
{
    partial class Frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_principal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDePersonalToolStripMenuItem,
            this.modificarPersonalToolStripMenuItem,
            this.bajaDePersonalToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // altaDePersonalToolStripMenuItem
            // 
            this.altaDePersonalToolStripMenuItem.Name = "altaDePersonalToolStripMenuItem";
            this.altaDePersonalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.altaDePersonalToolStripMenuItem.Text = "Alta de personal";
            // 
            // modificarPersonalToolStripMenuItem
            // 
            this.modificarPersonalToolStripMenuItem.Name = "modificarPersonalToolStripMenuItem";
            this.modificarPersonalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificarPersonalToolStripMenuItem.Text = "Modificar personal";
            // 
            // bajaDePersonalToolStripMenuItem
            // 
            this.bajaDePersonalToolStripMenuItem.Name = "bajaDePersonalToolStripMenuItem";
            this.bajaDePersonalToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bajaDePersonalToolStripMenuItem.Text = "Baja de personal";
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_principal";
            this.Text = "Sistema ESNM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDePersonalToolStripMenuItem;
    }
}