using FIT.Data;
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
    public partial class frmNovoUvjerenje : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenje()
        {
            InitializeComponent();
        }

        public frmNovoUvjerenje(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var novoUvjerenje = new StudentiUvjerenja()
                {
                    StudentId = kliknutiStudent.Id,
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Svrha = tbSvrha.Text,
                    Vrijeme = DateTime.Now.ToString(),
                    Uplatnica = Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Printano = false,
                };
                db.StudentiUvjerenja.Add(novoUvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool isValid()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrsta, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(tbSvrha, errorProvider1, Kljucevi.ReqiredValue)
                && Helpers.Validator.ProvjeriUnos(pbUplatnica, errorProvider1, Kljucevi.ReqiredValue);

        }

        private void frmNovoUvjerenje_Load(object sender, EventArgs e)
        {
            cmbVrsta.SelectedIndex = 0;
        }
    }
}
