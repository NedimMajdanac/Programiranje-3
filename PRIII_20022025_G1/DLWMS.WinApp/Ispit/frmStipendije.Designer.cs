namespace DLWMS.WinApp.Ispit
{
    partial class frmStipendije
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
            btnPotvrda = new Button();
            btnGenerisi = new Button();
            btnDodaj = new Button();
            cmbGodina = new ComboBox();
            cmbStipendija = new ComboBox();
            dgvPodaci = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            tbInfo = new TextBox();
            tbIznos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(1823, 652);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(188, 58);
            btnPotvrda.TabIndex = 0;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 652);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(491, 58);
            btnGenerisi.TabIndex = 1;
            btnGenerisi.Text = "Generisi >>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1823, 136);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(188, 58);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020" });
            cmbGodina.Location = new Point(12, 147);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(491, 49);
            cmbGodina.TabIndex = 4;
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(562, 147);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(491, 49);
            cmbStipendija.TabIndex = 5;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Ukupno, Aktivan });
            dgvPodaci.Location = new Point(12, 239);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPodaci.Size = new Size(1999, 375);
            dgvPodaci.TabIndex = 6;
            dgvPodaci.CellDoubleClick += dgvPodaci_CellDoubleClick;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 12;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 12;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesecni Iznos";
            Iznos.MinimumWidth = 12;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Ukupno
            // 
            Ukupno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupni iznos";
            Ukupno.MinimumWidth = 12;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivna";
            Aktivan.MinimumWidth = 12;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(12, 764);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(1999, 426);
            tbInfo.TabIndex = 7;
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(1092, 147);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(366, 47);
            tbIznos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 9;
            label1.Text = "Godina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(562, 80);
            label2.Name = "label2";
            label2.Size = new Size(155, 41);
            label2.TabIndex = 10;
            label2.Text = "Stipendija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1092, 80);
            label3.Name = "label3";
            label3.Size = new Size(301, 41);
            label3.TabIndex = 11;
            label3.Text = "Mjesecni iznos (BAM)";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStipendije
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2030, 1212);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbIznos);
            Controls.Add(tbInfo);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(btnDodaj);
            Controls.Add(btnGenerisi);
            Controls.Add(btnPotvrda);
            Name = "frmStipendije";
            Text = "frmStipendije";
            Load += frmStipendije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPotvrda;
        private Button btnGenerisi;
        private Button btnDodaj;
        private ComboBox cmbGodina;
        private ComboBox cmbStipendija;
        private DataGridView dgvPodaci;
        private TextBox tbInfo;
        private TextBox tbIznos;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewCheckBoxColumn Aktivan;
        private ErrorProvider err;
    }
}