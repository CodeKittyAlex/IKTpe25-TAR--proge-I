

namespace dictsionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary ja foreach");

            // var on muutuja

            var domains = new Dictionary<string, string>()
            {
                {"fi", "Finland"},
                {"se", "Sweden"},
                {"de", "Germany"},
                {"fr", "France"},
                {"es", "Spain"},
            };
            //kasutate foreachi ja juurde tuleb lisada kolmas rida
            int i = 0;
            foreach (var item in domains)
            {
                i++;
                Console.WriteLine($"{item.Key} - {item.Value} - {i}");


            }
        }
    }
}
