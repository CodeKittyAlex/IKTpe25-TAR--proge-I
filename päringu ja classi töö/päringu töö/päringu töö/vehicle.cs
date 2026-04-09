using System;
using System.Collections.Generic;
using System.Text;

namespace päringu_töö
{
     public class Vehicle
    {
        public string name;
        public int speed;
        public virtual void describe()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
    class Car : Vehicle
    {
        public override void describe()
        {
            Console.WriteLine($"This is a car Name: {name} Speed: {speed}");
        }
    }
    class Bicycle : Vehicle
    {
        public override void describe()
        {
            Console.WriteLine($"This is a bicycle Name: {name} Speed: {speed}");
        }
    }
}
