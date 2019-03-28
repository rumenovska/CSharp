using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class ElectronicCar: ICar
    {
        public string MotorNumber { get; set; }


        public void Refuel()
        {
            Console.WriteLine("Charging Batery");
        }
    }
}
