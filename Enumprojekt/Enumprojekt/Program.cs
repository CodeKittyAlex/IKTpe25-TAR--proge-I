namespace Enumprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            Console.WriteLine(Weekday.Friday);
            Console.WriteLine((int)Weekday.Friday);

            Console.WriteLine("------------");
            //(int) - castimine e teisendab teiseks andmetüübiks
            //juhul kui info võib kaduma minna ja ei näita soovitud tulemust
            Console.WriteLine((int)colours.green);
            Console.WriteLine(colours.green);
        }
        enum Weekday
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum colours
        {
            red = 3,
            green = 10, 
            blue = 13,
            yellow = 5,
            Black = 1,
            white = 8
        }
    }
}
