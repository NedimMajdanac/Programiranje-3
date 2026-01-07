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
    public partial class frmRazmjene : Form
    {
        private Student? _kliknutiStudent;
        DLWMSContext db = new DLWMSContext();


        public frmRazmjene(Student? kliknutiStudent = null)
        {
            InitializeComponent();
            this._kliknutiStudent = kliknutiStudent != null ?
                db.Studenti.Where(x => x.Id == kliknutiStudent.Id).FirstOrDefault() :
                new Student();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRazmjene_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadRazmjena();
            loadCMB();
        }

        private void loadCMB()
        {
            cmbDrzava.UcitajPodatke(db.Drzave.ToList());
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";

            cmbUni.UcitajPodatke(db.Univerziteti.ToList());
            cmbUni.DisplayMember = "Naziv";
            cmbUni.ValueMember = "Id";

        }

        private void loadRazmjena()
        {
            var razmjeneList = db.Razmjene.Where(x => x.StudentId == _kliknutiStudent.Id).Include(x => x.Univerzitet).ToList();
            if (razmjeneList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = razmjeneList;
            }

        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzava;

            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = db.Razmjene
                .Where(x => x.Univerzitet.DrzavaId == drzava.Id && x.StudentId == _kliknutiStudent.Id)
                .ToList();


            cmbUniverzitet.UcitajPodatke(db.Univerziteti.Where(x => x.DrzavaId == drzava.Id).ToList());
            cmbUniverzitet.DisplayMember = "Naziv";
            cmbUniverzitet.ValueMember = "Id";

            
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var un = cmbUniverzitet.SelectedItem as Univerzitet;
            var ects = tbECTS.Text;
            var dateStart = dtpStart.Value.Date;
            var dateEnd = dtpEnd.Value.Date;



            if (db.Razmjene.ToList().Exists(x => x.Pocetak == dateStart && x.Kraj == dateEnd))
            {
                MessageBox.Show("Nije moguce dodati razmjenu jer je student vec u tom periodu na razmjeni", "Obavijest", MessageBoxButtons.OK);


            }
            else if (dateStart > dateEnd)
            {
                MessageBox.Show("Nije moguce odabrati kraj razmjene", "Obavijest", MessageBoxButtons.OK);
            }
            else
            {
                var novaRazmjena = new Razmjene()
                {
                    StudentId = _kliknutiStudent.Id,
                    UniverzitetId = un.Id,
                    Pocetak = dateStart,
                    Kraj = dateEnd,
                    ECTS = ects,
                    Okoncana = dateEnd < DateTime.Now ? true : false,
                };
                db.Razmjene.Add(novaRazmjena);
                db.SaveChanges();
                loadRazmjena();
            }
        }

        private bool isValid()
        {
            return
                Helpers.Validator.ProvjeriUnos(cmbUniverzitet, errorProvider1, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(tbECTS, errorProvider1, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(dtpStart, errorProvider1, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(dtpEnd, errorProvider1, Kljucevi.RequiredField);

        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                var razmjena = db.Razmjene.Where(x => x.StudentId == _kliknutiStudent.Id).Include(x => x.Univerzitet).ToList();
                var kliknutaRazmjena = razmjena[e.RowIndex];
                DialogResult odabir = MessageBox.Show($"Da li zelite da obriste razmjenu na {kliknutaRazmjena.Univerzitet} za studenta {_kliknutiStudent.ToString()}", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (odabir == DialogResult.Yes)
                {
                    db.Razmjene.Remove(kliknutaRazmjena);
                    db.SaveChanges();
                    loadRazmjena();
                }
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (isValidThreading()) 
            {
                var univerzitet = cmbUni.SelectedItem as Univerzitet;
                Thread tred = new Thread(() => generateThread(univerzitet));
                tred.Start();
            }
        }

        private bool isValidThreading()
        {
            return Helpers.Validator.ProvjeriUnos(cmbUni, errorProvider1, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(tbBrojBodova, errorProvider1, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(tbBrojRazmjene, errorProvider1, Kljucevi.RequiredField);
                
        }


        private void generateThread(Univerzitet univerzitet)
        {
            
            var brojGenerisanja = int.Parse(tbBrojRazmjene.Text);
            var brojBodova = int.Parse(tbBrojBodova.Text);
            
            DateTime pocetniDatum = new DateTime(2025,1,1);
            DateTime trenutniDatum = DateTime.Now.Date; 

            string info = "";

            for (int i = 1; i <= brojGenerisanja; i++)
            {
                int trajanjeRazmjene = brojBodova + (i + 1);
                DateTime kraj = pocetniDatum.AddDays(trajanjeRazmjene);
                bool okoncana = kraj < trenutniDatum;

                var novaRazmjena = new Razmjene()
                {
                    StudentId = _kliknutiStudent.Id,
                    UniverzitetId = univerzitet.Id,
                    Pocetak = pocetniDatum,
                    Kraj = kraj,
                    ECTS = brojBodova.ToString(),
                    Okoncana = okoncana,
                };
                db.Razmjene.Add(novaRazmjena);
                info += $"{i}. razmjena za {_kliknutiStudent.ToString()} na {univerzitet.ToString()} ({novaRazmjena.Pocetak}-{novaRazmjena.Kraj}){Environment.NewLine}";
                Thread.Sleep(300);
                db.SaveChanges();
                pocetniDatum = kraj.AddDays(1);
            }

            MessageBox.Show("Podaci uspjesno generisani", "obavijes", MessageBoxButtons.OK);

            Action action = () =>
            {
                tbInfo.Text = info;
                loadRazmjena();
            };

            BeginInvoke(action);
        }
    }
}
