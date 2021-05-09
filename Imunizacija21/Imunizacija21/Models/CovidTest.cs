using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class CovidTest
    {
        #region Properties
        [EnumDataType(typeof(TipCovidTesta))]
        [Required]
        public TipCovidTesta TipCovidTesta { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DatumTestiranja { get; set; }
        [Required]
        public bool Rezultat { get; set; }
        [Required]
        public string OpisTesta { get; }
        [Required]
        public string Lokacija { get; }
        #endregion
    }
}
