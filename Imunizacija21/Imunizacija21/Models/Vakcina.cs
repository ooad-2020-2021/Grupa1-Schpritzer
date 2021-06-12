using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models {
    public enum TipVakcine {
        [Display(Name = "Pfizer")]
        PFIZER,
        [Display(Name = "AstraZeneca")]
        ASTRAZENECA,
        [Display(Name = "Sputnik V")]
        SPUTNIKV,
        [Display(Name = "Sinopharm")]
        SINOPHARM,
        [Display(Name = "Moderna")]
        MODERNA,
        [Display(Name = "Sinovac Biotech")]
        SINOVAC
    }

    public class Vakcina {

        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [EnumDataType(typeof(TipVakcine))]
        [Required]
        public TipVakcine Tip { get; set; }
        public double Efikanost { get; set; }
        [Required]
        public int BrojDostupnih { get; private set; }
        [Required]
        public int BrojIskoristenih { get; private set; }
        public string KratkiOpis { get; private set; }
        public string Link { get; private set; }
        public int VrijemeMedjuDozama { get; private set; } //Dani
        #endregion

        #region Constructors
        public Vakcina() { }

        public Vakcina(TipVakcine tipVakcine) {
            Tip = tipVakcine;
            ID = (int)Tip;
            postaviInfoVakcina();
        }

        #endregion

        #region Metode
        private void postaviInfoVakcina() {
            switch(Tip) {
                case TipVakcine.PFIZER:
                    Efikanost = 0.91;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "Pfizer–BioNTech COVID-19 je mRNA vakcina. Osobe starije od 12 godina mogu da prime ovu vakcinu. Razvila ju je firma BioNTech iz Njemacke u saradnji sa americkom kompanijom Pfzier.";
                    Link = "https://www.cdc.gov/coronavirus/2019-ncov/vaccines/different-vaccines/Pfizer-BioNTech.html";
                    VrijemeMedjuDozama = 42;
                    break;
                case TipVakcine.MODERNA:
                    Efikanost = 0.94;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "Moderna COVID-19 je mRNA vakcina. Osobe starije od 18 godina mogu da prime ovu vakcinu. Razvio ju je National Institute of Allergy and Infectious Diseases u SAD";
                    Link = "https://www.cdc.gov/coronavirus/2019-ncov/vaccines/different-vaccines/Moderna.html";
                    VrijemeMedjuDozama = 28;
                    break;
                case TipVakcine.SPUTNIKV:
                    Efikanost = 0.92;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "Sputnik V je adenovirusna vakcina. Osobe starije od 18 godina mogu da prime ovu vakcinu. Razvilo ju je Ministarstvo Zdravstva u Rusiji";
                    Link = "https://www.precisionvaccinations.com/vaccines/sputnik-v-vaccine";
                    VrijemeMedjuDozama = 21;
                    break;
                case TipVakcine.ASTRAZENECA:
                    Efikanost = 0.75;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "AstraZeneca je adenovirusna vakcina. Osobe starije od 16 godina mogu da prime ovu vakcinu.Razvila ju je švedsko-britanska kompanija AstraZeneca sa Univerzitetom Oksford.";
                    Link = "https://www.astrazeneca.com/covid-19.html";
                    VrijemeMedjuDozama = 84;
                    break;
                case TipVakcine.SINOPHARM:
                    Efikanost = 0.73;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "Sinopharm COVID-19 mRNA vakcina. Osobe starije od 3 godine mogu da prime ovu vakcinu. Razvijena je od strane kinerske firme China National Medicines Corporation National Medicines Corporation";
                    Link = "http://www.sinopharm.com/en/s/1395-4173-38923.html";
                    VrijemeMedjuDozama = 28;
                    break;
                case TipVakcine.SINOVAC:
                    Efikanost = 0.5;
                    //TODO spojiti sa bazom i odatle uzimati BrojDostupnih i BrojIskoristenih
                    KratkiOpis = "Sinovac COVID-19 je mRNA vakcina. Osobe starije od 3 godine mogu da prime ovu vakcinu. Razvijena je od strane kineske firme Sinovac Biotech Ltd.";
                    Link = "http://www.sinovac.com/";
                    VrijemeMedjuDozama = 14;
                    break;
            }
        }

        #endregion

    }
}
