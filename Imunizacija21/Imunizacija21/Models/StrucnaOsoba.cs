using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class StrucnaOsoba: Osoba
    {
        #region Properties
        [NotMapped]
        //[Required]
        public List<Zahtjev> Zahtjevi;
        #endregion

        public StrucnaOsoba() { }

        public StrucnaOsoba(string ime, string prezime, string spol, string jmbg, string email, List<String> brojeviTelefona,
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova) : base(ime, prezime, spol, jmbg, email, brojeviTelefona, lokalnaZdravstvenaUstanova)
        {

        }
    }
}
