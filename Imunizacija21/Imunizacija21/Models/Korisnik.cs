using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public enum Zanimanje
    {
        [Display(Name = "Medicinski radnik")]
        MEDICINSKI_RADNIK,
        [Display(Name = "Penzioner")]
        PENZIONER,
        [Display(Name = "Policajac")]
        POLICAJAC,
        [Display(Name = "Ugostitelj")]
        UGOSTITELJ,
        [Display(Name = "Trgovac")]
        TRGOVAC,
        [Display(Name = "Prosvjetni radnik")]
        PROSVJETNI_RADNIK,
        [Display(Name = "Privrednik")]
        PRIVREDNIK,
        [Display(Name = "Nezaposlen")]
        NEZAPOSLEN,
        [Display(Name = "Student")]
        STUDENT,
        [Display(Name = "Ucenik")]
        UCENIK
    }

    public class Korisnik : Osoba
    {
        #region Properties
        [Required]
        public string ZdravstvenaKartica { get; set; }
        [Required]
        public int CovidKartonID { get; set; }
        [Required]
        [DisplayName("Adresa stanovanja")]
        public string Adresa { get; set; }
        [Required]
        public Zanimanje Zanimanje { get; set; }
        #endregion


        #region Constructors
        public Korisnik() { }

        public Korisnik(string ime, string prezime, string spol, string jmbg, string email, string brojTelefona, 
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova, string zdravstvenaKartica, int covidKartonID, 
            string adresa, Zanimanje zanimanje): base(ime, prezime, spol, jmbg, email, brojTelefona, lokalnaZdravstvenaUstanova)
        {
            ZdravstvenaKartica = zdravstvenaKartica;
            CovidKartonID = covidKartonID;
            Adresa = adresa;
            Zanimanje = zanimanje;
        }
        #endregion
    }
}
