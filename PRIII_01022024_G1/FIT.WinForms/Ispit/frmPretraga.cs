using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
        List<Student> studentiList = new List<Student>();
        Drzave drzava;
        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadDGV();
            loadCMB();
        }

        private void loadCMB()
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
        }

        private void loadDGV()
        {
            
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            drzava = cmbDrzava.SelectedItem as Drzave;
            cmbGrad.DataSource = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();

        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            var odabraniGrad = cmbGrad.SelectedItem as Gradovi;
            studentiList = db.Studenti
                .Where(x=>x.GradId==odabraniGrad.Id)
                .Include(x => x.Grad.Drzava)
                .ToList();

            for (int i = 0; i < studentiList.Count(); i++)
            {
                studentiList[i].prosjek = db.PolozeniPredmeti
                    .Where(x => x.StudentId == studentiList[i].Id)
                    .Count() == 0 ? 5 : db.PolozeniPredmeti
                    .Where(x => x.StudentId == studentiList[i].Id)
                    .Average(x => x.Ocjena);
            }

            if (studentiList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = studentiList;
            }
            if (studentiList.Count() == 0)
            {
                MessageBox.Show($"U bazi nema evidentiranih studenata koji su rodjeni u {odabraniGrad.Naziv},({drzava.Naziv})", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
