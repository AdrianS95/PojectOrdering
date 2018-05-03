using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wyłuskanie_danych
{
    class Program
    {
        public static void f1()
        {
            var url = "http://www.betexplorer.com/soccer/poland/ekstraklasa/results/";

            var web = new HtmlWeb();
            var doc = web.Load(url);

            var Bet = new List<Bet>();



            // Lettura delle righe
            var Rows = doc.DocumentNode.SelectNodes("//table");

            foreach (var row in Rows)
            {
                if (!row.GetAttributeValue("class", "").Contains("table-main js-tablebanner-t js-tablebanner-ntb"))
                {
                    if (string.IsNullOrEmpty(row.InnerText))
                        continue;

                    var rowBet = new Bet();
                    foreach (var node in row.ChildNodes)
                    {
                        var data_odd = node.GetAttributeValue("data-odd", "");

                        if (string.IsNullOrEmpty(data_odd))
                        {
                            if (node.GetAttributeValue("class", "").Contains("in-match"))
                            {
                                rowBet.Match = node.InnerText.Trim();
                                var matchTeam = rowBet.Match.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                                rowBet.Home = matchTeam[0];
                                rowBet.Host = matchTeam[1];
                            }


                            if (node.GetAttributeValue("class", "").Contains("h-text-center"))
                            {
                                rowBet.Result = node.InnerText.Trim();
                                var matchPoints = rowBet.Result.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                int help;
                                if (int.TryParse(matchPoints[0], out help))
                                {
                                    rowBet.HomePoints = help;
                                }
                                if (matchPoints.Length == 2 && int.TryParse(matchPoints[1], out help))
                                {
                                    rowBet.HostPoints = help;
                                }

                            }


                            if (node.GetAttributeValue("class", "").Contains("h-text-right h-text-no-wrap"))
                                rowBet.Date = node.InnerText.Trim();

                        }
                        else
                        {
                            rowBet.Odds.Add(data_odd);
                        }
                    }

                    if (!string.IsNullOrEmpty(rowBet.Match))
                        Bet.Add(rowBet);
                }
            }
        }

        static void Main(string[] args)
        {
            //var url = "http://html-agility-pack.net/";

            var url = "https://www.pyszne.pl/restauracja-34-120";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            var html =
         @"<TD class=texte width=""50%"">
			<DIV align=right>Name :<B> </B></DIV>
		</TD>
		<TD width=""50%"">
    		<INPUT class=box value=John maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Tony maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Jams maxLength=16 size=16 name=user_name>
		</TD>
		<TR vAlign=center>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(doc.Text);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("div class='restaurant grid'");
            //var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            foreach (var node in htmlNodes)
            {

                Console.WriteLine(node.Attributes["value"].Value);
            }

            Console.ReadKey();
        }
    }
}
