using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Alergija: Bolest
    {
        #region Properties
        [EnumDataType(typeof(TipAlergije))]
        [Required]
        public TipAlergije Tip { get; }
        #endregion

        public Alergija() { }

        public Alergija(string doktor, DateTime datumDijagnoze, TipAlergije tip) : base(doktor, datumDijagnoze)
        {
            Tip = tip;
        }
    }
}
