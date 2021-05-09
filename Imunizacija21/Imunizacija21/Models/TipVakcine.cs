using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class TipVakcine
    {
        public enum TipVakcineEnum
        {
            [Display(Name = "Pfizer")]
            PFIZER,
            [Display(Name = "AstraZeneca")]
            ASTRAZENECA,
            [Display(Name = "Sputnik V")]
            SPUTNIKV,
            [Display(Name = "Sinopharm")]
            SINOPHARM,
            [Display(Name = "Moderna")]
            MODERNA,
            [Display(Name = "Sinovac Biotech")]
            SINOVAC
        }

        public TipVakcineEnum tipVakcine { get; set; }

        public TipVakcine() { }
    }
}
