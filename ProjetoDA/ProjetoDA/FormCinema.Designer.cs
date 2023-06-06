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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxQuantidadeSalas = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxcolunas = new System.Windows.Forms.TextBox();
            this.textBoxlinhas = new System.Windows.Forms.TextBox();
            this.button_adicionarcolunas = new System.Windows.Forms.Button();
            this.button_adicionarlinhas = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remover Sala";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Criar Sala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 405);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Cinema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_adicionarlinhas);
            this.tabPage2.Controls.Add(this.button_adicionarcolunas);
            this.tabPage2.Controls.Add(this.textBoxlinhas);
            this.tabPage2.Controls.Add(this.textBoxcolunas);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.textBoxQuantidadeSalas);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salas de Cinema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxQuantidadeSalas
            // 
            this.textBoxQuantidadeSalas.Location = new System.Drawing.Point(26, 96);
            this.textBoxQuantidadeSalas.Multiline = true;
            this.textBoxQuantidadeSalas.Name = "textBoxQuantidadeSalas";
            this.textBoxQuantidadeSalas.Size = new System.Drawing.Size(139, 20);
            this.textBoxQuantidadeSalas.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remover Sala";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(299, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 367);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // textBoxcolunas
            // 
            this.textBoxcolunas.Location = new System.Drawing.Point(26, 148);
            this.textBoxcolunas.Multiline = true;
            this.textBoxcolunas.Name = "textBoxcolunas";
            this.textBoxcolunas.Size = new System.Drawing.Size(139, 20);
            this.textBoxcolunas.TabIndex = 6;
            // 
            // textBoxlinhas
            // 
            this.textBoxlinhas.Location = new System.Drawing.Point(26, 122);
            this.textBoxlinhas.Multiline = true;
            this.textBoxlinhas.Name = "textBoxlinhas";
            this.textBoxlinhas.Size = new System.Drawing.Size(139, 20);
            this.textBoxlinhas.TabIndex = 7;
            // 
            // button_adicionarcolunas
            // 
            this.button_adicionarcolunas.Location = new System.Drawing.Point(171, 146);
            this.button_adicionarcolunas.Name = "button_adicionarcolunas";
            this.button_adicionarcolunas.Size = new System.Drawing.Size(106, 23);
            this.button_adicionarcolunas.TabIndex = 8;
            this.button_adicionarcolunas.Text = "Adicionar Colunas";
            this.button_adicionarcolunas.UseVisualStyleBackColor = true;
            this.button_adicionarcolunas.Click += new System.EventHandler(this.button_adicionarcolunas_Click);
            // 
            // button_adicionarlinhas
            // 
            this.button_adicionarlinhas.Location = new System.Drawing.Point(171, 121);
            this.button_adicionarlinhas.Name = "button_adicionarlinhas";
            this.button_adicionarlinhas.Size = new System.Drawing.Size(106, 23);
            this.button_adicionarlinhas.TabIndex = 9;
            this.button_adicionarlinhas.Text = "Adicionar Linhas";
            this.button_adicionarlinhas.UseVisualStyleBackColor = true;
            this.button_adicionarlinhas.Click += new System.EventHandler(this.button_adicionarlinhas_Click);
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCinema";
            this.Text = "Cinema";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxQuantidadeSalas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_adicionarlinhas;
        private System.Windows.Forms.Button button_adicionarcolunas;
        private System.Windows.Forms.TextBox textBoxlinhas;
        private System.Windows.Forms.TextBox textBoxcolunas;
    }
}