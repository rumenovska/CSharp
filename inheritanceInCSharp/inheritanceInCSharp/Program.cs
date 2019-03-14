using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal a = new Animal();
			a.Name = "Sharko";
			a.Type = "Dog";
			a.ID = 1;
			a.Eat();
			a.Color = Animal.AnimalColors.White;

		
			Console.WriteLine(a.Name);
			a.PrintInfo();



			Cat c = new Cat();
			c.ID = 2;
			c.Name = "Cat 2";
			c.Type = "Cat";
			c.Eat();
			c.Color = Animal.AnimalColors.Brown;


			c.PrintInfo();
			Dog d = new Dog();
			d.ID = 3;
			d.Name = "Dog 3";
			d.Type = "Dog";
			d.Eat();
			d.Bark();
			d.PrintInfo();
			d.Color = Animal.AnimalColors.Black;

			
			Console.ReadLine();
		}
	}
}
