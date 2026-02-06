namespace arrayAnimalSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kasutame Array ja Sort-i");

            string[] animals = {"cat", "alligator", "fox",
                "donkey", "bear", "elephant", "goat" };

            //Array.Sort(animals);
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");

            Array.Sort(animals, 0, 3);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("----------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };

            int[] distinct = numbers.Distinct().ToArray();
            foreach (int num in distinct)
            {
                Console.WriteLine(num); 
            }
        }
    }
}
