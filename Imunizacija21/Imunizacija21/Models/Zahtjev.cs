using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public abstract class Zahtjev
    {
        #region Properties
        public Korisnik Korisnik;
        public DateTime DatumZahtjeva { get; }
        public bool OdobrenZahtjev { get; set; }
        public StrucnaOsoba StrucnaOsoba;
        #endregion

        public Zahtjev(Korisnik korisnik)
        {
            Korisnik = korisnik;
        }
    }
}
