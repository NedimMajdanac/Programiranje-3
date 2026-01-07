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
    public partial class frmNovaProstorija : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorija()
        {
            InitializeComponent();
        }

        public frmNovaProstorija(Prostorije kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
        }

        private void frmNovaProstorija_Load(object sender, EventArgs e)
        {
            if (kliknutaProstorija != null)
            {
                pbLogo.Image = Ekstenzije.ToImage(kliknutaProstorija.Logo);
                tbKapacitet.Text = kliknutaProstorija.Kapacitet;
                tbNaziv.Text = kliknutaProstorija.Naziv;
                tbOznaka.Text = kliknutaProstorija.Oznaka;
            }
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var naziv = tbNaziv.Text;
            var oznaka = tbOznaka.Text;
            var kapacitet = tbKapacitet.Text;
            var logo = Ekstenzije.ToByteArray(pbLogo.Image);
            if (isValid())
            {
                if (kliknutaProstorija == null)
                {
                    var novaProstorija = new Prostorije()
                    {
                        Naziv = naziv,
                        Oznaka = oznaka,
                        Kapacitet = kapacitet,
                        Logo = logo,
                    };
                    db.Prostorije.Add(novaProstorija);
                }
                else
                {
                    kliknutaProstorija.Naziv = naziv;
                    kliknutaProstorija.Oznaka = oznaka;
                    kliknutaProstorija.Kapacitet= kapacitet;
                    kliknutaProstorija.Logo = logo;
                    db.Prostorije.Update(kliknutaProstorija);
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbKapacitet, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbOznaka, err, Kljucevi.ReqiredValue);
        }
    }
}
