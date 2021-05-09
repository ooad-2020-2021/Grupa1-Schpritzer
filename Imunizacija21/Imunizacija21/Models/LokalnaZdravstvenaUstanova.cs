using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class LokalnaZdravstvenaUstanova
    {
        public enum LokalnaZdravstvenaUstanovaEnum
        {
            [Display(Name = "Vrazova")]
            VRAZOVA,
            [Display(Name = "Saraj polje")]
            SARAJ_POLJE,
            [Display(Name = "Omer Maslić")]
            OMER_MASLIC,
            [Display(Name = "Ilidža")]
            ILIDZA,
            [Display(Name = "Otoka")]
            OTOKA,
            [Display(Name = "Stari grad")]
            STARI_GRAD,
            [Display(Name = "Hadžići")]
            HADZICI,
            [Display(Name = "Trnovo")]
            TRNOVO,
            [Display(Name = "Ilijaš")]
            ILIJAS,
            [Display(Name = "Vogošća")]
            VOGOSCA
        }

        public LokalnaZdravstvenaUstanovaEnum lokalnaZdravstvenaUstanova { get; set; }

        public LokalnaZdravstvenaUstanova() { }
    }
}
