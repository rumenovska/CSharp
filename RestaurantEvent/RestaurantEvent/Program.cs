using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef c1 = new Chef();

            List<int> tables = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> tables1 = new List<int>() { 9, 10, 11, 12, 13, 14};
            List<int> tables2 = new List<int>() { 15,16,17 };

            Waiter w1 = new Waiter("Marija");
            Waiter w2 = new Waiter("Marko");
            Waiter w3 = new Waiter("Jane");
            w1.TablesNum = tables;
            w2.TablesNum = tables1;
            w3.TablesNum = tables2;

            c1.EventHandler += w1.ReadyForServe;
            c1.EventHandler += w2.ReadyForServe;
            c1.EventHandler += w3.ReadyForServe;

            c1.Ready(5);
            c1.Ready(17);
            c1.Ready(13);
            
            c1.Ready(20);

            Console.ReadLine();
        }
    }
}
