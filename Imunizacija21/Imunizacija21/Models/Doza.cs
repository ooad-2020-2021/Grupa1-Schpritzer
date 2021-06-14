using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models {

    public class Doza {

        #region Properties
        [Key]
        [Required]
        public int ID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Datum { get; set; }
        public bool Primljena { get; set; }
        public string Lokacija { get; set; }

        #endregion

        #region Constructor
        public Doza() { }

        public Doza(DateTime datum, string lokacija, bool primljen) {
            Datum = datum;
            Lokacija = lokacija;
            Primljena = primljen;
        }
        #endregion
    }
}
