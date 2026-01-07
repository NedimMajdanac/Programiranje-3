namespace DLWMS.WinApp.Ispit
{
    partial class frmRazmjene
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
            cmbDrzava = new ComboBox();
            cmbUniverzitet = new ComboBox();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            btnSacuvaj = new Button();
            tbECTS = new TextBox();
            dgvPodaci = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            Pocetak = new DataGridViewTextBoxColumn();
            Kraj = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            cmbUni = new ComboBox();
            tbInfo = new TextBox();
            tbBrojBodova = new TextBox();
            tbBrojRazmjene = new TextBox();
            btnGenerisi = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDrzava
            // 
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(16, 102);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(384, 49);
            cmbDrzava.TabIndex = 0;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // cmbUniverzitet
            // 
            cmbUniverzitet.FormattingEnabled = true;
            cmbUniverzitet.Location = new Point(421, 107);
            cmbUniverzitet.Name = "cmbUniverzitet";
            cmbUniverzitet.Size = new Size(369, 49);
            cmbUniverzitet.TabIndex = 1;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(1393, 105);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(378, 47);
            dtpEnd.TabIndex = 2;
            dtpEnd.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(1009, 107);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(378, 47);
            dtpStart.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1796, 96);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(188, 58);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // tbECTS
            // 
            tbECTS.Location = new Point(818, 107);
            tbECTS.Name = "tbECTS";
            tbECTS.Size = new Size(171, 47);
            tbECTS.TabIndex = 5;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, Pocetak, Kraj, ECTS, Okoncana, btnObrisi });
            dgvPodaci.Location = new Point(16, 188);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.Size = new Size(1968, 375);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 12;
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
            // 
            // Pocetak
            // 
            Pocetak.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pocetak.DataPropertyName = "Pocetak";
            Pocetak.HeaderText = "Pocetak";
            Pocetak.MinimumWidth = 12;
            Pocetak.Name = "Pocetak";
            Pocetak.ReadOnly = true;
            // 
            // Kraj
            // 
            Kraj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kraj.DataPropertyName = "Kraj";
            Kraj.HeaderText = "Kraj";
            Kraj.MinimumWidth = 12;
            Kraj.Name = "Kraj";
            Kraj.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 12;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            // 
            // Okoncana
            // 
            Okoncana.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okoncana";
            Okoncana.MinimumWidth = 12;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            // 
            // btnObrisi
            // 
            btnObrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnObrisi.DataPropertyName = "btnObrisi";
            btnObrisi.HeaderText = "";
            btnObrisi.MinimumWidth = 12;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.ReadOnly = true;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 7;
            label1.Text = "Drzava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1393, 38);
            label2.Name = "label2";
            label2.Size = new Size(74, 41);
            label2.TabIndex = 8;
            label2.Text = "Kraj:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1009, 38);
            label3.Name = "label3";
            label3.Size = new Size(129, 41);
            label3.TabIndex = 9;
            label3.Text = "Pocetak:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 38);
            label4.Name = "label4";
            label4.Size = new Size(90, 41);
            label4.TabIndex = 10;
            label4.Text = "ECTS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 38);
            label5.Name = "label5";
            label5.Size = new Size(167, 41);
            label5.TabIndex = 11;
            label5.Text = "Univerzitet:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbBrojRazmjene);
            groupBox1.Controls.Add(tbBrojBodova);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(cmbUni);
            groupBox1.Location = new Point(16, 602);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1968, 486);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator razmjena";
            // 
            // cmbUni
            // 
            cmbUni.FormattingEnabled = true;
            cmbUni.Location = new Point(11, 125);
            cmbUni.Name = "cmbUni";
            cmbUni.Size = new Size(479, 49);
            cmbUni.TabIndex = 0;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(556, 125);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1406, 325);
            tbInfo.TabIndex = 1;
            // 
            // tbBrojBodova
            // 
            tbBrojBodova.Location = new Point(276, 265);
            tbBrojBodova.Name = "tbBrojBodova";
            tbBrojBodova.Size = new Size(214, 47);
            tbBrojBodova.TabIndex = 2;
            // 
            // tbBrojRazmjene
            // 
            tbBrojRazmjene.Location = new Point(11, 265);
            tbBrojRazmjene.Name = "tbBrojRazmjene";
            tbBrojRazmjene.Size = new Size(214, 47);
            tbBrojRazmjene.TabIndex = 3;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(11, 392);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(479, 58);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generisi >>>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 70);
            label6.Name = "label6";
            label6.Size = new Size(167, 41);
            label6.TabIndex = 5;
            label6.Text = "Univerzitet:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(556, 70);
            label7.Name = "label7";
            label7.Size = new Size(77, 41);
            label7.TabIndex = 6;
            label7.Text = "Info:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 194);
            label8.Name = "label8";
            label8.Size = new Size(186, 41);
            label8.TabIndex = 7;
            label8.Text = "Broj bodova:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 194);
            label9.Name = "label9";
            label9.Size = new Size(205, 41);
            label9.TabIndex = 8;
            label9.Text = "Broj razmjena:";
            // 
            // frmRazmjene
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1996, 1117);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(tbECTS);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpStart);
            Controls.Add(dtpEnd);
            Controls.Add(cmbUniverzitet);
            Controls.Add(cmbDrzava);
            Name = "frmRazmjene";
            Text = "frmRazmjene";
            Load += frmRazmjene_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDrzava;
        private ComboBox cmbUniverzitet;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private Button btnSacuvaj;
        private TextBox tbECTS;
        private DataGridView dgvPodaci;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn Pocetak;
        private DataGridViewTextBoxColumn Kraj;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
        private ErrorProvider errorProvider1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnGenerisi;
        private TextBox tbBrojRazmjene;
        private TextBox tbBrojBodova;
        private TextBox tbInfo;
        private ComboBox cmbUni;
    }
}