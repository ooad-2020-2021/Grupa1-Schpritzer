using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class StrucnaOsoba: Osoba
    {
        #region Properties
        [NotMapped]
        //[Required]
        public List<Zahtjev> Zahtjevi;

        #endregion

        #region Constructors
        public StrucnaOsoba() { }

        public StrucnaOsoba(string ime, string prezime, string spol, string jmbg, string email, List<String> brojeviTelefona,
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova) : base(ime, prezime, spol, jmbg, email, brojeviTelefona, lokalnaZdravstvenaUstanova)
        {

        }
        #endregion

        #region Methods
        public CovidTest odobriIZakaziTest(ZahtjevZaTestiranje zahtjevZaTestiranje)
        {
            CovidTest covidTest = new CovidTest();
            zahtjevZaTestiranje.OdobrenZahtjev = true;
            return covidTest;
        }

        public Vakcinacija odobriVakcinaciju()
        {
            Vakcinacija vakcinacija = new Vakcinacija();
            return vakcinacija;
        }

        public void dodajZahtjev(Zahtjev zahtjev)
        {
          
        }

        public void obrisiZahtjev(Zahtjev zahtjev)
        {

        }
        #endregion
    }
}
