using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceInCSharp
{
	class Dog:Animal
	{
		
		public Dog():base("Sharko")
		{
			Console.WriteLine("Dog constructor");
		}

		public string PropertyDog { get; set; }

		public void Bark()
		{
			Console.WriteLine("bark bark bark");
		}
		public override void Eat()
		{
			base.Eat();

			Console.WriteLine("Dog Eat");
		}

		~Dog()
		{
			Console.WriteLine("Dog destructor");
		}
	}
}

