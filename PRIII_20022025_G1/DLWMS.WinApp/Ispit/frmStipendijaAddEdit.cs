using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Ispit
{
    public partial class frmStipendijaAddEdit : Form
    {
        private StudentiStipendije kliknutaStipendija;
        DLWMSContext db = new DLWMSContext();
        public frmStipendijaAddEdit()
        {
            InitializeComponent();
        }

        public frmStipendijaAddEdit(StudentiStipendije kliknutaStipendija)
        {
            InitializeComponent();
            this.kliknutaStipendija = kliknutaStipendija;
        }

        private void frmStipendijaAddEdit_Load(object sender, EventArgs e)
        {
            loadComboBox();
           // loadInfo();
        }

        private void loadComboBox()
        {
            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStipendija.DataSource = db.StipendijeGodine.Select(x => x.Stipendija).Distinct().ToList();

        }

        private void loadInfo()
        {
            if (kliknutaStipendija != null)
            {
                cmbStudent.SelectedIndex = db.Studenti.ToList().FindIndex(x => x.Id == kliknutaStipendija.StudentId);
                cmbStudent.Enabled = false;

                cmbGodina.SelectedItem = kliknutaStipendija.StipendijaGodine.Godina;

                cmbStipendija.SelectedIndex = db.StipendijeGodine.ToList().FindIndex(x => x.StipendijaId == kliknutaStipendija.StipendijaGodine.StipendijaId);
            }
            else
            {
                cmbGodina.SelectedIndex = 0;
            }
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            var stipendijaGodina = cmbStipendija.SelectedItem as StipendijaGodina;

            
            if (db.StudentiStipendije.ToList().Exists(x =>x.StipendijaGodine !=null && x.StipendijaGodine.Godina == stipendijaGodina.Godina && x.StudentId == student.Id))
            {
                MessageBox.Show($"Student {student} vec prima stipendiju za {stipendijaGodina.Godina} godinu","Obavijest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var novaStudentStipendija = new StudentiStipendije()
                {
                    StudentId = student.Id,
                    StipendijaGodineId = stipendijaGodina.Id,
                };
                
                db.StudentiStipendije.Add(novaStudentStipendija);
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
