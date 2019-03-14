using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceInCSharp
{
	class Animal
	{

		public enum AnimalColors {Black, Brown, White };
		

		public string Type { get; set; }
		public string Name { get; set; }
		public int ID { get; set; }
		public AnimalColors Color { get; set; }

		public Animal()
		{
			Console.WriteLine("Animal constructor");
		}
		public Animal(string name)
		{
			Console.WriteLine("Animal name constructor");
			this.Name = name;
		}
		public void PrintInfo()
		{
			Console.WriteLine($"Animal ID={ID} Name={Name} Type={Type} Color={Color}");
		}

		public virtual void Eat()
		{
			Console.WriteLine("Animal eat");

		}
		
		~Animal()
		{
			Console.WriteLine("Animal destructor");
		}
	}
}
