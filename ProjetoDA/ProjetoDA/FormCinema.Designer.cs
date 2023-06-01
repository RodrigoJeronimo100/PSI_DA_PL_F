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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_novasala = new System.Windows.Forms.TextBox();
            this.button_criarsala = new System.Windows.Forms.Button();
            this.button_removersala = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sala 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sala 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_novasala
            // 
            this.textBox_novasala.Location = new System.Drawing.Point(11, 8);
            this.textBox_novasala.Multiline = true;
            this.textBox_novasala.Name = "textBox_novasala";
            this.textBox_novasala.Size = new System.Drawing.Size(123, 25);
            this.textBox_novasala.TabIndex = 1;
            // 
            // button_criarsala
            // 
            this.button_criarsala.Location = new System.Drawing.Point(140, 10);
            this.button_criarsala.Name = "button_criarsala";
            this.button_criarsala.Size = new System.Drawing.Size(75, 23);
            this.button_criarsala.TabIndex = 2;
            this.button_criarsala.Text = "Criar Sala";
            this.button_criarsala.UseVisualStyleBackColor = true;
            this.button_criarsala.Click += new System.EventHandler(this.button_criarsala_Click);
            // 
            // button_removersala
            // 
            this.button_removersala.Location = new System.Drawing.Point(221, 10);
            this.button_removersala.Name = "button_removersala";
            this.button_removersala.Size = new System.Drawing.Size(89, 23);
            this.button_removersala.TabIndex = 3;
            this.button_removersala.Text = "Remover Sala";
            this.button_removersala.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(11, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_removersala);
            this.Controls.Add(this.button_criarsala);
            this.Controls.Add(this.textBox_novasala);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCinema";
            this.Text = "Cinema";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_novasala;
        private System.Windows.Forms.Button button_criarsala;
        private System.Windows.Forms.Button button_removersala;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}