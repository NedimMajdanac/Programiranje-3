using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class Razmjene
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UniverzitetId { get; set; }
        public Univerzitet Univerzitet { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Kraj { get; set; }
        public string ECTS { get; set; }
        public bool Okoncana { get; set; }
        public override string ToString()
        {
            return $"{Univerzitet}";
        }
    }
}
