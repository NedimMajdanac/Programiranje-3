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
    public partial class frmNastava : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Prostorije kliknutaProstorija;
        List<Nastava> nastavaList = new List<Nastava>();

        public frmNastava()
        {
            InitializeComponent();
        }

        public frmNastava(Prostorije kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
        }

        private void frmNastava_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = $"{kliknutaProstorija.Naziv} - {kliknutaProstorija.Oznaka}";
            loadCMB();

            dgvPodaci.AutoGenerateColumns = false;

            loadDGV();
        }

        private void loadDGV()
        {
            nastavaList = db.Nastava
               .Include(x => x.Predmet)
               .Where(x => x.ProstorijaId == kliknutaProstorija.Id)
               .ToList();

            if (nastavaList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = nastavaList;
            }
        }

        private void loadCMB()
        {
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
            cmbPredmet.DataSource = db.Predmeti.ToList();
            cmbPredmet.DisplayMember = "Naziv";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dan = cmbDan.SelectedItem.ToString();
            var vrijeme = cmbVrijeme.SelectedItem.ToString();
            var predmet = cmbPredmet.SelectedItem as Predmeti;

            if (nastavaList.Exists(x => x.Vrijeme == vrijeme && x.ProstorijaId == kliknutaProstorija.Id && x.Dan==dan))
            {
                MessageBox.Show($"U prostoriji {kliknutaProstorija.Naziv} je evidentirana nastava u periodu {vrijeme} dana {dan}", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var novaNastava = new Nastava()
                {
                    Vrijeme = vrijeme,
                    Dan = dan,
                    ProstorijaId = kliknutaProstorija.Id,
                    PredmetId = predmet.Id,
                    Oznaka = $"{predmet.Naziv} :: {dan} :: {vrijeme}"
                };
                db.Nastava.Add(novaNastava);
                db.SaveChanges();
                loadDGV();
                DialogResult = DialogResult.OK;
            }

        }
    }
}
