namespace FIT.WinForms.Ispit
{
    partial class frmNovaDržava
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
            cbAktivna = new CheckBox();
            pbZastava = new PictureBox();
            tbNaziv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(41, 600);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(153, 45);
            cbAktivna.TabIndex = 0;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(41, 86);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(698, 329);
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.Click += pbZastava_Click;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(41, 496);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(698, 47);
            tbNaziv.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 24);
            label1.Name = "label1";
            label1.Size = new Size(124, 41);
            label1.TabIndex = 3;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 440);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 4;
            label2.Text = "Naziv:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(472, 592);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(267, 58);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaDržava
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 728);
            Controls.Add(btnSacuvaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbNaziv);
            Controls.Add(pbZastava);
            Controls.Add(cbAktivna);
            Name = "frmNovaDržava";
            Text = "Podaci o drzavi";
            Load += frmNovaDržava_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbAktivna;
        private PictureBox pbZastava;
        private TextBox tbNaziv;
        private Label label1;
        private Label label2;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}