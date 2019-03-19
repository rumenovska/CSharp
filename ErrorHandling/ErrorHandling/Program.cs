using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
	class Program
	{
		static void Main(string[] args)
		{
			Movie movie1 = new Movie("Movie1", Genre.Comedy, 10);
			Movie movie2 = new Movie("Movie2", Genre.Comedy, 5);
			Console.WriteLine(movie1.Rating);
			Console.WriteLine(movie2.Rating);
			Console.ReadLine();

			Cinema cinema1 = new Cinema("Cinema1");

		}
	}
}
