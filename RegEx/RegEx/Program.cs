using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("teeme regular EXpresion harjutuse");

            string word = "#CD5C5Cx";
            Console.WriteLine("hex code: " + word);
            Console.WriteLine("kas on regex: " + RegExTest(word));
        }

        public static bool RegExTest(string word)
        {
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}
