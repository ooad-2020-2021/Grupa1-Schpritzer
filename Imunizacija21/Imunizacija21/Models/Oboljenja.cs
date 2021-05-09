using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Oboljenja: Bolest
    {
        #region Properties
        public VrsteOboljenja Tip { get; }
        public string Ustanova;
        public string OpisDijagnoze;
        #endregion

        public Oboljenja(string doktor, DateTime datumDijagnoze, VrsteOboljenja vrsteOboljenja): base(doktor, datumDijagnoze)
        {
            Tip = vrsteOboljenja;
        }
    }
}
