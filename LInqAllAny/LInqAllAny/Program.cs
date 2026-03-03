namespace LInqAllAny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello LINQ");
            Console.WriteLine("1. all");
            Console.WriteLine("2. any");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AllLinq();
                    break;

                case 2:
                    AnyLinq();
                    break;

                case 3:
                    JoinLINQ();
                    break;

                default:
                    Console.WriteLine("err");
                    break;
            }
        }
        public static void AllLinq()
        {
            bool results = StudentData.students.All(x => x.age > 12 && x.age < 20);

            Console.WriteLine(results);
        }
        public static void AnyLinq()
        {
            bool results = StudentData.students.Any(x => x.age > 12 && x.age < 20);

            Console.WriteLine(results);
        }
        public static void JoinLINQ()
        {
            var hell = StudentData.students
                .Join
                (
                standartData.standarts, 
                Student => Student.StandardId,
                standartId => standartId.StandartId,
                (students, standartId) => new
                {
                    name = students.Name,
                    standartId = standartId.StandartId,
                }
                );


            foreach (var item in hell)
            {
                Console.WriteLine("{0} - {1}", item.name, item.standartId);
            }
        }
    }
}
