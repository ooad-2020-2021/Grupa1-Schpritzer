using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class ZahtjevFacade
    {
        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        public ZahtjevZaTestiranje ZahtjevZaTestiranje { get; set; }
        public ZahtjevZaVakcinaciju ZahtjevZaVakcinaciju { get; set; }
        #endregion

        #region Constructors
        public ZahtjevFacade() { }
        #endregion

        #region Methods
        public DateTime GetDatumZahtjevaTestiranja()
        {
            return ZahtjevZaTestiranje.DatumZahtjeva;
        }
        public DateTime GetDatumZahtjevaVakcinisanja()
        {
            return ZahtjevZaVakcinaciju.DatumZahtjeva;
        }
        public bool? IsOdobrenZahtjevZaTestiranje()
        {
            return ZahtjevZaTestiranje.OdobrenZahtjev;
        }
        public bool? IsOdobrenZahtjevZaVakcinaciju()
        {
            return ZahtjevZaVakcinaciju.OdobrenZahtjev;
        }
        public void SetOdobrenZahtjevZaTestiranje(bool odobren)
        {
            ZahtjevZaTestiranje.OdobrenZahtjev = odobren;
        }
        public void SetOdobrenZahtjevZaVakcinaciju(bool odobren)
        {
            ZahtjevZaVakcinaciju.OdobrenZahtjev = odobren;
        }
        public StrucnaOsoba GetStrucnaOsobaTestiranja()
        {
            return ZahtjevZaTestiranje.StrucnaOsoba;
        }
        public StrucnaOsoba GetStrucnaOsobaVakcinisanje()
        {
            return ZahtjevZaVakcinaciju.StrucnaOsoba;
        }
        public void SetStrucnaOsobaTestiranja(StrucnaOsoba strucnaOsoba)
        {
            ZahtjevZaTestiranje.StrucnaOsoba = strucnaOsoba;
        }
        public void SetStrucnaOsobaVakcinacije(StrucnaOsoba strucnaOsoba)
        {
            ZahtjevZaVakcinaciju.StrucnaOsoba = strucnaOsoba;
        }
        public List<string> GetRazloziTestiranja()
        {
            return ZahtjevZaTestiranje.Razlozi;
        }
        public string GetOpisTestiranja()
        {
            return ZahtjevZaTestiranje.Opis;
        }
        public List<Vakcina> GetOdabraneVakcine()
        {
            return ZahtjevZaVakcinaciju.OdabraneVakcine;
        }
        #endregion
    }
}
