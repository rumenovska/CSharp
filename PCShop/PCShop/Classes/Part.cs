using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Part
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Part()
        {

        }
        public Part(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
