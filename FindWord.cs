using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace FindWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsivad sõna");
            Console.WriteLine("kasuta formaati: s--a. Kus - tähistab tundmatut tähtet");

            string choice = Console.ReadLine();

            WordFinder(choice);

        }

        private static void WordFinder(string choice)
        {
            Regex regularExp = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                    int LineNumber = 0;

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();

                        if (line.Length == choice.Length)
                        {
                            MatchCollection matchCollection = regularExp.Matches(line);

                            if (matchCollection.Count > 0)
                            {
                                LineNumber++;
                                Console.WriteLine(LineNumber + " " + line);
                            }

                        }
                    }
                    sr.Close();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("ei ole olemas sellise pikkusega sõna");
                Console.WriteLine(ex.Message);
                throw;
            }






        }   
    }
}
