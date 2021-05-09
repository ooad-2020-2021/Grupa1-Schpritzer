using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class TipCovidTesta
    {
        public enum TipCovidTestaEnum
        {
            [Display(Name = "Serološki")]
            SEROLOSKI,
            [Display(Name = "PCR")]
            PCR,
            [Display(Name = "Antigenski")]
            ANTIGENSKI
        }

        public TipCovidTestaEnum tipCovidTesta { get; set; }

        public TipCovidTesta() { }
    }
}
