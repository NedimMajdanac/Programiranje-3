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
    public partial class frmDrzave : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Drzave> drzavaList = new List<Drzave>();
        public frmDrzave()
        {
            InitializeComponent();
        }

        private void frmDrzave_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;

            LoadData();
        }

        private void LoadData()
        {

            drzavaList = db.Drzave.ToList();

            for (int i = 0; i < drzavaList.Count(); i++)
            {
                drzavaList[i].Broj = db.Gradovi.
                    Where(x => x.DrzavaId == drzavaList[i].Id)
                    .Count();
            }

            if (drzavaList != null)
            {
                dgvPodaci.DataSource = null;
                dgvPodaci.DataSource = drzavaList;
            }
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var frm = new frmNovaDržava();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex<=3)
            {
                var kliknutaDrzava = drzavaList[e.RowIndex];
                var frm = new frmNovaDržava(kliknutaDrzava);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }else if (e.ColumnIndex == 4)
            {
                var kliknutaDrzava = drzavaList[e.RowIndex];
                var frm = new frmGradovi(kliknutaDrzava);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
