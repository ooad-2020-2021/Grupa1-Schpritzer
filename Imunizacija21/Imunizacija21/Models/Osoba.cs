using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public abstract class Osoba
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ime { get; }
        [Required]
        public string Prezime { get; }
        [Required]
        public string Spol { get; }
        //[Required]
        public string JMBG { get; }
        [Required]
        public string Email { get; }
        [NotMapped]
        //[Required]
        public List<string> BrojeviTelefona;
        [EnumDataType(typeof(LokalnaZdravstvenaUstanova))]
        [Required]
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova;
        #endregion

        public Osoba() { }

        public Osoba(string ime, string prezime, string spol, string jmbg, string email, List<String> brojeviTelefona, 
            LokalnaZdravstvenaUstanova lokalnaZdravstvenaUstanova)
        {
            Ime = ime;
            Prezime = prezime;
            Spol = spol;
            JMBG = jmbg;
            Email = email;
            BrojeviTelefona = brojeviTelefona;
            LokalnaZdravstvenaUstanova = lokalnaZdravstvenaUstanova;
        }
    }
}
