using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public enum LokalnaZdravstvenaUstanova
    {
        [Display(Name = "Vrazova")]
        VRAZOVA,
        [Display(Name = "Saraj polje")]
        SARAJ_POLJE,
        [Display(Name = "Omer Maslić")]
        OMER_MASLIC,
        [Display(Name = "Ilidža")]
        ILIDZA,
        [Display(Name = "Otoka")]
        OTOKA,
        [Display(Name = "Stari grad")]
        STARI_GRAD,
        [Display(Name = "Hadžići")]
        HADZICI,
        [Display(Name = "Trnovo")]
        TRNOVO,
        [Display(Name = "Ilijaš")]
        ILIJAS,
        [Display(Name = "Vogošća")]
        VOGOSCA
    }

    public class DatumIzProšlosti : RangeAttribute
    {
        public DatumIzProšlosti() : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Now.ToString())
        {
        }
    }
    public abstract class Osoba : IPrototip
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        //[Required(ErrorMessage = "Ime ne smije biti prazno.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Ime smije imati između 2 i 50 karaktera!")]
        [RegularExpression(@"[-|a-z|A-Z]*[a-z][A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova!")]
        public string Ime { get; set; }
        //[Required(ErrorMessage = "Prezime ne smije biti prazno.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Prezime smije imati između 2 i 50 karaktera!")]
        [RegularExpression(@"[-|a-z|A-Z]*[a-z][A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova!")]
        public string Prezime { get; set; }
        [DataType(DataType.Date)]
        //[Required]
        //[DatumIzProšlosti(ErrorMessage = "Datum dospjeća mora biti u prošlosti!")]
        public DateTime DatumRodjenja { get; set; }
        //[Required]
        [RegularExpression(@"[M|Z|Ž]", ErrorMessage = "Dozvoljeno je unos M i Z")]
        public string Spol { get; set; }
        //[Required]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Dozvoljen je unos samo brojeva")]
        [StringLength(maximumLength: 13, MinimumLength = 13, ErrorMessage = "JMBG mora imati tačno 13 brojeva!")]
        public string JMBG { get; set; }
        [Required]
        //[RegularExpression(@"[@]*", ErrorMessage = "Mora imati najmanje jedan '@'")]
        public string Email { get; set; }
        //[Required]
        [DisplayName("Broj telefona")]
        [RegularExpression(@"[0-9]*", ErrorMessage = "Dozvoljen je unos samo brojeva")]
        public string BrojTelefona { get; set; }
        [EnumDataType(typeof(LokalnaZdravstvenaUstanova))]
        [Required]
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova { get; set; }
        [NotMapped]
        public Dictionary<Osoba, string> PrimljenePoruke { get; set; }
        [NotMapped]
        public Dictionary<Osoba, string> PoslanePoruke { get; set; }
        public bool Ulogovan { get; set; }
        #endregion

        #region Constructors
        public Osoba() { }

        public Osoba(string ime, string prezime, string spol, string jmbg, string email, string brojTelefona, 
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova)
        {
            Ime = ime;
            Prezime = prezime;
            Spol = spol;
            JMBG = jmbg;
            Email = email;
            BrojTelefona = brojTelefona;
            LokalnaZdravstvenaUstanova = lokalnaZdravstvenaUstanova;
            Ulogovan = false;

            int dan = ((int)jmbg[0] - 48) * 10 + (int)jmbg[1] - 48;
            int mjesec = ((int)jmbg[2] - 48) * 10 + (int)jmbg[3] - 48;
            int godina = ((int)jmbg[4] - 48) * 100 + ((int)jmbg[5] - 48) * 10 + (int)jmbg[6] - 48;
            if ((int)jmbg[4]-48 > 6)
                godina = godina + 1000;
            else
                godina = godina + 2000;

            DatumRodjenja = new DateTime(godina, mjesec, dan);
        }
        #endregion

        #region Methods
        public IPrototip Clone()
        {
            return this;
        }
        public void DodajPoslanuPoruku(Osoba posiljalac, string sadrzajPoruke)
        {
            PoslanePoruke.Add(posiljalac, sadrzajPoruke);
        }
        public void DodajPrimljenuPoruku(Osoba primalac, string sadrzajPoruke)
        {
            PrimljenePoruke.Add(primalac, sadrzajPoruke);
        }
        #endregion
    }
}
