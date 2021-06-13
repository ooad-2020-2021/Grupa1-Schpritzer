using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class KorisnikZahtjev
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public string JMBG { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        [EnumDataType(typeof(LokalnaZdravstvenaUstanova))]
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova { get; set; }
        public string ZdravstvenaKartica { get; set; }
        public string Adresa { get; set; }
        public Zanimanje Zanimanje { get; set; }
        public int IDZahtjeva { get; set; }
        public int KorisnikID { get; set; }
        public DateTime DatumZahtjeva { get; set; }
        public bool OdobrenZahtjev { get; set; }
        public int StrucnaOsobaID { get; set; }
    }
}
