using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceInCSharp
{
	class Cat:Animal
	{
		public Cat()
		{
			Console.WriteLine("Cat constructor");
		}

		~Cat()
		{
			Console.WriteLine("Cat destructor");
		}
	}
}
