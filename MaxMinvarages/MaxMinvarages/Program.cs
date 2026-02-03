namespace MaxMinAvarages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list numbers");

            int[] numbers = new int[] { 2, 10, 15, 6, 8, 22, 3, 35, 67, 34 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            Console.WriteLine("----------------------");
            Console.WriteLine("sorteeri numbrid alates väiksemast suremani");

            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);    
            }
            Console.WriteLine("----------------------");
            Array.Reverse(numbers);
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine(Array.BinarySearch(numbers, 2));
            
        }
    }
}
