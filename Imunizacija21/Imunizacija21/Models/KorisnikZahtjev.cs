using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class KorisnikZahtjev
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        public string Spol { get; set; }
        public string JMBG { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        [EnumDataType(typeof(LokalnaZdravstvenaUstanova))]
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova { get; set; }
        public string ZdravstvenaKartica { get; set; }
        public string Adresa { get; set; }
        public Zanimanje Zanimanje { get; set; }


        public int IDZahtjeva { get; set; }
        public int KorisnikID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatumZahtjeva { get; set; }
        public bool OdobrenZahtjev { get; set; }
        public int StrucnaOsobaID { get; set; }
        public int CovidKartonID { get; set; }


        public string Razlozi { get; set; }
        public string Opis { get; set; }
        public TipCovidTesta TipCovidTesta { get; set; }

        [DataType(DataType.Date)]
        public DateTime ZakazaniDatum { get; set; }
        public LokalnaZdravstvenaUstanova Lokacija { get; set; }

        public KorisnikZahtjev() { }

        public KorisnikZahtjev(int id, string ime, string prezime, DateTime datumRodjenja, string spol, string jmbg, string email, string brojTelefona, LokalnaZdravstvenaUstanova lzu, string kartica, string adresa, 
            Zanimanje z, int IDz, int korisnikID, DateTime datumZahtjeva, bool odobren, int strucna, int covidkartonID, string razlozi, string opis, TipCovidTesta tipCovidTesta, DateTime zakazaniDatum, LokalnaZdravstvenaUstanova lokacija)
        {
            ID = id;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Spol = spol;
            JMBG = jmbg;
            Email = email;
            BrojTelefona = brojTelefona;
            LokalnaZdravstvenaUstanova = lzu;
            ZdravstvenaKartica = kartica;
            Adresa = adresa;
            Zanimanje = z;
            IDZahtjeva = IDz;
            KorisnikID = korisnikID;
            DatumZahtjeva = datumZahtjeva;
            OdobrenZahtjev = odobren;
            StrucnaOsobaID = strucna;
            CovidKartonID = covidkartonID;
            Razlozi = razlozi;
            Opis = opis;
            TipCovidTesta = tipCovidTesta;
            ZakazaniDatum = zakazaniDatum;
            Lokacija = lokacija;
        }
    }
}
