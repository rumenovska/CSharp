using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
	class Cinema
	{
		public string Name { get; set; }
		public List<int> Halls { get; set; }
		public List<Movie> LisOfMovies { get; set; }

		static void MoviePlaying(Movie movie)
		{
			Console.WriteLine($"Watching {movie.Title}");
		}

		public Cinema()
		{
			Halls = new List<int>();
			LisOfMovies = new List<Movie>();
		}
		public Cinema(string name)
		{
			this.Name = name;
			Halls = new List<int>();
			LisOfMovies = new List<Movie>();
		}
	}
}
