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
    public partial class frmUvjerenja : Form
    {
        private Student kliknutiStudent;
        List<StudentiUvjerenja> studentiUvjerenjaList = new List<StudentiUvjerenja>();
        DLWMSDbContext db = new DLWMSDbContext();
        public frmUvjerenja()
        {
            InitializeComponent();
        }

        public frmUvjerenja(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
        }

        private void frmUvjerenja_Load(object sender, EventArgs e)
        {
            cmbVrsta.SelectedIndex = 0;
            dgvPodaci.AutoGenerateColumns = false;
            loadDGV();
        }

        private void loadDGV()
        {
            studentiUvjerenjaList = db.StudentiUvjerenja.Where(x => x.StudentId == kliknutiStudent.Id).ToList();
            if (studentiUvjerenjaList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = studentiUvjerenjaList;
            }
            this.Text = $"Broj uvjerenja -> {studentiUvjerenjaList.Count()}";
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var kliknutoUvjerenje = studentiUvjerenjaList[e.RowIndex];
                DialogResult odabir = MessageBox.Show($"Da li zelite obrisati uvjerenje za studenta {kliknutiStudent.ToString()}?", "Upozorenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (odabir == DialogResult.Yes)
                {
                    db.StudentiUvjerenja.Remove(kliknutoUvjerenje);
                    db.SaveChanges();
                    MessageBox.Show("Podaci uspjesno obrisani!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDGV();
                }
            }
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e)
        {
            var frm = new frmNovoUvjerenje(kliknutiStudent);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                loadDGV();
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var vrsta = cmbVrsta.SelectedItem.ToString() ?? "N/A";
            if (studentiUvjerenjaList.Count() == 0)
            {
                MessageBox.Show($"Nije moguce uraditi generisanje zahtjeva za studenta {kliknutiStudent.ToString()}, dodajte novi zahtjev prije generisanja!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thread thread = new Thread(() => generisiTred(vrsta));
                thread.Start();
            }
        }

        private void generisiTred(string vrsta)
        {
            var brojGenerisanja = int.Parse(tbBrojGenerisanja.Text);
            var svrha = tbSvrha.Text;

            var info = "";

            for (int i = 0; i < brojGenerisanja; i++)
            {
                Thread.Sleep(300);  
                if(isValidThread())
                {
                    var noviZahtjev = new StudentiUvjerenja()
                    {
                        StudentId = kliknutiStudent.Id,
                        Vrijeme = DateTime.Now.ToString(),
                        Vrsta = vrsta,
                        Svrha = svrha,
                        Uplatnica = studentiUvjerenjaList[0].Uplatnica,
                        Printano = false,
                    };
                    db.StudentiUvjerenja.Add(noviZahtjev);
                    db.SaveChanges();
                    info += $"{noviZahtjev.Vrijeme} -> {noviZahtjev.Vrsta} ({kliknutiStudent.Indeks}) {kliknutiStudent.ToString()} u svrhu {noviZahtjev.Svrha}{Environment.NewLine}";
                }
            }

            Action action = () =>
            {
                tbInfo.Text = info;
                MessageBox.Show($"Uvjerenja za studenta {kliknutiStudent.ToString()} uspjesno generisana", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDGV();
            };

            BeginInvoke(action);
        }

        private bool isValidThread()
        {
            return Helpers.Validator.ProvjeriUnos(tbBrojGenerisanja, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue);
                
        }
    }
}
