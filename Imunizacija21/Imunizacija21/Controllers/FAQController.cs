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

        static List<Tuple<String, String>> FAQ = new List<Tuple<String, String>>()
        {
            new Tuple<string, string>("hihihi", "hahahahahaha")
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
