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
        [Required]
        public Korisnik Korisnik;
        [DataType(DataType.Date)]
        [Required]
        public DateTime DatumZahtjeva { get; }
        //[Required]
        public bool OdobrenZahtjev { get; set; }
        [Required]
        public StrucnaOsoba StrucnaOsoba { get; set; }
        #endregion

        public Zahtjev() { }

        public Zahtjev(Korisnik korisnik)
        {
            Korisnik = korisnik;
        }
    }
}
