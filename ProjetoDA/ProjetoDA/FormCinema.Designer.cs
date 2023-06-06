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
            this.textBoxLinhas = new System.Windows.Forms.TextBox();
            this.buttonAdicionarAssentos = new System.Windows.Forms.Button();
            this.textBoxSalas = new System.Windows.Forms.TextBox();
            this.buttonAdicionarSalas = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxColunas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxColunas);
            this.tabPage2.Controls.Add(this.textBoxLinhas);
            this.tabPage2.Controls.Add(this.buttonAdicionarAssentos);
            this.tabPage2.Controls.Add(this.textBoxSalas);
            this.tabPage2.Controls.Add(this.buttonAdicionarSalas);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salas de Cinema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxLinhas
            // 
            this.textBoxLinhas.Location = new System.Drawing.Point(62, 157);
            this.textBoxLinhas.Name = "textBoxLinhas";
            this.textBoxLinhas.Size = new System.Drawing.Size(116, 20);
            this.textBoxLinhas.TabIndex = 12;
            // 
            // buttonAdicionarAssentos
            // 
            this.buttonAdicionarAssentos.Location = new System.Drawing.Point(186, 144);
            this.buttonAdicionarAssentos.Name = "buttonAdicionarAssentos";
            this.buttonAdicionarAssentos.Size = new System.Drawing.Size(110, 66);
            this.buttonAdicionarAssentos.TabIndex = 11;
            this.buttonAdicionarAssentos.Text = "Adicionar Assentos";
            this.buttonAdicionarAssentos.UseVisualStyleBackColor = true;
            this.buttonAdicionarAssentos.Click += new System.EventHandler(this.buttonAdicionarAssentos_Click);
            // 
            // textBoxSalas
            // 
            this.textBoxSalas.Location = new System.Drawing.Point(62, 112);
            this.textBoxSalas.Name = "textBoxSalas";
            this.textBoxSalas.Size = new System.Drawing.Size(118, 20);
            this.textBoxSalas.TabIndex = 10;
            // 
            // buttonAdicionarSalas
            // 
            this.buttonAdicionarSalas.Location = new System.Drawing.Point(186, 112);
            this.buttonAdicionarSalas.Name = "buttonAdicionarSalas";
            this.buttonAdicionarSalas.Size = new System.Drawing.Size(110, 26);
            this.buttonAdicionarSalas.TabIndex = 9;
            this.buttonAdicionarSalas.Text = "Adicionar Salas";
            this.buttonAdicionarSalas.UseVisualStyleBackColor = true;
            this.buttonAdicionarSalas.Click += new System.EventHandler(this.buttonAdicionarSalas_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(319, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(441, 367);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxColunas
            // 
            this.textBoxColunas.Location = new System.Drawing.Point(62, 196);
            this.textBoxColunas.Name = "textBoxColunas";
            this.textBoxColunas.Size = new System.Drawing.Size(118, 20);
            this.textBoxColunas.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Colunas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Linhas";
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private System.Windows.Forms.Button buttonAdicionarSalas;
        private System.Windows.Forms.TextBox textBoxSalas;
        private System.Windows.Forms.Button buttonAdicionarAssentos;
        private System.Windows.Forms.TextBox textBoxLinhas;
        private System.Windows.Forms.TextBox textBoxColunas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}