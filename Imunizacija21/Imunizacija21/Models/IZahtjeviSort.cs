using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imunizacija21.Models
{
    public interface IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi);
    }
    //TODO provjeriti da li povratni tip mora biti List<Zahtjev>
    class PoZanimanjuSort : IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi)
        {
            throw new NotImplementedException();
        }
    }

    /*class PoPrezimenuSort : IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi)
        {
            zahtjevi.OrderByDescending(z => z.Korisnik.Prezime).ToList();
        }
    }

    class PoStarostiSort : IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi)
        {
            zahtjevi.OrderByDescending(z => z.Korisnik.DatumRodjenja).ToList();
        }
    }*/

    class PoPrioritetuSort : IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi)
        {
            throw new NotImplementedException();
        }
    }

    class PoDatumuSort : IZahtjeviSort
    {
        public void SortirajZahtjeve(List<Zahtjev> zahtjevi)
        {
            zahtjevi.OrderByDescending(z => z.DatumZahtjeva).ToList();
        }
    }
}
