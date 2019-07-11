using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_home_work
{
    class ClearText
    {
        public static string a;
        public void GetClearString(string patch)
        {
            Repository repository = new Repository();
            repository.LoadString(patch);

            StringBuilder sb = new StringBuilder(Repository.line);
            a = sb
              .Replace("----", "").Replace("--", "-").Replace("....", ".").Replace('"', ' ').Replace("\n\n", "\n").Replace("\n\n\n", "\n").Replace("\n\n\n\n", "\n")
              .Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("_", "").Replace("  ", "")
              .Replace("=", "").Replace("+", "").Replace("|", "").Replace(":", " ").Replace(";", " ").Replace("\n\n\n\n\n", "\n").Replace("#", "")
              .Replace("<", "").Replace(">", "").Replace("=-", "").Replace("*", "").Replace(" '", " ").Replace("' ", " ").ToString();
            
        }

    }
}
