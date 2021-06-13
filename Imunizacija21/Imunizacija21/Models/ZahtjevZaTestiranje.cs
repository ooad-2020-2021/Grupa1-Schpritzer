using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class ZahtjevZaTestiranje: Zahtjev
    {
        #region Properties
        [Required]
        [NotMapped]
        public List<string> Razlozi { get; set; }
        //[Required]
        public string Opis { get; set; }
        [EnumDataType(typeof(TipCovidTesta))]
        [Required]
        public TipCovidTesta TipCovidTesta { get; set; }
        #endregion

        #region Constructors
        public ZahtjevZaTestiranje() {
            Razlozi = new List<string>();
        }

        public ZahtjevZaTestiranje(int korisnikID, List<string> razlozi, string opis, TipCovidTesta tip): base(korisnikID)
        {
            Razlozi = new List<string>(razlozi);
            Opis = opis;
            TipCovidTesta = tip;
        }
        #endregion
    }
}
