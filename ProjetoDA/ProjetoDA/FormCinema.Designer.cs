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
<<<<<<< HEAD
            this.textBoxLinhas = new System.Windows.Forms.TextBox();
            this.buttonAdicionarAssentos = new System.Windows.Forms.Button();
            this.textBoxSalas = new System.Windows.Forms.TextBox();
            this.buttonAdicionarSalas = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxColunas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
=======
            this.textBoxQuantidadeSalas = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxcolunas = new System.Windows.Forms.TextBox();
            this.textBoxlinhas = new System.Windows.Forms.TextBox();
            this.button_adicionarcolunas = new System.Windows.Forms.Button();
            this.button_adicionarlinhas = new System.Windows.Forms.Button();
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
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
<<<<<<< HEAD
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxColunas);
            this.tabPage2.Controls.Add(this.textBoxLinhas);
            this.tabPage2.Controls.Add(this.buttonAdicionarAssentos);
            this.tabPage2.Controls.Add(this.textBoxSalas);
            this.tabPage2.Controls.Add(this.buttonAdicionarSalas);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
=======
            this.tabPage2.Controls.Add(this.button_adicionarlinhas);
            this.tabPage2.Controls.Add(this.button_adicionarcolunas);
            this.tabPage2.Controls.Add(this.textBoxlinhas);
            this.tabPage2.Controls.Add(this.textBoxcolunas);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.textBoxQuantidadeSalas);
            this.tabPage2.Controls.Add(this.button4);
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
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
<<<<<<< HEAD
            this.textBoxLinhas.Location = new System.Drawing.Point(62, 157);
            this.textBoxLinhas.Name = "textBoxLinhas";
            this.textBoxLinhas.Size = new System.Drawing.Size(116, 20);
            this.textBoxLinhas.TabIndex = 12;
=======
            this.textBoxQuantidadeSalas.Location = new System.Drawing.Point(26, 96);
            this.textBoxQuantidadeSalas.Multiline = true;
            this.textBoxQuantidadeSalas.Name = "textBoxQuantidadeSalas";
            this.textBoxQuantidadeSalas.Size = new System.Drawing.Size(139, 20);
            this.textBoxQuantidadeSalas.TabIndex = 4;
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
            // 
            // buttonAdicionarAssentos
            // 
<<<<<<< HEAD
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
=======
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
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
<<<<<<< HEAD
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
=======
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
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
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
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        private System.Windows.Forms.Button buttonAdicionarSalas;
        private System.Windows.Forms.TextBox textBoxSalas;
        private System.Windows.Forms.Button buttonAdicionarAssentos;
        private System.Windows.Forms.TextBox textBoxLinhas;
        private System.Windows.Forms.TextBox textBoxColunas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
=======
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxQuantidadeSalas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_adicionarlinhas;
        private System.Windows.Forms.Button button_adicionarcolunas;
        private System.Windows.Forms.TextBox textBoxlinhas;
        private System.Windows.Forms.TextBox textBoxcolunas;
>>>>>>> 46a04e18455a353ddbad8e422d2808d9cf1beae9
    }
}