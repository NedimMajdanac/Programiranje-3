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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Ispit
{
    public partial class frmStudentEdit : Form
    {
        private Student? _kliknutiStudent;
        DLWMSContext db = new DLWMSContext();

        public frmStudentEdit(Student? kliknutiStudent = null)
        {
            InitializeComponent();
            this._kliknutiStudent = kliknutiStudent != null ? 
                 db.Studenti
                .Where(x => x.Id == kliknutiStudent.Id)
                .FirstOrDefault() : new Student();
        }

        private void frmStudentEdit_Load(object sender, EventArgs e)
        {
            //txtIme.Text = $"{kliknutiStudent.Ime} {kliknutiStudent.Prezime}";
            //txtIndeks.Text = $"{kliknutiStudent.BrojIndeksa}";
            //pbSlika.Image = Ekstenzije.ToImage(kliknutiStudent.Slika);

            txtIme.Text = $"{_kliknutiStudent.Ime} {_kliknutiStudent.Prezime}";
            txtIndeks.Text = $"{_kliknutiStudent.BrojIndeksa}";
            pbSlika.Image = Ekstenzije.ToImage(_kliknutiStudent.Slika);

            cmbDrzava.UcitajPodatke(db.Drzave.ToList());
        }
          

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;
            cmbGrad.DataSource = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
        }

        private void btnLoadSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            _kliknutiStudent.GradId = (int)cmbGrad.SelectedValue;
            _kliknutiStudent.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
            
            db.Update(_kliknutiStudent);
            db.SaveChanges();
            
            DialogResult = DialogResult.OK;
        }
    }
}
