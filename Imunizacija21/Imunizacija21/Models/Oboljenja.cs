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
        public VrsteOboljenja Tip { get; set; }
        [Required]
        public string Ustanova { get; set; }
        [Required]
        public string OpisDijagnoze { get; set; }
        #endregion

        #region Constructors
        public Oboljenja() { }

        public Oboljenja(string doktor, DateTime datumDijagnoze, VrsteOboljenja vrsteOboljenja): base(doktor, datumDijagnoze)
        {
            Tip = vrsteOboljenja;
        }
        #endregion

        #region Methods
        public override string getTip()
        {
            return "oboljenje";
        }
        #endregion
    }
}
