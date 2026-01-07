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
            btnDodajStipendiju = new Button();
            btnStipendije = new Button();
            cmbStipendija = new ComboBox();
            cmbGodina = new ComboBox();
            dgvPodaci = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            btnUkloni = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // btnDodajStipendiju
            // 
            btnDodajStipendiju.Location = new Point(1653, 146);
            btnDodajStipendiju.Name = "btnDodajStipendiju";
            btnDodajStipendiju.Size = new Size(417, 58);
            btnDodajStipendiju.TabIndex = 0;
            btnDodajStipendiju.Text = "Dodaj stipendiju";
            btnDodajStipendiju.UseVisualStyleBackColor = true;
            btnDodajStipendiju.Click += btnDodajStipendiju_Click;
            // 
            // btnStipendije
            // 
            btnStipendije.Location = new Point(2129, 146);
            btnStipendije.Name = "btnStipendije";
            btnStipendije.Size = new Size(417, 58);
            btnStipendije.TabIndex = 1;
            btnStipendije.Text = "Stipendije po godinama";
            btnStipendije.UseVisualStyleBackColor = true;
            btnStipendije.Click += btnStipendije_Click;
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(497, 155);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(457, 49);
            cmbStipendija.TabIndex = 2;
            cmbStipendija.SelectedIndexChanged += cmbStipendija_SelectedIndexChanged;
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020" });
            cmbGodina.Location = new Point(12, 155);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(457, 49);
            cmbGodina.TabIndex = 3;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Student, Godina, Stipendija, Iznos, Ukupno, btnUkloni });
            dgvPodaci.Location = new Point(8, 270);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPodaci.Size = new Size(2538, 438);
            dgvPodaci.TabIndex = 4;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "(Indeks) Ime i Prezime";
            Student.MinimumWidth = 12;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "GodinaInfo";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 12;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "StipendijaInfo";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 12;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "IznosInfo";
            Iznos.HeaderText = "Mjesecni Iznos";
            Iznos.MinimumWidth = 12;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.MinimumWidth = 12;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // btnUkloni
            // 
            btnUkloni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnUkloni.DataPropertyName = "btnUkloni";
            btnUkloni.HeaderText = "";
            btnUkloni.MinimumWidth = 12;
            btnUkloni.Name = "btnUkloni";
            btnUkloni.ReadOnly = true;
            btnUkloni.Resizable = DataGridViewTriState.True;
            btnUkloni.SortMode = DataGridViewColumnSortMode.Automatic;
            btnUkloni.Text = "Ukloni";
            btnUkloni.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 92);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 5;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 92);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 6;
            label2.Text = "Stipendija:";
            // 
            // frmPretraga
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2558, 792);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbGodina);
            Controls.Add(cmbStipendija);
            Controls.Add(btnStipendije);
            Controls.Add(btnDodajStipendiju);
            Name = "frmPretraga";
            Text = "frmPretraga";
            Load += frmPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodajStipendiju;
        private Button btnStipendije;
        private ComboBox cmbStipendija;
        private ComboBox cmbGodina;
        private DataGridView dgvPodaci;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn btnUkloni;
    }
}