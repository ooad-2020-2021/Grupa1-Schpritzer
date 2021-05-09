using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public abstract class Bolest
    {
        #region Properties
        [Required]
        public string Doktor;
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumDijagnoze;
        #endregion

        public Bolest(string doktor, DateTime datumDijagnoze)
        {
            Doktor = doktor;
            DatumDijagnoze = datumDijagnoze;
        }
    }
}
