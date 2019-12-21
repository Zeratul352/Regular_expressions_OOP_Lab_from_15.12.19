using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_expressions_OOP_Lab_from_15._12._19
{
    class Film_programm
    {
        private string name { get; }
        private string length { get; }
        private string language{ get; }
        private string country { get; }
        private string value { get; }
        private string category { get; }
        public Film_programm(string name1, string len, string lang, string coun, string val, string cat)
        {
            name = name1;
            length = len;
            language = lang;
            country = coun;
            value = val;
            category = cat;
        }
        public void Print()
        {
            string line = name + " " + length + " " + language + " " + country + " " + value + " " + category;
            Console.WriteLine(line);
        }
    }

    class Television_Show
    {
        private string name { get; }
        private string length { get; }
        private string   language { get; }
        private string    value { get; }
         private string   presenter { get; }
          private string  category { get; }
        public Television_Show(string name1, string len, string lang, string present, string val, string cat)
        {
            name = name1;
            length = len;
            language = lang;
            presenter = present;
            value = val;
            category = cat;
        }
        public void Print()
        {
            string line = name + " " + length + " " + language + " " + presenter + " " + value + " " + category;
            Console.WriteLine(line);
        }
    }

    class TV_News
    {
        private string name { get; }
        private string length { get; }
        private string language { get; }
        private string time { get; }
        public TV_News(string name1, string len, string lang, string time1)
        {
            name = name1;
            length = len;
            language = lang;
            time = time1;
        }
        public void Print()
        {
            string line = name + " " + length + " " + language + " " + time;
            Console.WriteLine(line);
        }
    }
}
