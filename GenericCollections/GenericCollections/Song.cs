using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
	  class Song
	{
		public string Title { get; set; }
		public int Length { get; set; }
		public EnumGenre Genre { get; set; }

		public Song(string title, int length, EnumGenre genre)
		{
			this.Title = title;
			this.Length = length;
			this.Genre = genre;
		}

		public string SongInfo()
		{
			return $"Title {Title} Length {Length} Genre {Genre}";
		}
	}
}
