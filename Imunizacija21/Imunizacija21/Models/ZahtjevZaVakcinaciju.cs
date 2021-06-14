using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class ZahtjevZaVakcinaciju: Zahtjev
    {
        #region Properties
        [Required]
        [NotMapped]
        public List<TipVakcine> OdabraneVakcine { get; set; }
        #endregion

        #region Constructors
        public ZahtjevZaVakcinaciju()
        {
            OdabraneVakcine = new List<TipVakcine>();
        }

        public ZahtjevZaVakcinaciju(int korisnikID, List<TipVakcine> odabraneVakcine): base(korisnikID)
        {
            OdabraneVakcine = new List<TipVakcine>(odabraneVakcine);
        }
        #endregion
    }
}
