namespace FIT.WinForms.Ispit
{
    partial class frmNastava
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
            btnDodaj = new Button();
            cmbVrijeme = new ComboBox();
            cmbDan = new ComboBox();
            cmbPredmet = new ComboBox();
            dgvPodaci = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            lblNaziv = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1277, 285);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(318, 49);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14", "14 - 16" });
            cmbVrijeme.Location = new Point(932, 285);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(302, 49);
            cmbVrijeme.TabIndex = 1;
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Cetvrtak", "Petak", "Subota" });
            cmbDan.Location = new Point(579, 285);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(302, 49);
            cmbDan.TabIndex = 2;
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(16, 285);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(521, 49);
            cmbPredmet.TabIndex = 3;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvPodaci.Location = new Point(16, 368);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1579, 457);
            dgvPodaci.TabIndex = 4;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 12;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 12;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 12;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNaziv.Location = new Point(16, 62);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(229, 89);
            lblNaziv.TabIndex = 5;
            lblNaziv.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(932, 221);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 6;
            label2.Text = "Vrijeme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 221);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 7;
            label3.Text = "Dan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 221);
            label4.Name = "label4";
            label4.Size = new Size(138, 41);
            label4.TabIndex = 8;
            label4.Text = "Predmet:";
            // 
            // frmNastava
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 918);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNaziv);
            Controls.Add(dgvPodaci);
            Controls.Add(cmbPredmet);
            Controls.Add(cmbDan);
            Controls.Add(cmbVrijeme);
            Controls.Add(btnDodaj);
            Name = "frmNastava";
            Text = "frmNastava";
            Load += frmNastava_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private ComboBox cmbVrijeme;
        private ComboBox cmbDan;
        private ComboBox cmbPredmet;
        private DataGridView dgvPodaci;
        private Label lblNaziv;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}