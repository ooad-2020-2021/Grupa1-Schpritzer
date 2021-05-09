using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class StrucnaOsoba: Osoba
    {
        #region Properties
        public List<Zahtjev> Zahtjevi;
        #endregion

        public StrucnaOsoba(string ime, string prezime, string spol, string jmbg, string email, List<String> brojeviTelefona,
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova) : base(ime, prezime, spol, jmbg, email, brojeviTelefona, lokalnaZdravstvenaUstanova)
        {

        }
    }
}
