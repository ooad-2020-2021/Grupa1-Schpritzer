﻿using System;
using System.Collections.Generic;
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
