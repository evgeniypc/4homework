using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _4_home_work
{
    class Repository : IText
    {
        const string readPath = @"read.txt";
        const string writePath = @"write.txt";
        const string writePathWord = @"writeWord.txt";
        const string History = @"history.txt";
        public DateTime dateTime;
        public string name;
        public static string line;

        #region New functionality (Using FileSystemWatcher and Multithreading):

        private string path = @"Doc";
        public void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.Filter = "*.txt";
            watcher.Created += OnChanged;
            watcher.EnableRaisingEvents = true;
        }
        public void OnChanged(object source, FileSystemEventArgs e)
        {
            name = e.Name;
            string path = @"Doc\" + name;

            ClearText clear = new ClearText();
            clear.GetClearString(path);

            Word word = new Word();
            word.GetWord();

            AlphabetWords alphabet = new AlphabetWords();
            alphabet.GetWordsAlphabet();

            DirectoryInfo dir = new DirectoryInfo(path);
            dateTime = dir.LastWriteTime;

            // Отдельный Поток для записи истории
            Thread Thr = new Thread(OnHistoryChange);
            Thr.Start();

        }
        public void OnHistoryChange()
        {
            SaveHistory(dateTime, AlphabetWords.countWord, name); ;
        }
        public void SaveHistory(object date, object count, object name)
        {
            using (StreamWriter sw = new StreamWriter(History, true))
            {
                sw.WriteLine(new string('-', 20));
                sw.WriteLine($"Date added document          - {DateTime.Now} ");
                sw.WriteLine($"Last date chenged document   - {date}  ");
                sw.WriteLine($"Name file                    - {name}  ");
                sw.WriteLine($"Count words was added        - {count}  ");
                sw.WriteLine(new string('-', 20));
            }
            Console.Clear();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("The information is recorded in the files - 'writeWord' and 'history'");//Информация записывается в файлы - «writeWord» и «history»
            Console.WriteLine("Check it out");//Проверьте это
            Console.WriteLine("Exit to Main menu, click - ENTER");
            Console.ReadKey();
        }
        #endregion
        public void LoadString(string patch)
        {
            using (StreamReader file = new StreamReader(patch))
            {
                line = file.ReadToEnd();
            }
        }
        public void SaveWord(string str, int count)
        {
            using (StreamWriter sw = new StreamWriter(writePathWord, true))
            {
                sw.WriteLine($"{str} - {count}");
            }
        }
        public void SaveSentences(string str, int count, string massage)
        {
            using (StreamWriter sw = new StreamWriter(writePath, true))
            {
                sw.WriteLine(massage);
                sw.WriteLine($"String - {str}");
                sw.WriteLine($"Count  - {count}");
            }
        }
    }
}

