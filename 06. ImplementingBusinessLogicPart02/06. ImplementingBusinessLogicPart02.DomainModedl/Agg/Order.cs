using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ImplementingBusinessLogicPart02.DomainModedl.Agg
{
    public interface IDomainEvent
    {

    }

    public class OrderCreated : IDomainEvent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
    }
    internal class Order
    {
        public List<IDomainEvent> Events { get; private set; } = new List<IDomainEvent>();
        public int Id { get; private set; }
        public DateTime Date { get; private set; }

        public int TotalPrice { get; private set; }
        public List<OrderLine> OrderLines { get; private set; } = new List<OrderLine>();

        public Order(int id)
        {
            Id = id;
            Date = DateTime.Now;
            TotalPrice = 0;
            OrderCreated created = new OrderCreated
            {
                Id = Id,
                Date = Date,
                TotalPrice = TotalPrice,
            };
            Events.Add(created);
        }
        public void AddLine(int count, int price, string productName)
        {
            //check if exist productName 
            //add Count

            OrderLines.Add(new OrderLine(OrderLines.Count() + 1, count, price, productName));

            TotalPrice = OrderLines.Sum(c => c.Price * c.Count);
        }
    }
    public class OrderLine
    {
        public int Id { get; private set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string ProductName { get; set; }
        public OrderLine(int id, int count, int price, string productName)
        {
            Id = id;
            Count = count;
            Price = price;
            ProductName = productName;
        }
    }
}
