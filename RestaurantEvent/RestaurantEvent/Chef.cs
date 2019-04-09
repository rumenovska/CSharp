using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEvent
{
    public delegate void DelegateCook(int tableNum);

    public class Chef
    {
        public event DelegateCook EventHandler;

        public void Ready(int tableNum)
        {
            Console.WriteLine($"Food for table {tableNum} is ready!");

            EventHandler?.Invoke(tableNum);
        }
    }
}
