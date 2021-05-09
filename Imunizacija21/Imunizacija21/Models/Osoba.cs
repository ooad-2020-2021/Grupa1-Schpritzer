using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public abstract class Osoba
    {
        #region Properties
        public string Ime { get; }
        public string Prezime { get; }
        public string Spol { get; }
        public string JMBG { get; }
        public string Email { get; }
        public List<string> BrojeviTelefona;
        public LokalnaZdravstvenaUstanova LokalnaZdravstvenaUstanova;
        #endregion

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
