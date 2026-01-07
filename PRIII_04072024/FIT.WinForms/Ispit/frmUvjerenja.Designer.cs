namespace FIT.WinForms.Ispit
{
    partial class frmUvjerenja
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
            btnNoviZahtjev = new Button();
            dgvPodaci = new DataGridView();
            Vrijeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            btnBrisi = new DataGridViewButtonColumn();
            btnPrintaj = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbVrsta = new ComboBox();
            btnGenerisi = new Button();
            tbSvrha = new TextBox();
            tbBrojGenerisanja = new TextBox();
            tbInfo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnNoviZahtjev
            // 
            btnNoviZahtjev.Location = new Point(1780, 76);
            btnNoviZahtjev.Name = "btnNoviZahtjev";
            btnNoviZahtjev.Size = new Size(304, 58);
            btnNoviZahtjev.TabIndex = 0;
            btnNoviZahtjev.Text = "Novi Zahtjev";
            btnNoviZahtjev.UseVisualStyleBackColor = true;
            btnNoviZahtjev.Click += btnNoviZahtjev_Click;
            // 
            // dgvPodaci
            // 
            dgvPodaci.AllowUserToAddRows = false;
            dgvPodaci.AllowUserToDeleteRows = false;
            dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPodaci.Columns.AddRange(new DataGridViewColumn[] { Vrijeme, Vrsta, Svrha, Uplatnica, Printano, btnBrisi, btnPrintaj });
            dgvPodaci.Location = new Point(12, 150);
            dgvPodaci.Name = "dgvPodaci";
            dgvPodaci.ReadOnly = true;
            dgvPodaci.RowHeadersWidth = 102;
            dgvPodaci.RowTemplate.Height = 49;
            dgvPodaci.Size = new Size(2072, 375);
            dgvPodaci.TabIndex = 1;
            dgvPodaci.CellContentClick += dgvPodaci_CellContentClick;
            // 
            // Vrijeme
            // 
            Vrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme kreiranja";
            Vrijeme.MinimumWidth = 12;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // Vrsta
            // 
            Vrsta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 12;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            // 
            // Svrha
            // 
            Svrha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 12;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.MinimumWidth = 12;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 12;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // btnBrisi
            // 
            btnBrisi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnBrisi.DataPropertyName = "btnBrisi";
            btnBrisi.HeaderText = "";
            btnBrisi.MinimumWidth = 12;
            btnBrisi.Name = "btnBrisi";
            btnBrisi.ReadOnly = true;
            btnBrisi.Text = "Brisi";
            btnBrisi.UseColumnTextForButtonValue = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btnPrintaj.DataPropertyName = "btnPrintaj";
            btnPrintaj.HeaderText = "";
            btnPrintaj.MinimumWidth = 12;
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.ReadOnly = true;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbVrsta);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbSvrha);
            groupBox1.Controls.Add(tbBrojGenerisanja);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Location = new Point(12, 578);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2072, 663);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje zahtjeva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 231);
            label4.Name = "label4";
            label4.Size = new Size(77, 41);
            label4.TabIndex = 8;
            label4.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 74);
            label3.Name = "label3";
            label3.Size = new Size(96, 41);
            label3.TabIndex = 7;
            label3.Text = "Svrha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 6;
            label2.Text = "Vrsta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1351, 74);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 5;
            label1.Text = "Broj generisanja:";
            // 
            // cmbVrsta
            // 
            cmbVrsta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrsta.FormattingEnabled = true;
            cmbVrsta.Items.AddRange(new object[] { "Uvjerenje o položenim ispitima", "Uvjerenje o statusu studenta" });
            cmbVrsta.Location = new Point(6, 136);
            cmbVrsta.Name = "cmbVrsta";
            cmbVrsta.Size = new Size(627, 49);
            cmbVrsta.TabIndex = 4;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(1653, 127);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(413, 58);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(679, 138);
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(627, 47);
            tbSvrha.TabIndex = 2;
            // 
            // tbBrojGenerisanja
            // 
            tbBrojGenerisanja.Location = new Point(1351, 138);
            tbBrojGenerisanja.Name = "tbBrojGenerisanja";
            tbBrojGenerisanja.Size = new Size(250, 47);
            tbBrojGenerisanja.TabIndex = 1;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 290);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(2060, 355);
            tbInfo.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmUvjerenja
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2096, 1271);
            Controls.Add(groupBox1);
            Controls.Add(dgvPodaci);
            Controls.Add(btnNoviZahtjev);
            Name = "frmUvjerenja";
            Text = "frmUvjerenja";
            Load += frmUvjerenja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoviZahtjev;
        private DataGridView dgvPodaci;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Vrijeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn btnBrisi;
        private DataGridViewButtonColumn btnPrintaj;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbVrsta;
        private Button btnGenerisi;
        private TextBox tbSvrha;
        private TextBox tbBrojGenerisanja;
        private TextBox tbInfo;
        private ErrorProvider errorProvider1;
    }
}