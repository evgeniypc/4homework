using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_home_work
{
    class Punctuation

    {
        public static List<string> Punct;
        public void GetSenteces()
        {
            Punct = new List<string>();
            string results = ClearText.a;
            string pattern = @"([,.!?])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(results);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Punct.Add(match.Value);
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}