using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _4_home_work
{
    class Word
    {
        public static List<string> word;
        public void GetWord()
        {
            word = new List<string>();
            string results = ClearText.a;
            string pattern = @"([A-Za-z\d'-]+[$ \n.,!?])";
            string check = @"(^[A-Za-z])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(results);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string trim = match.Value;


                    if (Regex.IsMatch(trim, check) && (trim.Count() > 2))
                    {
                        word.Add(trim.Trim().Replace(" ", "").Replace("\n", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", ""));
                    }
                }
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}
