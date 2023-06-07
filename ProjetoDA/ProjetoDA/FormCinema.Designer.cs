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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdicionarAssentos = new System.Windows.Forms.Button();
            this.buttonAdicionarSalas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.textBoxLinha = new System.Windows.Forms.TextBox();
            this.textBoxColuna = new System.Windows.Forms.TextBox();
            this.textBoxSalas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1014, 521);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1006, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Cinema";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.buttonAdicionarAssentos);
            this.tabPage2.Controls.Add(this.buttonAdicionarSalas);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBoxSalas);
            this.tabPage2.Controls.Add(this.textBoxLinha);
            this.tabPage2.Controls.Add(this.textBoxColuna);
            this.tabPage2.Controls.Add(this.textBoxSalas);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salas de Cinema";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(322, 148);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 324);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // buttonAdicionarAssentos
            // 
            this.buttonAdicionarAssentos.Location = new System.Drawing.Point(162, 77);
            this.buttonAdicionarAssentos.Name = "buttonAdicionarAssentos";
            this.buttonAdicionarAssentos.Size = new System.Drawing.Size(75, 64);
            this.buttonAdicionarAssentos.TabIndex = 24;
            this.buttonAdicionarAssentos.Text = "button1";
            this.buttonAdicionarAssentos.UseVisualStyleBackColor = true;
            this.buttonAdicionarAssentos.Click += new System.EventHandler(this.buttonAdicionarAssentos_Click);
            // 
            // buttonAdicionarSalas
            // 
            this.buttonAdicionarSalas.Location = new System.Drawing.Point(162, 36);
            this.buttonAdicionarSalas.Name = "buttonAdicionarSalas";
            this.buttonAdicionarSalas.Size = new System.Drawing.Size(106, 20);
            this.buttonAdicionarSalas.TabIndex = 22;
            this.buttonAdicionarSalas.Text = "button1";
            this.buttonAdicionarSalas.UseVisualStyleBackColor = true;
            this.buttonAdicionarSalas.Click += new System.EventHandler(this.buttonAdicionarSalas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Salas Criadas";
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(20, 169);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(97, 21);
            this.comboBoxSalas.TabIndex = 20;
            // 
            // textBoxLinha
            // 
            this.textBoxLinha.Location = new System.Drawing.Point(20, 77);
            this.textBoxLinha.Name = "textBoxLinha";
            this.textBoxLinha.Size = new System.Drawing.Size(97, 20);
            this.textBoxLinha.TabIndex = 19;
            // 
            // textBoxColuna
            // 
            this.textBoxColuna.Location = new System.Drawing.Point(20, 121);
            this.textBoxColuna.Name = "textBoxColuna";
            this.textBoxColuna.Size = new System.Drawing.Size(97, 20);
            this.textBoxColuna.TabIndex = 18;
            // 
            // textBoxSalas
            // 
            this.textBoxSalas.Location = new System.Drawing.Point(20, 33);
            this.textBoxSalas.Name = "textBoxSalas";
            this.textBoxSalas.Size = new System.Drawing.Size(97, 20);
            this.textBoxSalas.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Indique quantas Salas quer adicionar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Linhas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Colunas";
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 545);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        
        
        private System.Windows.Forms.TextBox textBoxQuantidadeSalas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        
        
        private System.Windows.Forms.TextBox textBoxlinhas;
        private System.Windows.Forms.TextBox textBoxcolunas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.TextBox textBoxLinha;
        private System.Windows.Forms.TextBox textBoxColuna;
        private System.Windows.Forms.TextBox textBoxSalas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdicionarSalas;
        private System.Windows.Forms.Button buttonAdicionarAssentos;
        private System.Windows.Forms.TableLayoutPanel PanelSala5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}