using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Korisnik: Osoba
    {
        #region Properties
        [Required]
        public string ZdravstvenaKartica { get; }
        [Required]
        public CovidKarton CovidKarton { get; }
        [Required]
        public string Adresa;
        [Required]
        public Zanimanje Zanimanje;
        #endregion

        public Korisnik() { }

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
