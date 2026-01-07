using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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

    public partial class frmGradovi : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Drzave kliknutaDrzava;
        List<Gradovi> gradoviList = new List<Gradovi>();

        public frmGradovi()
        {
            InitializeComponent();
        }

        public frmGradovi(Drzave kliknutaDrzava)
        {
            InitializeComponent();
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void frmGradovi_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadInfo();
            loadDGV();
        }

        private void loadDGV()
        {
            gradoviList = db.Gradovi.
               Where(x => x.DrzavaId == kliknutaDrzava.Id).
               ToList();
            if (gradoviList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = gradoviList;
            }
        }

        private void loadInfo()
        {
            pbZastava.Image = Ekstenzije.ToImage(kliknutaDrzava.Zastava);
            lblDrzava.Text = $"{kliknutaDrzava.Naziv}";
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutiGrad = gradoviList[e.RowIndex];
            if (e.ColumnIndex == 2)
            {
                kliknutiGrad.Status = kliknutiGrad.Status == true ? false : true;
            }
            db.Gradovi.Update(kliknutiGrad);
            db.SaveChanges();

            loadDGV();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var nazivGrad = tbNaziv.Text;

            if (isValid())
            {
                if (gradoviList.Exists(x => x.Naziv.ToLower() == nazivGrad.ToLower()))
                {
                    MessageBox.Show($"Grad {nazivGrad} vec postoji u bazi", "Upozerenje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var noviGrad = new Gradovi()
                    {
                        Naziv = nazivGrad,
                        Status = true,
                        DrzavaId = kliknutaDrzava.Id
                    };
                    db.Gradovi.Add(noviGrad);
                    db.SaveChanges();
                    loadDGV();
                }
            }
            DialogResult = DialogResult.OK;
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (isValidThread())
            {
                Thread tred = new Thread(() => generisiTred());
                tred.Start();
            }
        }

        private void generisiTred()
        {
            var brojGenerisanja = int.Parse(tbBrojGenerisanja.Text);
            var aktivan = cbAktivna.Checked;
            var info = "";

            for (int i = 1; i <= brojGenerisanja; i++)
            {
                var noviGrad = new Gradovi()
                {
                    DrzavaId = kliknutaDrzava.Id,
                    Naziv = $"Grad {i}.",
                    Status = aktivan
                };
                info += $"{DateTime.Now} -> dodat grad {noviGrad.Naziv} za drzavu {kliknutaDrzava.Naziv}{Environment.NewLine}";
                db.Gradovi.Add(noviGrad);
                db.SaveChanges();
            }

            Action action = () =>
            {
                tbInfo.Text = info;
                loadDGV();
            };

            BeginInvoke(action);
        }

        private bool isValidThread()
        {
            return Helpers.Validator.ProvjeriUnos(tbBrojGenerisanja,errorProvider1 , Kljucevi.ReqiredValue);
        }
    }
}
