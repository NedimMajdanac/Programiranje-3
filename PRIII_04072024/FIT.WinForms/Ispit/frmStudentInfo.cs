using FIT.Data;
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
    public partial class frmStudentInfo : Form
    {
        private Student kliknutiStudent;

        public frmStudentInfo()
        {
            InitializeComponent();
        }

        public frmStudentInfo(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Ekstenzije.ToImage(kliknutiStudent.Slika);
            lblIme.Text = $"{kliknutiStudent.ToString()}";
            lblProsjek.Text = $"Prosjek: {kliknutiStudent.Prosjek}";

        }
    }
}
