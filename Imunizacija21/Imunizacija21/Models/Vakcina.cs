using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Vakcina
    {
        #region Properties
        public TipVakcine Tip;
        public double Efikanost { get; }
        public int BrojDostupnih { get; }
        public int BrojIskoristenih { get; }
        public string KratkiOpis { get; }
        public string Link { get; }
        #endregion

        public Vakcina(TipVakcine tipVakcine)
        {
            Tip = tipVakcine;
        }
    }
}
