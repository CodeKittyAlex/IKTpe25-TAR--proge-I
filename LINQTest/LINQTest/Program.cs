namespace LINQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ meetodid");
            Console.WriteLine("1. where");
            Console.WriteLine("2. select");
            Console.WriteLine("3. skip");
            Console.WriteLine("4. sort");
            Console.WriteLine("5. takewhile");
            Console.WriteLine("6. firstor");
            Console.WriteLine("7. math");
            Console.WriteLine("8. allany");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sixty();
                    break;
                case 2:
                    catSer();
                    break;
                case 3:
                    skip();
                    break;
                case 4:
                    sort();
                    break;
                case 5:
                    takewhile();
                    break;
                case 6:
                    firstor();
                    break;
                case 7:
                    math();
                    break;
                case 8:
                    allany();
                    break;
                default:
                    Console.WriteLine("err");
                    break;
            }

        }
        public static void sixty()
        {
            var sixty = productData.products.Where(x => x.Price > 60.00);

            foreach (var x in sixty)
            {
                Console.WriteLine(x.Price);
            }
        }
        public static void catSer()
        {
            var cat = productData.products.Select(x => x.Catagory);

            foreach (var x in cat)
            {
                Console.WriteLine(x);
            }
        }
        public static void skip()
        {
            var skip = productData.products.OrderBy(x => x.Price).Skip(4);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Price);
            }
        }
        public static void sort()
        {
            var sort = clientData.clients.OrderBy(x => x.City).ThenBy(x => x.Name);

            foreach (var item in sort)
            {
                Console.WriteLine(item.Name + "" + item.City);
            }
        }
        public static void takewhile()
        {
            var skipWhile = productData.products.TakeWhile(x => x.Price > 90);

            foreach (var item in skipWhile)
            {
                Console.WriteLine(item.Price);
            }
        }
        public static void firstor()
        {
            var first = productData.products.FirstOrDefault(x => x.Catagory == "food");
            Console.WriteLine(first);
        }
        public static void math()
        {
            var avr = productData.products.Average(x => x.Price);
            Console.WriteLine("keskminehind"+avr);
            var expensive = productData.products.Max(x => x.Price);
            Console.WriteLine("max"+expensive);
            var count = productData.products.Count(x => x.Catagory == "food");
        }
        public static void allany()
        {
            bool result = productData.products.Any(x => x.Price >500);
            Console.WriteLine(result);
        }
    }
}


