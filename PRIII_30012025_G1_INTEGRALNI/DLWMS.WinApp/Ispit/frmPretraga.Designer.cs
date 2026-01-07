namespace DLWMS.WinApp.Ispit
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
            dgvPodaci = new DataGridView();
            tbSearch = new TextBox();
            cmbSpol = new ComboBox();
            cmbDrzava = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Student = new DataGridViewTextBoxColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjene = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Student, Drzava, Grad, Spol, Aktivan, btnRazmjene });
            dgvPodaci.Location = new Point(12, 207);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.Size = new Size(1980, 493);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(12, 134);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(519, 47);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(1119, 132);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(519, 49);
            cmbSpol.TabIndex = 2;
            cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
            // 
            // cmbDrzava
            // 
            cmbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzava.FormattingEnabled = true;
            cmbDrzava.Location = new Point(561, 132);
            cmbDrzava.Name = "cmbDrzava";
            cmbDrzava.Size = new Size(519, 49);
            cmbDrzava.TabIndex = 3;
            cmbDrzava.SelectedIndexChanged += cmbDrzava_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1119, 73);
            label1.Name = "label1";
            label1.Size = new Size(84, 41);
            label1.TabIndex = 4;
            label1.Text = "Spol:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 73);
            label2.Name = "label2";
            label2.Size = new Size(114, 41);
            label2.TabIndex = 5;
            label2.Text = "Drzava:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(219, 41);
            label3.TabIndex = 6;
            label3.Text = "Ime ili prezime:";
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "StudentInfo";
            Student.HeaderText = "(Indeks) Ime Prezime";
            Student.MinimumWidth = 12;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Drzava";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 12;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 12;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            // 
            // Spol
            // 
            Spol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 12;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 12;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // btnRazmjene
            // 
            btnRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnRazmjene.DataPropertyName = "btnRazmjene";
            btnRazmjene.HeaderText = "";
            btnRazmjene.MinimumWidth = 12;
            btnRazmjene.Name = "btnRazmjene";
            btnRazmjene.ReadOnly = true;
            btnRazmjene.Text = "Razmjene";
            btnRazmjene.UseColumnTextForButtonValue = true;
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2004, 808);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDrzava);
            Controls.Add(cmbSpol);
            Controls.Add(tbSearch);
            Controls.Add(dgvPodaci);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPodaci;
        private TextBox tbSearch;
        private ComboBox cmbSpol;
        private ComboBox cmbDrzava;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjene;
    }
}