using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyłuskanie_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.pyszne.pl/restauracja-34-120";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            Console.WriteLine(doc.Text);






            Console.ReadKey();
        }
    }
}
