using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Imunizacija21.Data;
using Imunizacija21.Models;

namespace Imunizacija21.Controllers
{
    public class FAQController : Controller
    {
        /*private readonly DataContext _context;*/

        public List<Tuple<String, String>> FAQ = new List<Tuple<String, String>>()
        {
            new Tuple<string, string>("1.Da li su i koje vakcine sigurne za osobe iznad 65 godina?", "Sve vakcine koje se koriste u našoj regiji su odobrene za upotrebu i kod osoba starijih od 65 godina. Dosadašnje iskustvo u primjeni Pfizer vakcine u Kantonu Sarajevo govori da starije osobe dobro podnose ovu vakcinu (reakcije na vakcinu kod starijih osoba su rjeđe nego kod mlađih)."),
            new Tuple<string, string>("2.Koja vakcina se preporučuje onima koji su preboljeli COVID-19?", "Osobe koje su preboljele COVID-19 mogu da prime bilo koju vakcinu protiv COVID-19."),
            new Tuple<string, string>("3.Koje su očekivane reakcije na vakcinu?", "To su reakcije koje nam u stvari govore da naš imuni sistem reaguje na vakcinu i stvara zaštitu od bolesti. Najčešće reakcije iz ove grupe su bol na mjestu uboda, povišena temperatura, groznica, bolovi u mišićima i/ili zglobovima, glavobolja, slabost ili malaksalost... Ovi simptomi najčešće traju jedan do tri dana i prolaze bez posljedica.U dosadašnjoj primjeni Sputnik V vakcine je primjećeno da se ove reakcije češće javljaju kod mlađih osoba, kao i kod onih koji su već bolovali od COVID-19 (i jedni i drugi imaju bržu i intenzivniju reakciju imunog sistema)."),
            new Tuple<string, string>("4.Ako sam trudna, da li se smijem vakcinisati?", "Da, ako ste trudni, možete primiti COVID-19 vakcinu."),
            new Tuple<string, string>("5.Koja vakcina (Sinopharm, Sputnik V, AstraZeneca, Pfizer) ima najviše prijavljenih neželjenih dejstava?", "Ovaj podatak je različit u različitim državama. Bitno je da većina reakcija nakon vakcinacije spada u očekivane reakcije i da su teže neželjene reakcije izuzetno rijetke."),
            new Tuple<string, string>("6.Mogu li vakcinisani prenositi virus?", "Do sada je istražen efekat vakcine na smanjenje mogućnosti obolijevanja, ali nije u potpunosti istražen efekat na prenošenje virusa (iako su pojedini proizvođači već objavili rezultate studija koje govore da njihove vakcine značajno smanjuju i mogućnost prenošenja virusa). Zbog toga ne možemo biti sigurni da osobe koje su vakcinisane i time zaštićene od obolijevanja, ukoliko dođu u kontakt sa zaraženom osobom, ne mogu da prenose virus na svojoj sluznici na druge osobe. Epidemiološke mjere prevencije poput nošenja maski i održavanja fizičke distance će biti neophodne još neko vrijeme, sve dok se vakcinacijom toliko ne poveća broj imunih osoba da dođe do značajnog smanjenja prenosa virusa u populaciji."),
            new Tuple<string, string>("7.Je li sigurno za moje dijete da dobije cjepivo prvotiv Covid-19?", "Da. Studije pokazuju da su cjepiva protiv COVID-19 sigurna i učinkovita. Kao i odrasli, i djeca mogu imati neke nuspojave nakon cijepljenja protiv COVID-19. Te nuspojave mogu utjecati na njihovu sposobnost obavljanja svakodnevnih aktivnosti, no trebale bi nestati za nekoliko dana."),
            new Tuple<string, string>("8.Koliko vremena nakon revakcinacije treba da prođe da bismo bili sigurni da je vakcina djelovala i da smo bezbjedni?", "Nakon vakcinacije je potrebno da prođe izvjestan period da se razvije imunitet. Ovaj period je različit za različite vrste vakcina, nakon nekih se imuni odgovor razvija brže, a nakon drugih nešto sporije. Za Sputnik V je potrebno da prođe 15 dana nakon druge doze vakcine da bismo smatrali da je vakcina ispoljila svoj efekat, dok je za vakcinu proizvođača Pfizer ovaj period 7 dana od druge doze."),
            new Tuple<string, string>("9.Ukoliko sam već imao Covid-19 i oporavio se, da li je i dalje potrebno da se vakcinišem?", "Da, trebali biste se cijepiti bez obzira da li ste već imali COVID-19. To je zato što stručnjaci još ne znaju koliko dugo ste zaštićeni od ponovne bolesti nakon oporavka od COVID-19. Čak i ako ste se već oporavili od COVID-19, moguće je, iako rijetko, da ponovo budete zaraženi virusom koji uzrokuje COVID-19.")
        };

        public FAQController(DataContext context)
        {
            
        }

        // GET: FAQ
        public IActionResult Index()
        {
            return View(FAQ);
        }
    }
}
