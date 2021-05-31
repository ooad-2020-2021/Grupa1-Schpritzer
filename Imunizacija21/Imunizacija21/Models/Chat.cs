using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Chat : IChatMedijator
    {
        #region Properties
        [NotMapped]
        public List<Osoba> Korisnici { get; set; }
        #endregion

        #region Constructors
        public Chat() { }
        #endregion

        #region Methods
        public bool ProvjeriSadrzajPoruke(string Sadrzaj)
        {
            throw new NotImplementedException();
        }

        public void PosaljiPoruku(Osoba posiljalac, Osoba primalac, string sadrzajPoruke)
        {
            posiljalac.DodajPoslanuPoruku(primalac, sadrzajPoruke);
            primalac.DodajPrimljenuPoruku(posiljalac, sadrzajPoruke);
        }
        #endregion
    }
}
