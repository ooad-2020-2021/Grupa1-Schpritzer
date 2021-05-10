using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public sealed class StatistikaKSSingleton
    {
        private static readonly StatistikaKSSingleton instance = new StatistikaKSSingleton();
        #region Properties
        [Required]
        public static int BrojZarazenih;
        [Required]
        public static int BrojOporavljenih;
        [Required]
        public static int BrojUmrlih;
        [Required]
        public static int BrojTestiranih;
        [Required]
        public static int BrojZarazenihDanas;
        [Required]
        public static int BrojOporavljenihDanas;
        [Required]
        public static int BrojUmrlihDanas;
        [Required]
        public static int BrojTestiranihDanas;
        [Required]
        public static int BrojVakcinisanih;
        [Required]
        public static int BrojStanovnika;
        #endregion

        static StatistikaKSSingleton() { }
        private StatistikaKSSingleton() { }

        public static StatistikaKSSingleton Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
