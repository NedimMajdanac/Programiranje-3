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
    public partial class frmPrisustvo : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prisustvo> prisustvaData = new List<Prisustvo>();
        public frmPrisustvo()
        {
            InitializeComponent();
        }

        public frmPrisustvo(Prostorije kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
        }

        private void frmPrisustvo_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            lblNaziv.Text = $"{kliknutaProstorija.Naziv} - {kliknutaProstorija.Oznaka}";
            var brojStudenata = 0;
            lblPrisutni.Text = $"{brojStudenata}/{kliknutaProstorija.Kapacitet}";
            loadCMB();
        }



        private void loadCMB()
        {
            cmbStudent.DataSource = db.Studenti.ToList();
            cmbNastava.DataSource = db.Nastava.Where(x => x.ProstorijaId == kliknutaProstorija.Id).ToList();
            cmbNastava.DisplayMember = "Oznaka";
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPrisustva();
        }

        private void loadPrisustva()
        {
            var nastava = cmbNastava.SelectedItem as Nastava;

            prisustvaData = db.Prisustvo
                .Include(x => x.Nastava.Predmet)
                .Where(x => x.NastavaId == nastava.Id)
                .ToList();
            if (prisustvaData != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = prisustvaData;

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var nastava = cmbNastava.SelectedItem as Nastava;
            var student = cmbStudent.SelectedItem as Student;
            var kapacitet = int.Parse(kliknutaProstorija.Kapacitet);

            if (prisustvaData.Exists(x => x.StudentId == student.Id))
            {
                MessageBox.Show($"Student {student.ToString()} je vec evidentiran na nastavi {nastava.ToString()}", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (prisustvaData.Where(x => x.NastavaId == nastava.Id).Select(x => x.StudentId).Count() < kapacitet)
                {
                    var novoPrisustvo = new Prisustvo()
                    {
                        StudentId = student.Id,
                        NastavaId = nastava.Id,
                    };
                    db.Prisustvo.Add(novoPrisustvo);
                    db.SaveChanges();
                    loadPrisustva();
                    var brojStudenata = prisustvaData.Where(x => x.NastavaId == nastava.Id).Select(x => x.StudentId).Count();
                    lblPrisutni.Text = $"{brojStudenata}/{kliknutaProstorija.Kapacitet}";
                }
                else
                {
                    MessageBox.Show("Nije moguce dodati, Prostorija je popunjena!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            var nastava = cmbNastava.SelectedItem as Nastava;
            Thread tred = new Thread(() => generisiTred(student,nastava));
            tred.Start();
            MessageBox.Show("Dodavanje uspjensno", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generisiTred(Student student,Nastava nastava)
        {
          
            var brojGenerisanja = int.Parse(tbBrojGenerisanja.Text);

            var info = "";

            for (int i = 0; i < brojGenerisanja*2; i++)
            {
                Thread.Sleep(300);

                var novoPrisustvo = new Prisustvo()
                {
                    StudentId = student.Id,
                    NastavaId = nastava.Id
                };
                db.Prisustvo.Add(novoPrisustvo);
                db.SaveChanges();
                info += $"{DateTime.Now} -> {student.ToString()} za {nastava.ToString()}{Environment.NewLine}";
            }

            Action action = () =>
            {
                tbInfo.Text = info;
                loadPrisustva();
            };

            BeginInvoke(action);
        }
    }
}
