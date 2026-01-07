namespace FIT.WinForms.Ispit
{
    partial class frmPrisustvo
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
            lblNaziv = new Label();
            lblPrisutni = new Label();
            cmbStudent = new ComboBox();
            cmbNastava = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnDodaj = new Button();
            dgvPodaci = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            tbInfo = new TextBox();
            tbBrojGenerisanja = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnGenerisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 20F);
            lblNaziv.Location = new Point(113, 63);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(214, 89);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "label1";
            // 
            // lblPrisutni
            // 
            lblPrisutni.AutoSize = true;
            lblPrisutni.Font = new Font("Segoe UI", 20F);
            lblPrisutni.Location = new Point(1435, 63);
            lblPrisutni.Name = "lblPrisutni";
            lblPrisutni.Size = new Size(214, 89);
            lblPrisutni.TabIndex = 1;
            lblPrisutni.Text = "label2";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(611, 268);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(560, 49);
            cmbStudent.TabIndex = 2;
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 268);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(560, 49);
            cmbNastava.TabIndex = 3;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(611, 215);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 4;
            label3.Text = "Student:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(129, 41);
            label4.TabIndex = 5;
            label4.Text = "Nastava:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1398, 268);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(322, 58);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPodaci.Location = new Point(12, 348);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1708, 311);
            dgvPodaci.TabIndex = 7;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet,Dan,Vrijeme";
            Nastava.MinimumWidth = 12;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 12;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(tbBrojGenerisanja);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(12, 705);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1708, 472);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(19, 240);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1683, 217);
            tbInfo.TabIndex = 4;
            // 
            // tbBrojGenerisanja
            // 
            tbBrojGenerisanja.Location = new Point(279, 80);
            tbBrojGenerisanja.Name = "tbBrojGenerisanja";
            tbBrojGenerisanja.Size = new Size(250, 47);
            tbBrojGenerisanja.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 80);
            label6.Name = "label6";
            label6.Size = new Size(236, 41);
            label6.TabIndex = 2;
            label6.Text = "Broj generisanja:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 179);
            label5.Name = "label5";
            label5.Size = new Size(76, 41);
            label5.TabIndex = 1;
            label5.Text = "info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(570, 80);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(343, 58);
            btnGenerisi.TabIndex = 0;
            btnGenerisi.Text = "Generisi >>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // frmPrisustvo
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1737, 1230);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbNastava);
            Controls.Add(cmbStudent);
            Controls.Add(lblPrisutni);
            Controls.Add(lblNaziv);
            Name = "frmPrisustvo";
            Text = "frmPrisustvo";
            Load += frmPrisustvo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private Label lblPrisutni;
        private ComboBox cmbStudent;
        private ComboBox cmbNastava;
        private Label label3;
        private Label label4;
        private Button btnDodaj;
        private DataGridView dgvPodaci;
        private GroupBox groupBox1;
        private TextBox tbInfo;
        private TextBox tbBrojGenerisanja;
        private Label label6;
        private Label label5;
        private Button btnGenerisi;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
    }
}