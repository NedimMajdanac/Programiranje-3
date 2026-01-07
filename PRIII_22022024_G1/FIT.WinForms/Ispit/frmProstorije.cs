using FIT.Data.Ispit;
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
    public partial class frmProstorije : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prostorije> prostorijeList = new List<Prostorije>();
        public frmProstorije()
        {
            InitializeComponent();
        }
        private void frmProstorije_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            loadDGV();
        }

        private void loadDGV()
        {
            prostorijeList = db.Prostorije.ToList();

            foreach (var prostorija in prostorijeList)
            {
                prostorija.BrojPredmeta = db.Nastava.Where(x => x.ProstorijaId == prostorija.Id).Count();
            }

            if (prostorijeList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = prostorijeList;
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kliknutaProstorija = prostorijeList[e.RowIndex];
            if (e.ColumnIndex == 5)
            {
                var frm = new frmNastava(kliknutaProstorija);
                if (frm.ShowDialog() == DialogResult.OK) { loadDGV(); }
            }
            else if(e.ColumnIndex == 6)
            {
                var frm = new frmPrisustvo(kliknutaProstorija);
                frm.ShowDialog();
            }
        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 5)
            {
                var kliknutaProstorija = prostorijeList[e.RowIndex];
                var frm = new frmNovaProstorija(kliknutaProstorija);
                if (frm.ShowDialog() == DialogResult.OK) { loadDGV(); }
            }
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaProstorija();
           if(frm.ShowDialog() == DialogResult.OK) { loadDGV(); }
        }
    }
}
