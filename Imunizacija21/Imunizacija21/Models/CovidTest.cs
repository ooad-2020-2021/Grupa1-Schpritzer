using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public enum TipCovidTesta
    {
        [Display(Name = "Serološki")]
        SEROLOSKI,
        [Display(Name = "PCR")]
        PCR,
        [Display(Name = "Antigenski")]
        ANTIGENSKI
    }

    public class CovidTest
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [EnumDataType(typeof(TipCovidTesta))]
        [Required]
        public TipCovidTesta TipCovidTesta { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DatumTestiranja { get; set; }
        //[Required]
        public bool Rezultat { get; set; }
        [Required]
        public string OpisTesta { get; set; }
        [Required]
        public string Lokacija { get; set; }
        #endregion

        #region Constructors
        public CovidTest() { }

        public CovidTest(TipCovidTesta tipCovidTesta, DateTime datumTestiranja, string lokacija) {
            TipCovidTesta = tipCovidTesta;
            DatumTestiranja = datumTestiranja;
            OpisTesta = ""; //TODO
            Lokacija = lokacija;
        }
        #endregion

        #region Methods
        public Tuple<TipCovidTesta, DateTime, string> GetInfo()
        {
            return Tuple.Create(TipCovidTesta, DatumTestiranja, Lokacija);
        }
        #endregion
    }
}
