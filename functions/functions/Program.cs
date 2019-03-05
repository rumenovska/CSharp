using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Test Finkcii
			//Console.Write("Enter number a: ");
			//double a = Convert.ToDouble(Console.ReadLine());
			//Console.Write("Enter number b: ");
			//double b;
			//double.TryParse(Console.ReadLine(), out b);
			//Console.WriteLine($"Sum is {Sum(a, b)}");

			//Console.WriteLine("---------------------------");
			//Console.Write("Enter number x: ");
			//double x = Convert.ToDouble(Console.ReadLine());
			//Console.Write("Enter number y: ");
			//double y = double.Parse(Console.ReadLine());

			//Console.WriteLine($"Subtract is {Subtract(x, y)}");

			//Console.WriteLine("---------------------------");
			//Console.Write("Enter number a1: ");
			//double a1 = Convert.ToDouble(Console.ReadLine());
			//Console.Write("Enter number b1: ");
			//double b1 = double.Parse(Console.ReadLine());

			//Console.WriteLine($" Multiplication is {Multiplication(a1, b1)}");

			//Console.WriteLine("---------------------------");
			//Console.Write("Enter number x1: ");
			//double x1 = Convert.ToDouble(Console.ReadLine());
			//Console.Write("Enter number y1: ");
			//double y1 = double.Parse(Console.ReadLine());

			//Console.WriteLine($"{Divide(x1, y1)}");
			#endregion

			#region Test String 1

			//Console.WriteLine("Enter string:");
			//string str = Console.ReadLine();
			//Console.WriteLine(str);
			//Console.Write("\n");
			//Console.WriteLine(str.ToLower());
			//Console.WriteLine(str.ToUpper());
			//Console.WriteLine(str.Trim());
			//Console.WriteLine(str.TrimStart());
			//Console.WriteLine(str.TrimEnd());


			#endregion

			#region Test String 2
			//Console.WriteLine("Enter string:");
			//string str = Console.ReadLine();

			//Console.WriteLine(str.Length);

			//// StartsWith
			//Console.WriteLine(str.StartsWith("E"));
			//// IndexOf
			//Console.WriteLine(str.IndexOf("code"));
			//Console.WriteLine(str.IndexOf("w"));
			//Console.WriteLine(str.IndexOf('w'));
			#endregion

			#region Test String 3
			//Console.WriteLine("Enter string:");
			//string str = Console.ReadLine();

			//Substring
			//Console.WriteLine(str.Substring(2, 3));
			//Console.WriteLine(str.Substring(str.Length-5,5));

			////Split
			//string[] words = str.Split(' ');
			//foreach(var item in words)
			//{
			//	Console.WriteLine(item + " | ");

			//}
			// ToCharArray
			//char[] chars;

			//chars = str.ToCharArray(5,10);
			//foreach (var item in chars)
			//{
			//	Console.Write(item + "|");
			//}

			#endregion

			#region DateTime
			DateTime dt = DateTime.Now;
			//Console.WriteLine($"Now {dt}");
			//Console.WriteLine($"DateTime now plus 3 days {dt.AddDays(3)}");
			//Console.WriteLine($"DateTime now plus -3 days {dt.AddDays(-3)}");
			//Console.WriteLine($"DateTime now plus 1 month and 3.5 days {dt.AddDays(3.5).AddMonths(1)}");
			//// Print only the current month with words
			//Console.WriteLine(GetMonthName(dt.Month));
			


			#endregion
		}


		#region Funkcii
		static double Sum(double a, double b)
		{
			return a + b;
		}

		static double Subtract(double x, double y)
		{
			return x - y;
		}

		static double Multiplication(double a, double b)
		{
			return a + b;
		}

		static double Divide(double a, double b)
		{
			if(b == 0)
			{
				Console.WriteLine("Can't divide by 0");
			}

			return a / b;
		}
		#endregion

		#region Function GetMonthName
		static string GetMonthName(int m)
		{
			switch (m)
			{
				case 1:
					return "January";
				case 2:
					return "February";
				case 3:
					return "March";
				case 4:
					return "April";
				case 5:
					return "May";
				case 6:
					return "June";
				case 7:
					return "July";
				case 8:
					return "August";
				case 9:
					return "September";
				case 10:
					return "October";
				case 11:
					return "November";
				case 12:
					return "December";
				default:
					return "Don't know";
					break;
			}
			

		}
		#endregion
	}
}
