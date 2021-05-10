using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Vakcina
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [EnumDataType(typeof(TipVakcine))]
        [Required]
        public TipVakcine Tip;
        [Required]
        public double Efikanost { get; }
        [Required]
        public int BrojDostupnih { get; }
        [Required]
        public int BrojIskoristenih { get; }
        [Required]
        public string KratkiOpis { get; }
        [Required]
        public string Link { get; }
        #endregion

        public Vakcina() { }

        public Vakcina(TipVakcine tipVakcine)
        {
            Tip = tipVakcine;
        }
    }
}
