namespace DLWMS.WinApp.Ispit
{
    partial class frmStudentEdit
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
            btnSacuvaj = new Button();
            btnLoadSlika = new Button();
            cmbDrzava = new ComboBox();
            cmbGrad = new ComboBox();
            txtIme = new Label();
            txtIndeks = new Label();
            label3 = new Label();
            label4 = new Label();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1176, 588);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(289, 58);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnLoadSlika
            // 
            btnLoadSlika.Location = new Point(64, 588);
            btnLoadSlika.Name = "btnLoadSlika";
            btnLoadSlika.Size = new Size(629, 58);
            btnLoadSlika.TabIndex = 1;
            btnLoadSlika.Text = "Ucitaj sliku";
            btnLoadSlika.UseVisualStyleBackColor = true;
            btnLoadSlika.Click += btnLoadSlika_Click;
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(916, 375);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(549, 49);
            cmbDrzava.TabIndex = 2;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(916, 472);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(549, 49);
            cmbGrad.TabIndex = 3;
            // 
            // txtIme
            // 
            txtIme.AutoSize = true;
            txtIme.Font = new Font("Segoe UI", 20F);
            txtIme.Location = new Point(723, 84);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(214, 89);
            txtIme.TabIndex = 4;
            txtIme.Text = "label1";
            // 
            // txtIndeks
            // 
            txtIndeks.AutoSize = true;
            txtIndeks.Font = new Font("Segoe UI", 20F);
            txtIndeks.Location = new Point(723, 200);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(214, 89);
            txtIndeks.TabIndex = 5;
            txtIndeks.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(723, 472);
            label3.Name = "label3";
            label3.Size = new Size(89, 41);
            label3.TabIndex = 6;
            label3.Text = "Grad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(723, 378);
            label4.Name = "label4";
            label4.Size = new Size(114, 41);
            label4.TabIndex = 7;
            label4.Text = "Drzava:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(64, 31);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(629, 490);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 8;
            pbSlika.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmStudentEdit
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1689, 765);
            Controls.Add(pbSlika);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtIndeks);
            Controls.Add(txtIme);
            Controls.Add(cmbGrad);
            Controls.Add(cmbDrzava);
            Controls.Add(btnLoadSlika);
            Controls.Add(btnSacuvaj);
            Name = "frmStudentEdit";
            Text = "frmStudentEdit";
            Load += frmStudentEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private Button btnLoadSlika;
        private ComboBox cmbDrzava;
        private ComboBox cmbGrad;
        private Label txtIme;
        private Label txtIndeks;
        private Label label3;
        private Label label4;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
    }
}