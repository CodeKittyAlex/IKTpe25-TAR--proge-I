using LINQ.modles;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kutsume esile LINQ läbi switchi");
            Console.WriteLine("vali vastav link numbriga");
            Console.WriteLine("1. Where");
            Console.WriteLine("2. where ja otsib nime järgi");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    WhereLINQ();
                    break;
                case 2:
                    whereByNameLINQ();
                    break;

                default:
                    break;
            }

            WhereLINQ();
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleData.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void whereByNameLINQ()
        {
            Console.WriteLine("kirjuta inimese nimi");
            string name = Console.ReadLine();

            var peopleName = PeopleData.peoples
                .Where(user => user.Name == name);

            foreach (var item in peopleName)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
    }
}
