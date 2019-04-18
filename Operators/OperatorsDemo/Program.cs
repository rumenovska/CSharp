using Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OperatorsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Milk", 5, 50);
            Product p2 = new Product("Bread", 2, 28);
            var p3 = p1 + p2;
            p3.Print();

            var p4 = p1 - p2;
            p4.Print();

            var p5 = p1 / p2;
            p5.Print();

            var p6 = p1 * p2;
            p6.Print();
            var p7 = p1 % p2;
            p7.Print();

            Console.WriteLine(!p1);
            var p8 = p1 + 7;
            p8.Print();

            p2++.Print();
            p1--.Print();
            Console.ReadLine();
        }
    }
}
