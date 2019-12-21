using System;
using System.IO;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expressions_OOP_Lab_from_15._12._19
{
    class Operator
    {
       
        public void GetPrograms()
        {
            List<string> Fields = new List<string> { @"\b(Film|film|F|Movie)\b", @"\b(News|news)\b", @"\b(TV show|show|Show)\b",
            @"\""[A-Z][\w\s]*\""", @"((\b\d{1,2}:\d{1,2}:\d{1,2})|((?(\d{1,3})\d{1,3}\sh|\s)\s(?(\d{1,3})\d{1,3}\smin|\s)\s(?(\d{1,3})\d{1,3}\ssec|)))\b",
            @"\b(UA|RU|EN|BY|KZ|FR)\b", @"((\d{1,6}\$)|(\d{1,6}\.\d{1,2}[$\u20AC])|(\(d{1,3}\.\dM\s\d{1,3}\.\dK\s\d{1,3}[$\u20AC])|(\d{1,3}\s\d{1,3}[$\u20AC]))",
            @"\b(Ukraine|Russia|England|Belarus|Kazakhstan|France)\b", @"((18\+)|(6\-16)|(0\+)|(G)|(PG)|(PG\-13)|R|(NC\-17)|(6\+))",
            @"\b(morning|evening|afternoon|prime)\b", @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b", @"\b(main|repeat)\b"};
            
            StreamReader sr = new StreamReader(@"C: \Users\Andrey\source\repos\Regular_expressions_OOP_Lab_from_15.12.19\Regular_expressions_OOP_Lab_from_15.12.19\Zayavki.txt");
            string myline;
            while((myline = sr.ReadLine()) != null)
            {
                var mymap = new Dictionary<string, string>();
                foreach(string regex in Fields){
                    Match match = Regex.Match(myline, regex);
                    mymap.Add(regex, "");
                    if (match.Success)
                    {
                        mymap[regex] = match.ToString();
                    }
                }
                if(mymap[Fields[0]] != "")
                {
                    if((mymap[Fields[3]] != "") && (mymap[Fields[4]] != "") && (mymap[Fields[5]] != "") && (mymap[Fields[6]] != "") && (mymap[Fields[7]] != "") && (mymap[Fields[8]] != ""))
                    {
                        Film_programm film = new Film_programm(mymap[Fields[3]], mymap[Fields[4]], mymap[Fields[5]], mymap[Fields[6]], mymap[Fields[7]], mymap[Fields[8]]);
                        film.Print();
                    }
                }else if(mymap[Fields[2]] != "")
                {
                    if((mymap[Fields[3]] != "") && (mymap[Fields[4]] != "") && (mymap[Fields[5]] != "") && (mymap[Fields[6]] != "") && (mymap[Fields[10]] != "") && (mymap[Fields[11]] != ""))
                    {
                        Television_Show show = new Television_Show(mymap[Fields[3]], mymap[Fields[4]], mymap[Fields[5]], mymap[Fields[6]], mymap[Fields[10]], mymap[Fields[11]]);
                        show.Print();
                    }
                }
                else if (mymap[Fields[1]] != "")
                {
                    if ((mymap[Fields[3]] != "") && (mymap[Fields[4]] != "") && (mymap[Fields[5]] != "") && (mymap[Fields[9]] != ""))
                    {
                        TV_News news = new TV_News(mymap[Fields[3]], mymap[Fields[4]], mymap[Fields[5]], mymap[Fields[9]]);
                        news.Print();
                    }
                }
                
            }
        }
    }
}
