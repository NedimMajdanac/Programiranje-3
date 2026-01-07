namespace FIT.WinForms.Ispit
{
    partial class frmNovaProstorija
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
            components = new System.ComponentModel.Container();
            tbKapacitet = new TextBox();
            tbOznaka = new TextBox();
            tbNaziv = new TextBox();
            pbLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // tbKapacitet
            // 
            tbKapacitet.Location = new Point(1137, 302);
            tbKapacitet.Name = "tbKapacitet";
            tbKapacitet.Size = new Size(250, 47);
            tbKapacitet.TabIndex = 0;
            // 
            // tbOznaka
            // 
            tbOznaka.Location = new Point(778, 302);
            tbOznaka.Name = "tbOznaka";
            tbOznaka.Size = new Size(250, 47);
            tbOznaka.TabIndex = 1;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(778, 129);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(609, 47);
            tbNaziv.TabIndex = 2;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(40, 129);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(662, 358);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 65);
            label1.Name = "label1";
            label1.Size = new Size(93, 41);
            label1.TabIndex = 4;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1137, 234);
            label2.Name = "label2";
            label2.Size = new Size(147, 41);
            label2.TabIndex = 5;
            label2.Text = "Kapacitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(778, 234);
            label3.Name = "label3";
            label3.Size = new Size(124, 41);
            label3.TabIndex = 6;
            label3.Text = "Oznaka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(778, 65);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 7;
            label4.Text = "Naziv:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1137, 429);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(250, 58);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaProstorija
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 557);
            Controls.Add(btnSacuvaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            Controls.Add(tbNaziv);
            Controls.Add(tbOznaka);
            Controls.Add(tbKapacitet);
            Name = "frmNovaProstorija";
            Text = "frmNovaProstorija";
            Load += frmNovaProstorija_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbKapacitet;
        private TextBox tbOznaka;
        private TextBox tbNaziv;
        private PictureBox pbLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}