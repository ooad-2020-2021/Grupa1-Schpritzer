using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class Vakcinacija
    {
        #region Properties
        public Vakcina Vakcina;
        public Tuple<DateTime, string, bool> PrvaDoza; // DateTime - kad je primio, string - lokacija gdje je primio, bool - da li je primio prvu dozu
        public Tuple<DateTime, string, bool> DrugaDoza; // DateTime - kad je primio, string - lokacija gdje je primio, bool - da li je primio drugu dozu 
        public StrucnaOsoba StrucnaOsoba;
        #endregion

        public Vakcinacija(Vakcina vakcina, StrucnaOsoba strucnaOsoba)
        {
            Vakcina = vakcina;
            StrucnaOsoba = strucnaOsoba;
        }
    }
}
