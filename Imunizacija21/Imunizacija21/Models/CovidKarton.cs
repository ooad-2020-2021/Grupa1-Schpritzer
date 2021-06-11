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
        /*[Required]
        public Vakcinacija Vakcinacija { get; set; }*/
        [Required]
        public int VakcinacijaID { get; set; }
        [NotMapped]
        [Required]
        public List<CovidTest> Testovi { get; set; }
        [NotMapped]
        [Required]
        public List<Bolest> Bolesti { get; set; }
        /*[NotMapped]
        [Required]
        public ZahtjevZaVakcinaciju? ZahtjevZaVakcinaciju { get; set; }*/
        [NotMapped]
        [Required]
        public List<ZahtjevZaTestiranje> ZahtjeviZaTestiranje { get; set; }
        #endregion

        #region Constructors
        public CovidKarton(/*int vakcinacijaID*/) {
            /*VakcinacijaID = vakcinacijaID;*/
            Testovi = new List<CovidTest>();
            Bolesti = new List<Bolest>();
            ZahtjeviZaTestiranje = new List<ZahtjevZaTestiranje>();
        }
        #endregion

        #region Methods
        public void DodajZahtjevZaTestiranje(ZahtjevZaTestiranje zahtjev)
        {
            ZahtjeviZaTestiranje.Add(zahtjev);
        }
        public void DodajTest(CovidTest covidTest)
        {
            Testovi.Add(covidTest);
        }
        public void DodajBolesti(Bolest bolest)
        {
            Bolesti.Add(bolest);
        }
        #endregion 
    }
}
