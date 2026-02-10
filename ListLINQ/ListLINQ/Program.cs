namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list and LINQ");


            IList <Person> person = new List<Person>();
            {
                new Person() { Id = 1, Name = "juku", Age = 10 };
                new Person() { Id = 2, Name = "juhan", Age = 11 };
                new Person() { Id = 3, Name = "maali", Age = 10 };
                new Person() { Id = 4, Name = "aksel", Age = 11 };
            };

            var persons = from p in person
                         select new
                         {
                             Id = p.Id,
                             Name = p.Name,
                             Age = p.Age,
                         };
            foreach (var item in persons)
            {
                Console.WriteLine("id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("-------------------------");
            var result = person
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                });

            foreach (var item in person)
            {
                Console.WriteLine("id on " + item.Id + " ja nimi on " + item.Name);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("gruppide kaupa sorteerimine");

            var groupBy = person
                .GroupBy(x => x.Age);

            foreach (var item in groupBy)
            {
                Console.WriteLine("vanuse grupp on: {0}", item.Key);
            }
        }
    }
}
