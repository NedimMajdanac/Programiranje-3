namespace FIT.WinForms.Ispit
{
    partial class frmPretraga
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
            cmbSpol = new ComboBox();
            dgvPodaci = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnUvjerenja = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Items.AddRange(new object[] { "Muski", "Zenski", "Svi" });
            cmbSpol.Location = new Point(145, 53);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(302, 49);
            cmbSpol.TabIndex = 0;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, Student, Prosjek, DatumRodjenja, Aktivan, btnUvjerenja });
            dgvPodaci.Location = new Point(12, 177);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1647, 466);
            dgvPodaci.TabIndex = 1;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojIndeksa.DataPropertyName = "Indeks";
            BrojIndeksa.HeaderText = "Broj Indeksa";
            BrojIndeksa.MinimumWidth = 12;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "studentinfo";
            Student.HeaderText = "Ime Prezime";
            Student.MinimumWidth = 12;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 12;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            Prosjek.Width = 168;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum Rodjenja";
            DatumRodjenja.MinimumWidth = 12;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 12;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnUvjerenja
            // 
            btnUvjerenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnUvjerenja.DataPropertyName = "btnUvjerenja";
            btnUvjerenja.HeaderText = "";
            btnUvjerenja.MinimumWidth = 12;
            btnUvjerenja.Name = "btnUvjerenja";
            btnUvjerenja.ReadOnly = true;
            btnUvjerenja.Text = "Uvjerenja";
            btnUvjerenja.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1208, 60);
            label1.Name = "label1";
            label1.Size = new Size(61, 41);
            label1.TabIndex = 2;
            label1.Text = "do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 55);
            label2.Name = "label2";
            label2.Size = new Size(299, 41);
            label2.TabIndex = 3;
            label2.Text = "Rodjen u periodu od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 56);
            label3.Name = "label3";
            label3.Size = new Size(84, 41);
            label3.TabIndex = 4;
            label3.Text = "Spol:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(823, 55);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(352, 47);
            dtpFrom.TabIndex = 5;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(1311, 55);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(348, 47);
            dtpTo.TabIndex = 6;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1671, 726);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbSpol);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSpol;
        private DataGridView dgvPodaci;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnUvjerenja;
    }
}