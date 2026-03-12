using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public class orders
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

    }
    public class ordersData
    {
        public static readonly List<orders> orders = new List<orders>
        {
            new orders() { Id = 1, ClientId = 1, ProductId = 1, Amount = 5 },
            new orders() { Id = 2, ClientId = 1, ProductId = 2, Amount = 5 },
            new orders() { Id = 3, ClientId = 2, ProductId = 3, Amount = 5 },
            new orders() { Id = 4, ClientId = 2, ProductId = 4, Amount = 5 },
            new orders() { Id = 5, ClientId = 3, ProductId = 5, Amount = 5 },
            new orders() { Id = 6, ClientId = 3, ProductId = 6, Amount = 5 },
            new orders() { Id = 7, ClientId = 4, ProductId = 7, Amount = 5 },
            new orders() { Id = 8, ClientId = 4, ProductId = 8, Amount = 5 },
            new orders() { Id = 9, ClientId = 5, ProductId = 9, Amount = 5 },
            new orders() { Id = 10, ClientId = 5, ProductId = 10, Amount = 5 },
        };
    }
}
