using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class ZahtjevZaTestiranje: Zahtjev
    {
        #region Properties
        public List<string> Razlozi { get; }
        public string Opis { get; }
        #endregion

        public ZahtjevZaTestiranje(Korisnik korisnik, List<string> razlozi, string opis): base(korisnik)
        {
            Razlozi = razlozi;
            Opis = opis;
        }
    }
}
