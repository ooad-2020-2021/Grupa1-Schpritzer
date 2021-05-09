using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public class VrsteOboljenja
    {
        public enum VrsteOboljenjaEnum
        {
            [Display(Name = "Bronhitis")]
            BRONHITIS,
            [Display(Name = "Astma")]
            ASTMA,
            [Display(Name = "Dijabetes")]
            DIJABETES,
            [Display(Name = "Migrena")]
            MIGRENA,
            [Display(Name = "Artritis")]
            ARTRITIS,
            [Display(Name = "Tuberkuloza")]
            TUBERKULOZA,
            [Display(Name = "Gripa")]
            GRIPA,
            [Display(Name = "Rak")]
            RAK
        }

        public VrsteOboljenjaEnum vrsteOboljenja { get; set; }

        public VrsteOboljenja() { }
    }
}
