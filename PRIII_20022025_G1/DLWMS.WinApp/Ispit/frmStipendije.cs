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
    public partial class frmStipendije : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijaGodina> stipendijaGodinaData;
        public frmStipendije()
        {
            InitializeComponent();
        }

        private void frmStipendije_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadDataGridView();
            loadComboBox();
        }

        private void loadComboBox()
        {
            cmbStipendija.DataSource = db.Stipendije.ToList();
            cmbGodina.SelectedIndex = 0;
        }

        private void loadDataGridView()
        {
            stipendijaGodinaData = db.StipendijeGodine
                .Include(x => x.Stipendija)
                .ToList();

            if (stipendijaGodinaData != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = stipendijaGodinaData;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var godina = cmbGodina.SelectedItem?.ToString();
            var stipendija = cmbStipendija.SelectedItem as Stipendije;
            var iznos = int.Parse(tbIznos.Text);
            if (isValid())
            {
                if (stipendijaGodinaData.Exists(x => x.Godina == godina && x.StipendijaId == stipendija.Id))
                {
                    MessageBox.Show($"{stipendija} je vec evidentirana na nivou {godina}. godine", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var novaStipendija = new StipendijaGodina()
                    {
                        StipendijaId = stipendija.Id,
                        Godina = godina,
                        Iznos = iznos,
                        Aktivan = DateTime.Now.Year.ToString() == godina ? true : false,
                    };
                    db.StipendijeGodine.Add(novaStipendija);
                    db.SaveChanges();
                    loadDataGridView();
                }
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(cmbGodina, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(cmbStipendija, err, Kljucevi.RequiredField)
                && Helpers.Validator.ProvjeriUnos(tbIznos, err, Kljucevi.RequiredField);

        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var kliknutaStipendija = dgvPodaci.SelectedRows[0].DataBoundItem as StipendijaGodina;
            Thread tred = new Thread(() => generisiTred(kliknutaStipendija));
            tred.Start();
        }

        private void generisiTred(StipendijaGodina? kliknutaStipendija)
        {
            var sviStudenti = db.Studenti.ToList();
            var studentiStipendije = db.StudentiStipendije.ToList();
            var info = "";
            var brojac = 1;

            for (int i = 0; i < sviStudenti.Count(); i++)
            {
                if (!studentiStipendije.Exists(x => x.StipendijaGodine.Godina == kliknutaStipendija.Godina && x.StudentId == sviStudenti[i].Id))
                {
                    var novaStudentStipendija = new StudentiStipendije()
                    {
                        StudentId = sviStudenti[i].Id,
                        StipendijaGodineId = kliknutaStipendija!.Id
                    };

                    db.StudentiStipendije.Add(novaStudentStipendija);
                    db.SaveChanges();

                    info += $"{brojac}. {kliknutaStipendija.Stipendija} stipendija u iznosu od {kliknutaStipendija.Iznos} BAM dodijeljena {sviStudenti[i]}{Environment.NewLine}";

                    brojac++;
                }
            }

            Action action = () =>
            {
                if (brojac != 1)
                {
                    MessageBox.Show($"Uspjesno je dodadno {brojac} stipendija", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ne postoje stipendije koje ispunjavaju uslov generisanja", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tbInfo.Text = info;
            };
            BeginInvoke(action);
        }

        private void dgvPodaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutaStipendija = stipendijaGodinaData[e.RowIndex];

            kliknutaStipendija.Aktivan = !kliknutaStipendija.Aktivan;

            db.StipendijeGodine.Update(kliknutaStipendija);
            db.SaveChanges();

            loadDataGridView();
        }
    }
}
