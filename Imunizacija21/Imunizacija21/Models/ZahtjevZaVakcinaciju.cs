using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class ZahtjevZaVakcinaciju: Zahtjev
    {
        #region Properties
        public List<Vakcina> OdabraneVakcine { get; }
        #endregion

        public ZahtjevZaVakcinaciju(Korisnik korisnik, List<Vakcina> odabraneVakcine): base(korisnik)
        {
            OdabraneVakcine = odabraneVakcine;
        }
    }
}
