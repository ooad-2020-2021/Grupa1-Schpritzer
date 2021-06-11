using System;
using System.Collections.Generic;
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
    public abstract class Osoba : IPrototip
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Spol { get; set; }
        //[Required]
        public string JMBG { get; set; }
        [Required]
        public string Email { get; set; }
        //[Required]
        public string BrojTelefona { get; set; }
        [EnumDataType(typeof(LokalnaZdravstvenaUstanova))]
        [Required]
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova { get; set; }
        [NotMapped]
        public Dictionary<Osoba, string> PrimljenePoruke { get; set; }
        [NotMapped]
        public Dictionary<Osoba, string> PoslanePoruke { get; set; }
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
