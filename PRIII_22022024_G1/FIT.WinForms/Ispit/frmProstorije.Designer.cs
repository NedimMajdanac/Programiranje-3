
namespace FIT.WinForms.Ispit
{
    partial class frmProstorije
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
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrojPredmeta = new DataGridViewTextBoxColumn();
            btnNastava = new DataGridViewButtonColumn();
            btnPrisustvo = new DataGridViewButtonColumn();
            btnNovaProstorija = new Button();
            btnPrintaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            SuspendLayout();
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Logo, Naziv, Oznaka, Kapacitet, BrojPredmeta, btnNastava, btnPrisustvo });
            dgvPodaci.Location = new Point(12, 201);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(2157, 375);
            dgvPodaci.TabIndex = 0;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            dgvPodaci.CellContentDoubleClick += dgvPodaci_CellContentDoubleClick;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Logo.MinimumWidth = 12;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
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
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 12;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 12;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            // 
            // BrojPredmeta
            // 
            BrojPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojPredmeta.DataPropertyName = "BrojPredmeta";
            BrojPredmeta.HeaderText = "Br. Predmeta";
            BrojPredmeta.MinimumWidth = 12;
            BrojPredmeta.Name = "BrojPredmeta";
            BrojPredmeta.ReadOnly = true;
            // 
            // btnNastava
            // 
            btnNastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnNastava.DataPropertyName = "btnNastava";
            btnNastava.HeaderText = "";
            btnNastava.MinimumWidth = 12;
            btnNastava.Name = "btnNastava";
            btnNastava.ReadOnly = true;
            btnNastava.Resizable = DataGridViewTriState.True;
            btnNastava.SortMode = DataGridViewColumnSortMode.Automatic;
            btnNastava.Text = "Nastava";
            btnNastava.UseColumnTextForButtonValue = true;
            // 
            // btnPrisustvo
            // 
            btnPrisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPrisustvo.DataPropertyName = "btnPrisustvo";
            btnPrisustvo.HeaderText = "";
            btnPrisustvo.MinimumWidth = 12;
            btnPrisustvo.Name = "btnPrisustvo";
            btnPrisustvo.ReadOnly = true;
            btnPrisustvo.Text = "Prisustvo";
            btnPrisustvo.UseColumnTextForButtonValue = true;
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.Location = new Point(1825, 114);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(344, 58);
            btnNovaProstorija.TabIndex = 1;
            btnNovaProstorija.Text = "Nova Prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = true;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(1825, 604);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(344, 58);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // frmProstorije
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2181, 721);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaProstorija);
            Controls.Add(dgvPodaci);
            Name = "frmProstorije";
            Text = "frmPretraga";
            Load += frmProstorije_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private DataGridView dgvPodaci;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrojPredmeta;
        private DataGridViewButtonColumn btnNastava;
        private DataGridViewButtonColumn btnPrisustvo;
        private Button btnNovaProstorija;
        private Button btnPrintaj;
    }
}