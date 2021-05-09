using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Zanimanje
    {
        public enum ZanimanjeEnum
        {
            [Display(Name = "Medicinski radnik")]
            MEDICINSKI_RADNIK,
            [Display(Name = "Penzioner")]
            PENZIONER,
            [Display(Name = "Policajac")]
            POLICAJAC,
            [Display(Name = "Ugostitelj")]
            UGOSTITELJ,
            [Display(Name = "Trgovac")]
            TRGOVAC,
            [Display(Name = "Prosvjetni radnik")]
            PROSVJETNI_RADNIK,
            [Display(Name = "Privrednik")]
            PRIVREDNIK,
            [Display(Name = "Nezaposlen")]
            NEZAPOSLEN,
            [Display(Name = "Student")]
            STUDENT,
            [Display(Name = "Ucenik")]
            UCENIK
        }

        public ZanimanjeEnum zanimanje { get; set; }

        public Zanimanje() { }
    }
}
