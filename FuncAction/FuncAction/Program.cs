using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> IsPalindrome = text => {
                string reverse = String.Join("", text.Reverse());
                if(text.ToLower() == reverse.ToLower())
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
            };
            Action<string> WordCount = text => { Console.WriteLine($"{text.Split().Length}"); };
            Action<string> ReverseText = text => {
                string reverse = String.Join("", text.Reverse());
                Console.WriteLine($"{reverse}");
            };

            IsPalindrome += WordCount;
            IsPalindrome += ReverseText;
            IsPalindrome("Anna");
            IsPalindrome("How are you?");
            Console.ReadLine();

        }
    }
}
