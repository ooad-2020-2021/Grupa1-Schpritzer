using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class CovidKarton
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public Vakcinacija Vakcinacija { get; }
        [NotMapped]
        [Required]
        public List<CovidTest> Testovi { get; }
        [NotMapped]
        [Required]
        public List<Bolest> Bolesti { get; }
        [NotMapped]
        [Required]
        public List<ZahtjevZaTestiranje> ZahtjeviZaTestiranje { get; }
        #endregion

        public CovidKarton() { }
    }
}
