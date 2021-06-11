using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models {
    public class StrucnaOsoba : Osoba {
        #region Properties
        [NotMapped]
        //[Required]
        public List<Zahtjev> Zahtjevi;
        [NotMapped]
        public IZahtjeviSort Strategija;

        #endregion

        #region Constructors
        public StrucnaOsoba() { }

        public StrucnaOsoba(string ime, string prezime, string spol, string jmbg, string email, string brojTelefona,
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova) : base(ime, prezime, spol, jmbg, email, brojTelefona, lokalnaZdravstvenaUstanova) {

        }
        #endregion

        //#region Methods
        //public void odobriIZakaziTest(ZahtjevZaTestiranje zahtjevZaTestiranje, DateTime datumTestiranja, string lokacija) {
        //    CovidTest covidTest = new CovidTest(zahtjevZaTestiranje.TipCovidTesta, datumTestiranja, lokacija);
        //    zahtjevZaTestiranje.Korisnik.CovidKarton.DodajTest(covidTest);
        //    zahtjevZaTestiranje.Korisnik.CovidKarton.ZahtjeviZaTestiranje.Remove(zahtjevZaTestiranje); //TODO da li brisati
        //    //Zahtjevi.Remove(zahtjevZaTestiranje); //TODO PROVJERITI DA LI SE NALAZI ZAHTJEVZT U ZAHTJEVIMA
        //    Zahtjevi.Find(z => z.ID == zahtjevZaTestiranje.ID).OdobrenZahtjev = true;
        //    //TODO dodaj notifikaciju da je odobrena(u kontroleru)
        //}

        //public void odbijTest(ZahtjevZaTestiranje zahtjevZaTestiranje) {
        //    Zahtjevi.Find(z => z.ID == zahtjevZaTestiranje.ID).OdobrenZahtjev = false;
        //    zahtjevZaTestiranje.Korisnik.CovidKarton.ZahtjeviZaTestiranje.Find(z => z.ID == zahtjevZaTestiranje.ID).OdobrenZahtjev = false;
        //    //TODO dodaj notifikaciju da je odbijena(u kontroleru)
        //}

        //public void odobriVakcinaciju(ZahtjevZaVakcinaciju zahtjevZaVakcinaciju, TipVakcine tip, DateTime datumVakcinisanja, string lokacija) {
        //    Vakcina vakcina = new Vakcina(tip);
        //    Vakcinacija vakcinacija = new Vakcinacija(vakcina, this);
        //    Zahtjevi.Find(z => z.ID == zahtjevZaVakcinaciju.ID).OdobrenZahtjev = true;
        //    zahtjevZaVakcinaciju.Korisnik.CovidKarton.ZahtjevZaVakcinaciju = null;
        //    vakcinacija.ZakaziDozu(datumVakcinisanja, lokacija);
        //    zahtjevZaVakcinaciju.Korisnik.CovidKarton.Vakcinacija = vakcinacija;
        //    //TODO dodaj notifikaciju da je odobrena(u kontroleru)
        //}

        //public void odbijVakcinaciju(ZahtjevZaVakcinaciju zahtjevZaVakcinaciju) {
        //    Zahtjevi.Find(z => z.ID == zahtjevZaVakcinaciju.ID).OdobrenZahtjev = false;
        //    zahtjevZaVakcinaciju.Korisnik.CovidKarton.ZahtjevZaVakcinaciju = null;
        //    //TODO dodaj notifikaciju da je odbijena(u kontroleru)
        //}

        //public void dodajZahtjev(Zahtjev zahtjev) {
        //    Zahtjevi.Add(zahtjev);
        //}

        //public void obrisiZahtjev(Zahtjev zahtjev) {
        //    Zahtjevi.Remove(zahtjev);
        //}

        //public void PromijeniStrategiju(IZahtjeviSort strategija)
        //{
        //    Strategija = strategija;
        //}
        //public void Sortiraj()
        //{
        //    Strategija.SortirajZahtjeve(Zahtjevi);
        //}
        //#endregion
    }
}
