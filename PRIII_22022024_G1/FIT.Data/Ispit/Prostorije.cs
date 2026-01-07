using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.Ispit
{
    public class Prostorije
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public byte[] Logo { get; set; }
        public string Kapacitet { get; set; }
        [NotMapped]
        public int BrojPredmeta { get; set; }

    }
}
