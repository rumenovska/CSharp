using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEvent
{
    public class Waiter
    {
        public string Name { get; set; }
        public List<int> TablesNum { get; set; }
       
        public Waiter(string name)
        {
            this.Name = name;
            this.TablesNum = new List<int>();

        }

        public void ReadyForServe(int tableNum)
        {
            foreach(var table in TablesNum)
            {
                if(table == tableNum)
                {
                    Console.WriteLine($"Waiter: {Name} served table {tableNum}!");
                }
            }
        }
    }
}
