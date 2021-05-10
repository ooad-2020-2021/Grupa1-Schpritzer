using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Vakcinacija
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        //[Required]
        public Vakcina Vakcina;
        //[Required]
        [NotMapped]
        public Tuple<DateTime, string, bool> PrvaDoza; // DateTime - kad je primio, string - lokacija gdje je primio, bool - da li je primio prvu dozu
        //[Required]
        [NotMapped]
        public Tuple<DateTime, string, bool> DrugaDoza; // DateTime - kad je primio, string - lokacija gdje je primio, bool - da li je primio drugu dozu 
        //[Required]
        public StrucnaOsoba StrucnaOsoba;
        #endregion

        public Vakcinacija() { }

        public Vakcinacija(Vakcina vakcina, StrucnaOsoba strucnaOsoba)
        {
            Vakcina = vakcina;
            StrucnaOsoba = strucnaOsoba;
        }
    }
}
