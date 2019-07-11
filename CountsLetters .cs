using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_home_work
{
    class CountsLetters
    {
        Repository repository = new Repository();
        public int valCheck;
        public string keyCheck;
        public void GetMostCommonLetter()
        {
            Dictionary<char, int> CommonLetter = new Dictionary<char, int>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                CommonLetter.Add(i, ClearText.a.Count(x => x == i));
            }
            var val = CommonLetter.Values.Max();
            foreach (var item in CommonLetter)
            {
                if (item.Value == val)
                {
                    valCheck = item.Value;
                    keyCheck = item.Key.ToString();
                }
            }
            repository.SaveSentences(keyCheck, valCheck, "The most common letter");
        }
        int check = 0;
        int check2 = 0;
        string Senta;
        public void GetLongestSentence()
        {
            check = 0;
            Senta = "";
            foreach (var item in Sentences.Sent)
            {
                if (item.Count() >= check)
                {
                    check = item.Count();
                    Senta = item;
                }

            }
            repository.SaveSentences(Senta, check, "Longest sentence by character count");
        }
        public void GetLongestSentenceWords()
        {

            // string[] data;
            check = 0;

            Senta = "";
            foreach (var item in Sentences.Sent)
            {
                string[] data;
                data = item.Split(' ');
                check2 = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    check2 = check2 + 1;
                }

                if (check2 >= check)
                {
                    check = check2;
                    Senta = item;
                }

            }
            repository.SaveSentences(Senta, check, "Word sentence shortest");
        }
    }
}

