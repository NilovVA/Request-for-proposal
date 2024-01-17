using System;
using System.Linq;


   
    namespace Request_for_proposal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '.', '?', '!' });
            string[] wordsToMatch1 = Console.ReadLine().Split();
            string[] wordsToMatch2 = Console.ReadLine().Split();
            var sentenceQuery = from sentence in sentences
                                let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                                                        StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(wordsToMatch1).Count() == wordsToMatch1.Count() && w.Distinct().Intersect(wordsToMatch2).Count() == wordsToMatch2.Count()
                                select sentence;

            foreach (string str in sentenceQuery)
            {
                Console.WriteLine(str);
            }
        }
    }
}