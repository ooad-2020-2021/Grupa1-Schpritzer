using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public abstract class Zahtjev
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        /*[Required]
        public Korisnik Korisnik;*/
        [Required]
        public int KorisnikID;
        [DataType(DataType.Date)]
        [Required]
        public DateTime DatumZahtjeva { get; set; }
        //[Required]
        public bool? OdobrenZahtjev { get; set; } = null;
        /*[Required]
        public StrucnaOsoba StrucnaOsoba { get; set; }*/
        [Required]
        public int StrucnaOsobaID { get; set; }
        #endregion

        #region Constructors
        public Zahtjev() {}

        public Zahtjev(int korisnikID)
        {
            KorisnikID = korisnikID;
        }
        #endregion
    }
}
