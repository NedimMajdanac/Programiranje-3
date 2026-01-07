namespace FIT.WinForms.Ispit
{
    partial class frmDrzave
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
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            Broj = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            btnPrintaj = new Button();
            btnNovaDrzava = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, Broj, Aktivna, btnGradovi });
            dgvPodaci.Location = new Point(12, 172);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(1962, 450);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 12;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Resizable = DataGridViewTriState.True;
            Zastava.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Naziv";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 12;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            // 
            // Broj
            // 
            Broj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Broj.DataPropertyName = "Broj";
            Broj.HeaderText = "Broj gradova";
            Broj.MinimumWidth = 12;
            Broj.Name = "Broj";
            Broj.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Status";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 12;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // btnGradovi
            // 
            btnGradovi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnGradovi.DataPropertyName = "btnGradovi";
            btnGradovi.HeaderText = "";
            btnGradovi.MinimumWidth = 12;
            btnGradovi.Name = "btnGradovi";
            btnGradovi.ReadOnly = true;
            btnGradovi.Text = "Gradovi";
            btnGradovi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1786, 666);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(188, 58);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(1661, 77);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(313, 58);
            btnNovaDrzava.TabIndex = 2;
            btnNovaDrzava.Text = "Nova Drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // frmDrzave
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1990, 791);
            Controls.Add(btnNovaDrzava);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvPodaci);
            Name = "frmDrzave";
            Text = "frmDrzave";
            Load += frmDrzave_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPodaci;
        private Button btnPrintaj;
        private Button btnNovaDrzava;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn Broj;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn btnGradovi;
    }
}