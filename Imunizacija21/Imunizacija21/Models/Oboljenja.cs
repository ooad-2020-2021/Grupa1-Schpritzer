using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
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
