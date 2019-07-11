using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repository = new Repository();
            int input = 1;
            while (input != 7)
            {
                Console.WriteLine(new string('-', 10));
                Console.WriteLine("Working with strings");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("1 - Parse the document - Sentences");
                Console.WriteLine("2 - Parse the document - Word");
                Console.WriteLine("3 - Parse the document - Punctuation");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("4 - Print words in alphabetical order to another file, indicating the number of uses of this word");          
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("5 - Longest sentence by character count");
                Console.WriteLine("  - Word sentence shortest");
                Console.WriteLine("  - The most common letter");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("6 - New functionality(Using FileSystemWatcher and Multithreading)");
                Console.WriteLine(new string('-', 5));
                Console.WriteLine("7 - Exit");

                ClearText clear = new ClearText();
                clear.GetClearString("read.txt");

                int.TryParse(Console.ReadLine(), out input);
                switch (input)
                {
                    case 1:
                        {
                            Sentences sente = new Sentences();
                            clear.GetClearString("read.txt");
                            sente.GetSenteces();
                            Console.WriteLine("File uploaded, cleaned and splited on sentences");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Word word = new Word();
                            clear.GetClearString("read.txt");
                            word.GetWord();
                            Console.WriteLine("File uploaded, cleaned and splited on words");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            Punctuation Punct = new Punctuation();
                            Punct.GetSenteces();
                            Console.WriteLine("File uploaded, cleaned and splited on Punctuations");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Calculations are made. Wait....");
                            Word word = new Word();
                            word.GetWord();
                            AlphabetWords alphabet = new AlphabetWords();
                            alphabet.GetWordsAlphabet();
                            Console.WriteLine("Write to file made. Finish.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Calculations are made. Wait....");
                            CountsLetters Letter = new CountsLetters();
                            Sentences sente = new Sentences();
                            sente.GetSenteces();
                            Letter.GetLongestSentence();
                            Letter.GetLongestSentenceWords();
                            Letter.GetMostCommonLetter();
                            Console.WriteLine("Write to file made. Finish.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            repository.watch();
                            Console.Clear();
                            Console.WriteLine(new string('-', 20));
                            Console.WriteLine("To write files in the folder 'DOC' you need to copy there the document with the file extension  - '.txt'");
                            Console.WriteLine(new string('-', 20));         
                            Console.WriteLine("Exit to Main menu, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("The program will now exit. ");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You have entered incorrect data, try again");
                            Console.WriteLine("To continue, click - ENTER");
                            Console.ReadKey();
                            break;
                        }
                }
                Console.Clear();
            }
        }
    }
}
