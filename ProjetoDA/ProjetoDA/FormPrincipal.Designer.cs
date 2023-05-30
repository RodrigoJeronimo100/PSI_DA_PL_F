namespace ProjetoDA
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.listBox_filmesdia = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxSeats = new System.Windows.Forms.GroupBox();
            this.button_login = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cinema = new System.Windows.Forms.Button();
            this.button_clientes = new System.Windows.Forms.Button();
            this.button_sessoes = new System.Windows.Forms.Button();
            this.button_filmes = new System.Windows.Forms.Button();
            this.button_func = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
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
            this.listBox_filmesdia.Size = new System.Drawing.Size(148, 378);
            this.listBox_filmesdia.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(404, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(137, 26);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Home Page";
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Controls.Add(this.button_sair);
            this.groupBoxSeats.Controls.Add(this.button_login);
            this.groupBoxSeats.Controls.Add(this.groupBox2);
            this.groupBoxSeats.Controls.Add(this.groupBox1);
            this.groupBoxSeats.Controls.Add(this.labelTitle);
            this.groupBoxSeats.Controls.Add(this.listBox_filmesdia);
            this.groupBoxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSeats.Location = new System.Drawing.Point(11, 3);
            this.groupBoxSeats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Size = new System.Drawing.Size(940, 510);
            this.groupBoxSeats.TabIndex = 3;
            this.groupBoxSeats.TabStop = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.BackgroundImage = global::ProjetoDA.Properties.Resources.login;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(896, 20);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(34, 27);
            this.button_login.TabIndex = 9;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(172, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 377);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_cinema);
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
            // button_cinema
            // 
            this.button_cinema.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cinema.Location = new System.Drawing.Point(414, 22);
            this.button_cinema.Name = "button_cinema";
            this.button_cinema.Size = new System.Drawing.Size(116, 27);
            this.button_cinema.TabIndex = 8;
            this.button_cinema.Text = "Cinema";
            this.button_cinema.UseVisualStyleBackColor = false;
            this.button_cinema.Click += new System.EventHandler(this.button_cinema_Click);
            // 
            // button_clientes
            // 
            this.button_clientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clientes.Location = new System.Drawing.Point(658, 22);
            this.button_clientes.Name = "button_clientes";
            this.button_clientes.Size = new System.Drawing.Size(116, 27);
            this.button_clientes.TabIndex = 7;
            this.button_clientes.Text = "Clientes";
            this.button_clientes.UseVisualStyleBackColor = false;
            this.button_clientes.Click += new System.EventHandler(this.button_clientes_Click);
            // 
            // button_sessoes
            // 
            this.button_sessoes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_sessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sessoes.Location = new System.Drawing.Point(536, 22);
            this.button_sessoes.Name = "button_sessoes";
            this.button_sessoes.Size = new System.Drawing.Size(116, 27);
            this.button_sessoes.TabIndex = 6;
            this.button_sessoes.Text = "Sessões";
            this.button_sessoes.UseVisualStyleBackColor = false;
            this.button_sessoes.Click += new System.EventHandler(this.button_sessoes_Click);
            // 
            // button_filmes
            // 
            this.button_filmes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_filmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filmes.Location = new System.Drawing.Point(292, 22);
            this.button_filmes.Name = "button_filmes";
            this.button_filmes.Size = new System.Drawing.Size(116, 27);
            this.button_filmes.TabIndex = 5;
            this.button_filmes.Text = "Filmes";
            this.button_filmes.UseVisualStyleBackColor = false;
            this.button_filmes.Click += new System.EventHandler(this.button_filmes_Click);
            // 
            // button_func
            // 
            this.button_func.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_func.Location = new System.Drawing.Point(170, 22);
            this.button_func.Name = "button_func";
            this.button_func.Size = new System.Drawing.Size(116, 27);
            this.button_func.TabIndex = 4;
            this.button_func.Text = "Funcionários";
            this.button_func.UseVisualStyleBackColor = false;
            this.button_func.Click += new System.EventHandler(this.button_func_Click);
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(19, 16);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(116, 25);
            this.button_sair.TabIndex = 10;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 519);
            this.Controls.Add(this.groupBoxSeats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSeats.ResumeLayout(false);
            this.groupBoxSeats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_filmesdia;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxSeats;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_clientes;
        private System.Windows.Forms.Button button_sessoes;
        private System.Windows.Forms.Button button_filmes;
        private System.Windows.Forms.Button button_func;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_cinema;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_sair;
    }
}

