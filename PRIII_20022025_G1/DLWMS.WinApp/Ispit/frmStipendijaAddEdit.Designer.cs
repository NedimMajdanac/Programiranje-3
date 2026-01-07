namespace DLWMS.WinApp.Ispit
{
    partial class frmStipendijaAddEdit
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
            cmbStudent = new ComboBox();
            cmbGodina = new ComboBox();
            cmbStipendija = new ComboBox();
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(354, 86);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(559, 49);
            cmbStudent.TabIndex = 0;
            // 
            // cmbGodina
            // 
            cmbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGodina.FormattingEnabled = true;
            cmbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018" });
            cmbGodina.Location = new Point(354, 166);
            cmbGodina.Name = "cmbGodina";
            cmbGodina.Size = new Size(559, 49);
            cmbGodina.TabIndex = 1;
            cmbGodina.SelectedIndexChanged += cmbGodina_SelectedIndexChanged;
            // 
            // cmbStipendija
            // 
            cmbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStipendija.FormattingEnabled = true;
            cmbStipendija.Location = new Point(354, 239);
            cmbStipendija.Name = "cmbStipendija";
            cmbStipendija.Size = new Size(559, 49);
            cmbStipendija.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(354, 330);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(559, 58);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 242);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 4;
            label1.Text = "Stipendija:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 174);
            label2.Name = "label2";
            label2.Size = new Size(121, 41);
            label2.TabIndex = 5;
            label2.Text = "Godina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 94);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 6;
            label3.Text = "Student:";
            // 
            // frmStipendijaAddEdit
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 476);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbStipendija);
            Controls.Add(cmbGodina);
            Controls.Add(cmbStudent);
            Name = "frmStipendijaAddEdit";
            Text = "frmStipendijaAddEdit";
            Load += frmStipendijaAddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbGodina;
        private ComboBox cmbStipendija;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}