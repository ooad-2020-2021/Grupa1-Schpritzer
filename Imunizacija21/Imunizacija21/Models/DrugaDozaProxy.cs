using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class DrugaDozaProxy : IDrugaDozaProxy
    {
        #region Properties
        [Required]
        public bool Odobrena { get; set; }
        #endregion

        public DrugaDozaProxy(Doza prvaDoza) 
        {
            Odobrena = prvaDoza.Primljena;
        }
        public bool OdobrenaDrugaDoza()
        {
            return Odobrena;
        }
    }
}
