using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public sealed class StatistikaKSSingleton
    {
        private static readonly StatistikaKSSingleton instance = new StatistikaKSSingleton();
        #region Properties
        public static int BrojZarazenih;
        public static int BrojOporavljenih;
        public static int BrojUmrlih;
        public static int BrojTestiranih;
        public static int BrojZarazenihDanas;
        public static int BrojOporavljenihDanas;
        public static int BrojUmrlihDanas;
        public static int BrojTestiranihDanas;
        public static int BrojVakcinisanih;
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
