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
            this.listBoxAble.Location = new System.Drawing.Point(730, 68);
            this.listBoxAble.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAble.Name = "listBoxAble";
            this.listBoxAble.Size = new System.Drawing.Size(110, 420);
            this.listBoxAble.TabIndex = 0;
            // 
            // listBoxUnable
            // 
            this.listBoxUnable.FormattingEnabled = true;
            this.listBoxUnable.Location = new System.Drawing.Point(844, 68);
            this.listBoxUnable.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxUnable.Name = "listBoxUnable";
            this.listBoxUnable.Size = new System.Drawing.Size(110, 420);
            this.listBoxUnable.TabIndex = 1;
            this.listBoxUnable.SelectedIndexChanged += new System.EventHandler(this.listBoxUnable_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTitle.Location = new System.Drawing.Point(467, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(67, 26);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Form";
            // 
            // groupBoxSeats
            // 
            this.groupBoxSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSeats.Location = new System.Drawing.Point(16, 62);
            this.groupBoxSeats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Name = "groupBoxSeats";
            this.groupBoxSeats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSeats.Size = new System.Drawing.Size(710, 426);
            this.groupBoxSeats.TabIndex = 3;
            this.groupBoxSeats.TabStop = false;
            this.groupBoxSeats.Text = "Seats Avaliable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 497);
            this.Controls.Add(this.groupBoxSeats);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxUnable);
            this.Controls.Add(this.listBoxAble);
            this.Margin = new System.Windows.Forms.Padding(2);
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

