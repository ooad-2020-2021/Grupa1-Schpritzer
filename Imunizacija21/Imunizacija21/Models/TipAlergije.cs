using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class TipAlergije
    {
        public enum TipAlergijeEnum
        {
            [Display(Name = "Pencilin")]
            PENCILIN,
            [Display(Name = "Polen")]
            POLEN,
            [Display(Name = "Prašina")]
            PRASINA,
            [Display(Name = "Kikiriki")]
            KIKIRIKI,
            [Display(Name = "Gluten")]
            GLUTEN,
            [Display(Name = "Jagode")]
            JAGODE
        }


        public TipAlergijeEnum tipAlergije { get; set; }

        public TipAlergije() { }
    }
}
