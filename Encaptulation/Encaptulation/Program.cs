using EncaptulationServises;

namespace Encaptulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student student = new Student();

            //Student2 student2 = new Student2();

            student.Id = 101;
            student.Name = "name";
            student.email = "test@test.com";

            Console.WriteLine("id = " + student.Id);
            Console.WriteLine("name = " + student.Name);
            Console.WriteLine("email = " + student.email);

            //prodectedStudent prodectedStudent = new prodectedStudent();
            //prodectedStudent DoSomething();
            // ei saa kasutad kuna asub teises klassis, aga samas projektis
            Console.WriteLine("------------------------------------");
            Program program = new Program();
            program.DoSomethingInProgramClass();
            
            Console.WriteLine("---PrivateProtectedInProgramClass---");
            Program pp = new Program();
            Console.WriteLine(pp.PrivateProtectedInProgramClass =
                "PrivateProtectedInProgramClass");

            var privateProdectedStudent = new privateProtectedStudent();
            //kui asub samas classis, siis saab kasutada,
            //aga teises classis olevat ei saa
            //privateProdectedStudent.PrivateProtectedStudent1 = "asdasd";

            Console.WriteLine("----Sealed Class------");

            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "test";
            sc.Email = "sealedTest@Sealed.com";

            //$ - string format
            Console.WriteLine($"id on {sc.Id}, name on {sc.Name} ja" +
                $"Email on {sc.Email}");

        }
        protected void DoSomethingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }
        private protected string PrivateProtectedInProgramClass;
    }

    
}
