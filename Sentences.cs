using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _4_home_work
{
    class Sentences
    {
        public static List<string> Sent;
        public void GetSenteces()
        {
            Sent = new List<string>();
            string results = ClearText.a;
            string pattern = @"([A-Za-z\d ,'-]+[\n.!?])";
            string check = @"(^[A-Za-z])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(results);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    match.Value.Trim();
                    if (Regex.IsMatch(match.Value, check) && (match.Value.Count() > 2))
                    {
                        Sent.Add(match.Value.Trim().Replace("/n", ""));
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
