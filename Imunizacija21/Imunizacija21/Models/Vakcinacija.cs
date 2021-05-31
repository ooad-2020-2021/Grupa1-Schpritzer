using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models {
    public class Vakcinacija {

        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        public Vakcina Vakcina { get; set; }
        public Doza PrvaDoza { get; set; }
        public Doza DrugaDoza { get; set; }
        [NotMapped]
        public StrucnaOsoba StrucnaOsoba { get; set; }
        #endregion

        #region Constructors

        public Vakcinacija() { }

        public Vakcinacija(Vakcina vakcina, StrucnaOsoba strucnaOsoba) {
            Vakcina = vakcina;
            StrucnaOsoba = strucnaOsoba;
            PrvaDoza = null;
            DrugaDoza = null;
        }

        #endregion

        #region Methods

        public void ZakaziDozu(DateTime datum, string lokacija) {
            if(PrvaDoza == null) {
                PrvaDoza = new Doza(datum, lokacija, false);
            } else {
                DrugaDoza = new Doza(datum, lokacija, false);
            }
        }

        public void SetPrimioDozu() {
            if(PrvaDoza == null)
                throw new FieldAccessException("Prva doza nije definisana");
            if(PrvaDoza.Primljena == false)
                PrvaDoza.Primljena = true;
            else
                DrugaDoza.Primljena = true;
        }

        public string GetStatusDoze(int i) {
            if(i == 1) {
                if(PrvaDoza == null)
                    throw new FieldAccessException("Prva doza nije definisana");
                if(PrvaDoza.Primljena)
                    return "Primljena";
                else return "Zakazana";
            } else if(i == 2) {
                if(DrugaDoza == null)
                    throw new FieldAccessException("Druga doza nije definisana");
                if(DrugaDoza.Primljena)
                    return "Primljena";
                else return "Zakazana";
            } else
                throw new ArgumentException("Ne postoji doza " + i);
        }

        #endregion

    }
}
