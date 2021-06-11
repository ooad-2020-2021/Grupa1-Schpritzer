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
        public List<Vakcina> OdabraneVakcine { get; set; }
        #endregion

        #region Constructors
        public ZahtjevZaVakcinaciju() { }

        public ZahtjevZaVakcinaciju(int korisnikID, List<Vakcina> odabraneVakcine): base(korisnikID)
        {
            OdabraneVakcine = odabraneVakcine;
        }
        #endregion
    }
}
