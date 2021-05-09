using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Korisnik: Osoba
    {
        #region Properties
        public string ZdravstvenaKartica { get; }
        public CovidKarton CovidKarton { get; }
        public string Adresa;
        public Zanimanje Zanimanje;
        #endregion

        public Korisnik(string ime, string prezime, string spol, string jmbg, string email, List<String> brojeviTelefona, 
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova, string zdravstvenaKartica, CovidKarton covidKarton, 
            string adresa, Zanimanje zanimanje): base(ime, prezime, spol, jmbg, email, brojeviTelefona, lokalnaZdravstvenaUstanova)
        {
            ZdravstvenaKartica = zdravstvenaKartica;
            CovidKarton = covidKarton;
            Adresa = adresa;
            Zanimanje = zanimanje;
        }
    }
}
