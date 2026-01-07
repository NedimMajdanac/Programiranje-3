namespace FIT.WinForms.Ispit
{
    partial class frmStudentInfo
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
            lblIme = new Label();
            lblProsjek = new Label();
            pbSlika = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Location = new Point(346, 567);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(97, 41);
            lblIme.TabIndex = 0;
            lblIme.Text = "label1";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Location = new Point(346, 667);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(97, 41);
            lblProsjek.TabIndex = 1;
            lblProsjek.Text = "label2";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(31, 95);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(725, 407);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 2;
            pbSlika.TabStop = false;
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 763);
            Controls.Add(pbSlika);
            Controls.Add(lblProsjek);
            Controls.Add(lblIme);
            Name = "frmStudentInfo";
            Text = "frmStudentInfo";
            Load += frmStudentInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIme;
        private Label lblProsjek;
        private PictureBox pbSlika;
    }
}