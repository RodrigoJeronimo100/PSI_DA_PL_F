namespace ProjetoDA
{
    partial class FormCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCinema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sala1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sala2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sala1ToolStripMenuItem,
            this.sala2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sala1ToolStripMenuItem
            // 
            this.sala1ToolStripMenuItem.Name = "sala1ToolStripMenuItem";
            this.sala1ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sala1ToolStripMenuItem.Text = "Sala 1";
            this.sala1ToolStripMenuItem.Click += new System.EventHandler(this.sala1ToolStripMenuItem_Click);
            // 
            // sala2ToolStripMenuItem
            // 
            this.sala2ToolStripMenuItem.Name = "sala2ToolStripMenuItem";
            this.sala2ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sala2ToolStripMenuItem.Text = "Sala 2";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCinema";
            this.Text = "Cinema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sala1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sala2ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
    }
}