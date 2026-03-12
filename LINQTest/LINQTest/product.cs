using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Catagory { get; set; }
        public double Price { get; set; }
        public int amount { get; set; }
    }
    public class productData
    {
        public static readonly List<product> products = new List<product>
        {
            new product() { Id = 1, Name = "salt", Catagory ="spice", Price = 3.99, amount = 200 },
            new product() { Id = 2, Name = "peper", Catagory = "spice", Price = 4.99, amount = 180 },
            new product() { Id = 3, Name = "bread", Catagory = "food", Price = 3.99, amount = 20 },
            new product() { Id = 4, Name = "caviar", Catagory = "food", Price = 83.99, amount = 20 },
            new product() { Id = 5, Name = "beef", Catagory = "food", Price = 34.99, amount = 20 },
            new product() { Id = 6, Name = "pork", Catagory = "food", Price = 24.99, amount = 20 },
            new product() { Id = 7, Name = "rice", Catagory = "food", Price = 3.99, amount = 20 },
            new product() { Id = 8, Name = "water", Catagory = "bevarages", Price = 2.99, amount = 40 },
            new product() { Id = 9, Name = "wine", Catagory = "bevarage", Price = 129.99, amount = 5 },
            new product() { Id = 10, Name = "champane", Catagory = "bevarage", Price = 109.99, amount = 10 },
        };
    }
}
