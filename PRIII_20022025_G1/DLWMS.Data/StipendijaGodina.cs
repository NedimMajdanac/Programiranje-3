using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class StipendijaGodina
    {

        public int Id { get; set; }
        public int StipendijaId { get; set; }
        public Stipendije Stipendija { get; set; }
        public string Godina { get; set; }
        public int Iznos { get; set; }
        public bool Aktivan { get; set; }

        public int Ukupno => DateTime.Now.Year == int.Parse(Godina) ? Iznos * DateTime.Now.Month : Iznos * 12;

        public override string ToString()
        {
            return $"{Stipendija.Naziv}";
        }

        //public int Id { get; set; }
        //public int StipendijaId { get; set; }
        //public Stipendije Stipendija { get; set; }
        //public string Godina { get; set; }
        //public int Iznos { get; set; }
        //public bool Aktivan { get; set; }

        //public int Ukupno => DateTime.Now.Year == int.Parse(Godina) ? Iznos * DateTime.Now.Month : Iznos * 12;

        //public override string ToString()
        //{
        //    return $"{Stipendija.Naziv}";
        //}
    }
}
