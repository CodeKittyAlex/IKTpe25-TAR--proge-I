using päringu_töö;

namespace Päringu_Töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Vehicle vehicle2 = new Car();
            vehicle2.name = "BMW";
            vehicle2.speed = 120;
            Vehicle vehicle3 = new Bicycle();
            vehicle3.name = "Trek";
            vehicle3.speed = 20;

            vehicle.describe();
            vehicle2.describe();
            vehicle3.describe();
        }
    }
}