using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public enum VrsteOboljenja
    {
        [Display(Name = "Bronhitis")]
        BRONHITIS,
        [Display(Name = "Astma")]
        ASTMA,
        [Display(Name = "Dijabetes")]
        DIJABETES,
        [Display(Name = "Migrena")]
        MIGRENA,
        [Display(Name = "Artritis")]
        ARTRITIS,
        [Display(Name = "Tuberkuloza")]
        TUBERKULOZA,
        [Display(Name = "Gripa")]
        GRIPA,
        [Display(Name = "Rak")]
        RAK
    }

    public class Oboljenja: Bolest
    {
        #region Properties
        [Required]
        [EnumDataType(typeof(VrsteOboljenja))]
        public VrsteOboljenja Tip { get; }
        [Required]
        public string Ustanova;
        [Required]
        public string OpisDijagnoze;
        #endregion

        public Oboljenja() { }

        public Oboljenja(string doktor, DateTime datumDijagnoze, VrsteOboljenja vrsteOboljenja): base(doktor, datumDijagnoze)
        {
            Tip = vrsteOboljenja;
        }
    }
}
