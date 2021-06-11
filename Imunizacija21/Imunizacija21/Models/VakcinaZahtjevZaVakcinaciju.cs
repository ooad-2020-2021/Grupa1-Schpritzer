using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class VakcinaZahtjevZaVakcinaciju
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        /*[Required]
        public Vakcina Vakcina { get; set; }*/
        [Required]
        public int VakcinaID { get; set; }
        /*[Required]
        public ZahtjevZaVakcinaciju ZahtjevZaVakcinaciju { get; set; }*/
        [Required]
        public int ZahtjevZaVakcinacijuID { get; set; }
        #endregion

        #region Constructors
        public VakcinaZahtjevZaVakcinaciju() { }
        #endregion
    }
}
