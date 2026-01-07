using DLWMS.Data;
using DLWMS.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StudentiStipendije> studentStipendijaData;
        public frmPretraga()
        {
            InitializeComponent();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadComboBox();
        }

        private void loadComboBox()
        {
            cmbGodina.SelectedIndex = 0;
            cmbStipendija.DataSource = db.Stipendije.ToList();
        }

        private void loadDataGridView()
        {
            var godina = cmbGodina.SelectedItem?.ToString();
            var stipendija = cmbStipendija.SelectedItem as Stipendije ?? new Stipendije();

            studentStipendijaData = db.StudentiStipendije
                .Include(x => x.Student)
                .Include(x => x.StipendijaGodine.Stipendija)
                .Where(x => x.StipendijaGodine.Godina == godina)
                .Where(x => x.StipendijaGodine.StipendijaId == stipendija!.Id)
                .ToList();

            this.Text = $"Broj prikazanih stipendija -> {studentStipendijaData.Count()}";

            if (studentStipendijaData != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = studentStipendijaData;
                //if (studentStipendijaData.Count() == 0)
                //{
                //    MessageBox.Show($"Nema studenata koji za {godina} godinu primaju {stipendija} stipendiju", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
        }

        private void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void cmbStipendija_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var kliknutaStipendija = studentStipendijaData[e.RowIndex];
                DialogResult odabir = MessageBox.Show($"Da li zelite da obriste {kliknutaStipendija.StipendijaInfo} stipendiju studenata{kliknutaStipendija.Student}?", "Upit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (odabir == DialogResult.Yes)
                {
                    db.StudentiStipendije.Remove(kliknutaStipendija);
                    db.SaveChanges();

                    loadDataGridView();
                }
            }
        }

        private void btnDodajStipendiju_Click(object sender, EventArgs e)
        {
            var frm = new frmStipendijaAddEdit();
            if (frm.ShowDialog() == DialogResult.OK)
                loadDataGridView();
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutaStipendija = studentStipendijaData[e.RowIndex];
            if (e.ColumnIndex != 5)
            {
                var frm = new frmStipendijaAddEdit(kliknutaStipendija);
                if (frm.ShowDialog() == DialogResult.OK)
                    loadDataGridView();
            }
        }

        private void btnStipendije_Click(object sender, EventArgs e)
        {
            var frm = new frmStipendije();
            frm.ShowDialog();
        }
    }
}
