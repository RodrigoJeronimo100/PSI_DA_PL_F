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
            this.listBoxAble = new System.Windows.Forms.ListBox();
            this.listBoxUnable = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxSeats = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // listBoxAble
            // 
            this.listBoxAble.FormattingEnabled = true;
            this.listBoxAble.ItemHeight = 16;
            this.listBoxAble.Location = new System.Drawing.Point(973, 84);
            this.listBoxAble.Name = "listBoxAble";
            this.listBoxAble.Size = new System.Drawing.Size(146, 516);
            this.listBoxAble.TabIndex = 0;
            
            // 
            // listBoxUnable
            // 
            this.listBoxUnable.FormattingEnabled = true;
            this.listBoxUnable.ItemHeight = 16;
            this.listBoxUnable.Location = new System.Drawing.Point(1125, 84);
            this.listBoxUnable.Name = "listBoxUnable";
            this.listBoxUnable.Size = new System.Drawing.Size(146, 516);
            this.listBoxUnable.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(623, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 32);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Form";
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSeats.Location = new System.Drawing.Point(21, 76);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Size = new System.Drawing.Size(946, 524);
            this.groupBoxSeats.TabIndex = 3;
            this.groupBoxSeats.TabStop = false;
            this.groupBoxSeats.Text = "Seats Avaliable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 612);
            this.Controls.Add(this.groupBoxSeats);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxUnable);
            this.Controls.Add(this.listBoxAble);
            this.Name = "Form1";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAble;
        private System.Windows.Forms.ListBox listBoxUnable;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxSeats;
    }
}

