namespace FIT.WinForms.Ispit
{
    partial class frmGradovi
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
            pbZastava = new PictureBox();
            lblDrzava = new Label();
            dgvPodaci = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnPromijeniStatus = new DataGridViewButtonColumn();
            btnDodaj = new Button();
            btnGenerisi = new Button();
            tbNaziv = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cbAktivna = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            tbInfo = new TextBox();
            tbBrojGenerisanja = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(36, 26);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(533, 308);
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDrzava.Location = new Point(713, 153);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(171, 67);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, btnPromijeniStatus });
            dgvPodaci.Location = new Point(36, 475);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1371, 375);
            dgvPodaci.TabIndex = 2;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 12;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 12;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.True;
            Status.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnPromijeniStatus
            // 
            btnPromijeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPromijeniStatus.DataPropertyName = "btnPromijeniStatus";
            btnPromijeniStatus.HeaderText = "";
            btnPromijeniStatus.MinimumWidth = 12;
            btnPromijeniStatus.Name = "btnPromijeniStatus";
            btnPromijeniStatus.ReadOnly = true;
            btnPromijeniStatus.Text = "Promijeni Status";
            btnPromijeniStatus.UseColumnTextForButtonValue = true;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1132, 379);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(275, 58);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(765, 62);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(188, 58);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(428, 390);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(682, 47);
            tbNaziv.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 388);
            label2.Name = "label2";
            label2.Size = new Size(377, 41);
            label2.TabIndex = 6;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAktivna);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbBrojGenerisanja);
            groupBox1.Location = new Point(24, 886);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1393, 511);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // cbAktivna
            // 
            cbAktivna.AutoSize = true;
            cbAktivna.Location = new Point(489, 70);
            cbAktivna.Name = "cbAktivna";
            cbAktivna.Size = new Size(153, 45);
            cbAktivna.TabIndex = 4;
            cbAktivna.Text = "Aktivna";
            cbAktivna.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 200);
            label3.Name = "label3";
            label3.Size = new Size(77, 41);
            label3.TabIndex = 3;
            label3.Text = "Info:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 76);
            label1.Name = "label1";
            label1.Size = new Size(193, 41);
            label1.TabIndex = 2;
            label1.Text = "Broj gradova:";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(19, 255);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1364, 250);
            tbInfo.TabIndex = 1;
            // 
            // tbBrojGenerisanja
            // 
            tbBrojGenerisanja.Location = new Point(219, 70);
            tbBrojGenerisanja.Name = "tbBrojGenerisanja";
            tbBrojGenerisanja.Size = new Size(158, 47);
            tbBrojGenerisanja.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 1409);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(tbNaziv);
            Controls.Add(btnDodaj);
            Controls.Add(dgvPodaci);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradovi";
            Text = "frmGradovi";
            Load += frmGradovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private DataGridView dgvPodaci;
        private Button btnDodaj;
        private Button btnGenerisi;
        private TextBox tbNaziv;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox cbAktivna;
        private Label label3;
        private Label label1;
        private TextBox tbInfo;
        private TextBox tbBrojGenerisanja;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnPromijeniStatus;
        private ErrorProvider errorProvider1;
    }
}