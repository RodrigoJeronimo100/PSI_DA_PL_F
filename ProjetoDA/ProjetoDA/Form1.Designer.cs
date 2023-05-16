namespace ProjetoDA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_filmesdia = new System.Windows.Forms.ListBox();
            this.listBoxUnable = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxSeats = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_func = new System.Windows.Forms.Button();
            this.button_filmes = new System.Windows.Forms.Button();
            this.button_sessoes = new System.Windows.Forms.Button();
            this.button_clientes = new System.Windows.Forms.Button();
            this.groupBoxSeats.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_filmesdia
            // 
            this.listBox_filmesdia.FormattingEnabled = true;
            this.listBox_filmesdia.ItemHeight = 17;
            this.listBox_filmesdia.Location = new System.Drawing.Point(19, 118);
            this.listBox_filmesdia.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_filmesdia.Name = "listBox_filmesdia";
            this.listBox_filmesdia.Size = new System.Drawing.Size(148, 344);
            this.listBox_filmesdia.TabIndex = 0;
            // 
            // listBoxUnable
            // 
            this.listBoxUnable.FormattingEnabled = true;
            this.listBoxUnable.ItemHeight = 17;
            this.listBoxUnable.Location = new System.Drawing.Point(821, 214);
            this.listBoxUnable.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUnable.Name = "listBoxUnable";
            this.listBoxUnable.Size = new System.Drawing.Size(110, 259);
            this.listBoxUnable.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(419, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(67, 26);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Form";
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Controls.Add(this.groupBox1);
            this.groupBoxSeats.Controls.Add(this.labelTitle);
            this.groupBoxSeats.Controls.Add(this.listBoxUnable);
            this.groupBoxSeats.Controls.Add(this.listBox_filmesdia);
            this.groupBoxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSeats.Location = new System.Drawing.Point(11, 11);
            this.groupBoxSeats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Size = new System.Drawing.Size(940, 477);
            this.groupBoxSeats.TabIndex = 3;
            this.groupBoxSeats.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_clientes);
            this.groupBox1.Controls.Add(this.button_sessoes);
            this.groupBox1.Controls.Add(this.button_filmes);
            this.groupBox1.Controls.Add(this.button_func);
            this.groupBox1.Location = new System.Drawing.Point(19, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button_func
            // 
            this.button_func.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_func.Location = new System.Drawing.Point(239, 22);
            this.button_func.Name = "button_func";
            this.button_func.Size = new System.Drawing.Size(116, 27);
            this.button_func.TabIndex = 4;
            this.button_func.Text = "Funcionários";
            this.button_func.UseVisualStyleBackColor = false;
            // 
            // button_filmes
            // 
            this.button_filmes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_filmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filmes.Location = new System.Drawing.Point(361, 22);
            this.button_filmes.Name = "button_filmes";
            this.button_filmes.Size = new System.Drawing.Size(116, 27);
            this.button_filmes.TabIndex = 5;
            this.button_filmes.Text = "Filmes";
            this.button_filmes.UseVisualStyleBackColor = false;
            // 
            // button_sessoes
            // 
            this.button_sessoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sessoes.Location = new System.Drawing.Point(483, 22);
            this.button_sessoes.Name = "button_sessoes";
            this.button_sessoes.Size = new System.Drawing.Size(116, 27);
            this.button_sessoes.TabIndex = 6;
            this.button_sessoes.Text = "Sessões";
            this.button_sessoes.UseVisualStyleBackColor = false;
            // 
            // button_clientes
            // 
            this.button_clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clientes.Location = new System.Drawing.Point(605, 22);
            this.button_clientes.Name = "button_clientes";
            this.button_clientes.Size = new System.Drawing.Size(116, 27);
            this.button_clientes.TabIndex = 7;
            this.button_clientes.Text = "Clientes";
            this.button_clientes.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 497);
            this.Controls.Add(this.groupBoxSeats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSeats.ResumeLayout(false);
            this.groupBoxSeats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_filmesdia;
        private System.Windows.Forms.ListBox listBoxUnable;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxSeats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_clientes;
        private System.Windows.Forms.Button button_sessoes;
        private System.Windows.Forms.Button button_filmes;
        private System.Windows.Forms.Button button_func;
    }
}

