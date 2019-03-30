using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public class Order
    {
        private List<OrderLine> _orderLines = new List<OrderLine>();

        public void AddOrderLine(string name, int price, int quantity )
        {
            OrderLine line = new OrderLine();
            line.Name = name;
            line.Price = price;
            line.Quantity = quantity;
            _orderLines.Add(line);
        }

        
        private class OrderLine
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
            
        }

    }
}
