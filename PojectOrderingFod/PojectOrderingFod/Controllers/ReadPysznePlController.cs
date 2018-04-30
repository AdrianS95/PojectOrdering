using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using PojectOrderingFod.Models;

namespace PojectOrderingFod.Controllers
{
    public class ReadPysznePlController : Controller
    {
        private IEnumerable<ReadSite> TakeRssItems()
        {
            var url = "https://www.pyszne.pl/restauracja-34-120";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            return null;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}