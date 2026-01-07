using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.Ispit
{
    public class Nastava
    {
        public int Id { get; set; }
        public int PredmetId { get; set; }
        public Predmeti Predmet { get; set; }
        public int ProstorijaId { get; set; }
        public Prostorije Prostorija { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
        public override string ToString()
        {
            return $"{Predmet} - u {Dan} @ {Vrijeme}";
        }

    }
}
