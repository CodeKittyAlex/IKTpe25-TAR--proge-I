using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public class client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class clientData
    {
        public static readonly List<client> clients = new List<client>
        {
            new client() { Id = 1, Name = "bob", City = "Amsterdam" },
            new client() { Id = 2, Name = "jim", City = "New York" },
            new client() { Id = 3, Name = "dwight", City = "Amsterdam" },
            new client() { Id = 4, Name = "lary", City = "New York" },
            new client() { Id = 5, Name = "ben", City = "California" },
        };
    }
}
