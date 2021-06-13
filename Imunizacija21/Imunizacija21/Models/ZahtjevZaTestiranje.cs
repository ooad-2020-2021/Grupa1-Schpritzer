﻿using System;
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
        public string Razlozi { get; set; }
        //[Required]
        public string Opis { get; set; }
        [EnumDataType(typeof(TipCovidTesta))]
        [Required]
        public TipCovidTesta TipCovidTesta { get; set; }
        #endregion

        #region Constructors
        public ZahtjevZaTestiranje() {
        }

        public ZahtjevZaTestiranje(int korisnikID, string razlozi, string opis, TipCovidTesta tip): base(korisnikID)
        {
            Razlozi = razlozi;
            Opis = opis;
            TipCovidTesta = tip;
        }
        #endregion
    }
}
