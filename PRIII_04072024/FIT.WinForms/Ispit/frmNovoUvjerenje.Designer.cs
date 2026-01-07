namespace FIT.WinForms.Ispit
{
    partial class frmNovoUvjerenje
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
            btnSacuvaj = new Button();
            cmbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            pbUplatnica = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1301, 606);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(371, 58);
            btnSacuvaj.TabIndex = 0;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta" });
            cmbVrsta.Location = new Point(32, 95);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(638, 49);
            cmbVrsta.TabIndex = 1;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(32, 219);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(638, 445);
            tbSvrha.TabIndex = 2;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(749, 95);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(923, 448);
            pbUplatnica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUplatnica.TabIndex = 3;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 4;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 157);
            label2.Name = "label2";
            label2.Size = new Size(223, 41);
            label2.TabIndex = 5;
            label2.Text = "Svrha uvjerenja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(749, 40);
            label3.Name = "label3";
            label3.Size = new Size(149, 41);
            label3.TabIndex = 6;
            label3.Text = "Uplatnica:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovoUvjerenje
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1758, 712);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cmbVrsta);
            Controls.Add(btnSacuvaj);
            Name = "frmNovoUvjerenje";
            Text = "frmNovoUvjerenje";
            Load += frmNovoUvjerenje_Load;
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private ComboBox cmbVrsta;
        private TextBox tbSvrha;
        private PictureBox pbUplatnica;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}