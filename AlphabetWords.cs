using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_home_work
{
    class AlphabetWords
    {
        public static int countWord = 0;

        public void GetWordsAlphabet()
        {
            Repository repository = new Repository();
            Sentences sentences = new Sentences();
            sentences.GetSenteces();
            if (Word.word.Count > 0)
            {
                Word.word.Sort();
                var dis = Word.word.Distinct();
                countWord = dis.Count();
                foreach (var str in dis)
                {
                    int count = Word.word.Count(x => x == str);
                    repository.SaveWord(str, count);
                }
            }
        }
    }
}
