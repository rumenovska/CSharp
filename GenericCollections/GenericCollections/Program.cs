using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GenericCollections
{
	class Program
	{
		static void PrintCollection(IEnumerable collection, string name)
		{
			Console.WriteLine($"Elements from collection {name}");
			foreach(var element in collection )
			{
				Console.Write($"{element} ");
			}

			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			//int[] a = new int[5] { 1, 2 ,3 ,4, 5};
			//PrintCollection(a, "Array a");
			//Console.WriteLine("---------------------------");

			//ArrayList al1 = new ArrayList() {1, "a", "true", true };
			//al1.Add(23);
			//al1.Add("tekst");
			//Console.WriteLine($"El[1] ={al1[1]}");
			//PrintCollection(al1, "ArrayList");
			//Console.WriteLine("---------------------------");

			//List<int> li = new List<int>() {1,2,3 };
			//li.Add(4);
			//li.Add(5);
			//li.Remove(1);
			//PrintCollection(li, "List");
			//Console.WriteLine($"El[1] ={li[1]}");
			//Console.WriteLine("---------------------------");

			//Queue<int> q = new Queue<int>();
			//q.Enqueue(1);
			//q.Enqueue(2);
			//q.Enqueue(3);
			//q.Enqueue(4);
			//PrintCollection(q, "Queue");
			//int el1;
			//el1= q.Dequeue();
			//int el2;
			//el2 = q.Dequeue();
			//PrintCollection(q, "Queue");
			//Console.WriteLine(q.Count());
			//Console.WriteLine($"Sum of first and second element of Queue is {el1+el2}");
			//Console.WriteLine("---------------------------");

			//Stack<int> s = new Stack<int>();
			//s.Push(1);
			//s.Push(2);
			//s.Push(3);
			//s.Push(4);
			//s.Push(5);
			//s.Push(6);
			//PrintCollection(s, "Stack");
			//Console.WriteLine($"Count= {s.Count()}");
			//int s1;
			//s1 = s.Pop();
			//int s2;
			//s2 = s.Pop();

			//PrintCollection(s, "Stack");
			//Console.WriteLine($"Sum of first and second element of Stack is {s1 + s2}");
			//Console.WriteLine($"Count= {s.Count()}");
			//int peek;
			//peek = s.Peek();
			//Console.WriteLine($"Peek = {peek}");
			//PrintCollection(s, "Stack");
			//Console.WriteLine("---------------------------");

			//Dictionary<string, string> d1 = new Dictionary<string, string>() { { "Author 1", "Book 1" }, { "Author 2", "Book 2" } };
			//PrintCollection(d1, "Dictionary");

			//d1.Add("Author 3", "Book 3");
			//string author3Value = d1["Author 3"];
			//Console.WriteLine(author3Value);
			//d1.Remove("Author 1");
			//PrintCollection(d1, "Dictionary");
			//Console.WriteLine("---------------------------");

			// Exercise 1
			Dictionary<string, string> phoneBook = new Dictionary<string, string>() { { "Marija1", "070265852" }, { "Frosina2", "078635214" }, { "Simona3", "078635214" }, { "Jana4", "078635219" }, { "Biljana5", "072635219" } };

			//PrintCollection(phoneBook, "phoneBook");
			string name = Console.ReadLine();
			if(phoneBook.ContainsKey(name) == true)
			{
				Console.WriteLine(phoneBook[name]);
			}
			else
			{
				Console.WriteLine("Error!");
			}

			// Exercise 2


			Console.ReadLine();
		}

	}
}
