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
        public List<string> Razlozi { get; }
        //[Required]
        public string Opis { get; }
        #endregion

        public ZahtjevZaTestiranje() { }

        public ZahtjevZaTestiranje(Korisnik korisnik, List<string> razlozi, string opis): base(korisnik)
        {
            Razlozi = razlozi;
            Opis = opis;
        }
    }
}
