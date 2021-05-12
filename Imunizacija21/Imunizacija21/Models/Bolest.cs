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
        [Key]
        public int ID { get; set; }
        [Required]
        public string Doktor;
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumDijagnoze;
        #endregion

        #region Constructors
        public Bolest() { }

        public Bolest(string doktor, DateTime datumDijagnoze)
        {
            Doktor = doktor;
            DatumDijagnoze = datumDijagnoze;
        }
        #endregion

        #region Methods
        public abstract string getTip();
        #endregion
    }
}
