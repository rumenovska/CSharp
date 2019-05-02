using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter message");
            string message = Console.ReadLine();

            
            SendMessage(name, message);
            PrintMessage(name, message);

            Console.Read();

        }

        static void PrintMessage(string name, string message)
        {
            Console.WriteLine("Sending message..");
            Thread.Sleep(4000);
            Console.WriteLine($"{message} ({name})");
        }

        static async Task SendMessage(string name, string message)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Sending email..");
                Thread.Sleep(5000);
                Console.WriteLine($"Message: {message} from {name} was send via email.");
            });
        }
             
    }
}
