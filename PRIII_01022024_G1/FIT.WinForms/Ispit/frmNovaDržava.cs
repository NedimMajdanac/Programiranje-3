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
    public partial class frmNovaDržava : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Drzave kliknutaDrzava;

        public frmNovaDržava()
        {
            InitializeComponent();
        }

        public frmNovaDržava(Drzave kliknutaDrzava)
        {
            InitializeComponent();
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void frmNovaDržava_Load(object sender, EventArgs e)
        {
            if (kliknutaDrzava != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(kliknutaDrzava.Zastava);
                tbNaziv.Text = kliknutaDrzava.Naziv;
                cbAktivna.Checked = kliknutaDrzava.Status;
            }
        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var naziv = tbNaziv.Text;
            var status = cbAktivna.Checked;
            var zastava = Ekstenzije.ToByteArray(pbZastava.Image);

            if (isValid())
            {
                if (kliknutaDrzava == null)
                {
                    var novaDrzava = new Drzave()
                    {
                        Naziv = naziv,
                        Status = status,
                        Zastava = zastava
                    };
                    db.Drzave.Add(novaDrzava);

                } else
                {
                    kliknutaDrzava.Zastava = zastava;
                    kliknutaDrzava.Naziv = naziv;
                    kliknutaDrzava.Status = status;

                    db.Drzave.Update(kliknutaDrzava);
                }
               
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbNaziv, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(cbAktivna, errorProvider1, Kljucevi.ReqiredValue);
                
        }
    }
}
