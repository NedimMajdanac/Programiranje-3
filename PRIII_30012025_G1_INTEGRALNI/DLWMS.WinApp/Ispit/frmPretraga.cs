using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Ispit
{
    public partial class frmPretraga : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studentList = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            studentList = db.Studenti.Include(x => x.Grad.Drzava).ToList();
            loadCMB();
            loadDGV(studentList);
        }
        private void loadDGV(List<Student> studentList)
        {
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = studentList;
            
        }

        private void loadCMB()
        {
            cmbSpol.DataSource = db.Spolovi.ToList();
            cmbDrzava.DataSource = db.Drzave.ToList();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiStudent = studentList[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                kliknutiStudent.Aktivan = kliknutiStudent.Aktivan == true ? false : true;
                db.Studenti.Update(kliknutiStudent);
                db.SaveChanges();
            }
            else if (e.ColumnIndex == 5)
            {
                var frm = new frmRazmjene(kliknutiStudent);
                frm.ShowDialog();
            }
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void loadPretraga()
        {
            var spol = cmbSpol.SelectedItem.ToString();
            var drzava = cmbDrzava.SelectedItem as Drzava;
            string imeOrprezime = tbSearch.Text.ToLower();


            if (drzava == null || spol == null) { return; }

            var studentList = db.Studenti
                .Where(x => x.Spol.Naziv == spol && x.Grad.DrzavaId == drzava.Id && x.Ime.ToLower().Contains(imeOrprezime) || x.Prezime.ToLower().Contains(imeOrprezime))
                .ToList();
            //&& x.Ime.ToLower().Contains(imeOrprezime) || x.Prezime.ToLower().Contains(imeOrprezime)


            loadDGV(studentList);
        }


        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            loadPretraga();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiStudent = studentList[e.RowIndex] as Student;

           
            if(e.ColumnIndex<5)
            {
                var frm = new frmStudentEdit(kliknutiStudent);
                if (frm.ShowDialog() == DialogResult.OK) { loadDGV(studentList); }
            }

        }
    }
}
