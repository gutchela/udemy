using cap08.Entities;
using System;

namespace cap08
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = Entities.Enums.OrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            string txt = Entities.Enums.OrderStatus.PendingPayment.ToString();
            Console.WriteLine();
            Console.WriteLine(txt);
        }
    }
}
