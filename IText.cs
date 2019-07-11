using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_home_work
{
    interface IText
    {
        void LoadString(string patch);
        void SaveWord(string str, int count);
        void SaveSentences(string str, int count, string massage);
    }
}

    
