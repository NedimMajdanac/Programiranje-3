using FIT.Data;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Ispit
{
    public partial class frmPretraga : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studentList = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            cmbSpol.SelectedIndex = 0;
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void loadPretraga()
        {
            var spol = cmbSpol.SelectedItem.ToString();
            var dtpFromDate = dtpFrom.Value;
            var dtpToDate = dtpTo.Value;

            if (spol != "Svi")
            {
                studentList = db.Studenti
                    .Where(x => x.Spol == spol && x.DatumRodjenja >= dtpFromDate && x.DatumRodjenja <= dtpToDate)
                    .ToList();
            }
            else
            {
                studentList = db.Studenti
                    .Where(x => x.DatumRodjenja >= dtpFromDate && x.DatumRodjenja <= dtpToDate)
                    .ToList();
            }


            foreach (var student in studentList)
            {
                student.Prosjek = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? 5 :
                    db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena);
            }

            if (studentList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = studentList;
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiStudent = studentList[e.RowIndex];
            if (e.ColumnIndex < 5)
            {
                var frm = new frmStudentInfo(kliknutiStudent);
                frm.ShowDialog();
            }else if (e.ColumnIndex == 5)
            {
                var frm = new frmUvjerenja(kliknutiStudent);
                frm.ShowDialog();
            }
        }
    }
}
