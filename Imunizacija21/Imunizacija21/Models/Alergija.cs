using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public enum TipAlergije
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

    public class Alergija: Bolest
    {
        #region Properties
        [EnumDataType(typeof(TipAlergije))]
        [Required]
        public TipAlergije Tip { get; set; }
        #endregion

        #region Constructors
        public Alergija() { }

        public Alergija(string doktor, DateTime datumDijagnoze, TipAlergije tip) : base(doktor, datumDijagnoze)
        {
            Tip = tip;
        }
        #endregion

        #region Methods
        public override string getTip()
        {
            return "alergija";
        }
        #endregion
    }
}
