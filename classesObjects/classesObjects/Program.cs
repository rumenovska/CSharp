using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesObjects
{
	class Program
	{
		class Car
		{
			public string Brand;
			public string Color;
			public string Engine;
			public double KWs;
			public string Fuel;
			public int Doors;
			
			// default konstruktor
			public Car() {
				Console.WriteLine("Constructing Object");
			}
			public Car(string brand, string color, string fuel, int doors, string engine,double kws )
			{
				this.Color = color;
				this.Fuel = fuel;
				this.Doors = doors;
				this.Engine = engine;
				this.Brand = brand;
				this.KWs = kws;
			
			}
			~Car()
			{
				Console.WriteLine($"Destructing Object {this.Brand}");
			}
			public void PrintCar(Car c1)
			{
				Console.WriteLine($"Brand: {c1.Brand} , Color: {c1.Color} ,Doors: {c1.Doors} ,Engine: {c1.Engine}, KWs: {c1.KWs}, Fuel: {c1.Fuel} ");
			}
			
		}
		class Human
		{
			public string FirstName;
			public string LastName;
			public byte Age;

			public Human(string firstName, string lastName, byte age)
			{
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Age = age;

			}
			public void GetFullInfo()
			{
				Console.WriteLine($"Name: {this.FirstName} {this.LastName}, age: {this.Age}");
			}
			
		}
		class Dog
		{
			public string Name;
			public string Race;
			public string Color;
			public Dog(string name, string race, string color)
			{
				this.Name = name;
				this.Race = race;
				this.Color = color;
			}
			public void Eat()
			{
				Console.WriteLine($"Dog {this.Name} is now eating!");
			}
			public void Play()
			{
				Console.WriteLine($"Dog {this.Name} is now playing!");
			}
			public void ChaseTail()
			{
				Console.WriteLine($"Dog {this.Name} is now chasing it's tail!");
			}
		}
		static void Main(string[] args)
		{
			Car c1 = new Car();
			c1.Brand = "VW";
			c1.Color = "Black";
			c1.Doors = 5;
			c1.Engine = "2.0 TDI";
			c1.KWs = 104;
			c1.Fuel = "Diesel";
			c1.PrintCar(c1);

			Car c2 = new Car("Toyota", "Silver", "Petrol", 3, "TSI", 90);
			c2.PrintCar(c2);
			Console.ReadLine();

			Human h1 = new Human("Marija", "Rumenovska", 23);

			h1.GetFullInfo();
			Dog d1 = new Dog("Lusy", "Terrier", "Brown");

			d1.Play();

		}
		
	}
}
