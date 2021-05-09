using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class CovidKarton
    {
        #region Properties
        public Vakcinacija Vakcinacija { get; }
        [NotMapped]
        public List<CovidTest> Testovi { get; }
        [NotMapped]
        public List<Bolest> Bolesti { get; }
        [NotMapped]
        public List<ZahtjevZaTestiranje> ZahtjeviZaTestiranje { get; }
        #endregion

        public CovidKarton() { }
    }
}
