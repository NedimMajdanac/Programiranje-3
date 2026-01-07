using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class StudentiStipendije
    {

        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int StipendijaGodineId { get; set; }
        public StipendijaGodina StipendijaGodine { get; set; }

        // Ispis u DGV
        public string GodinaInfo => StipendijaGodine.Godina ?? "N/A";
        public string StipendijaInfo => StipendijaGodine.Stipendija.Naziv ?? "N/A";
        public int IznosInfo => StipendijaGodine?.Iznos ?? 0;
        public int Ukupno => StipendijaGodine?.Ukupno ?? 0;

       
    }
}
