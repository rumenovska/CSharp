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

		public Song()
		{

		}

		public string SongInfo()
		{
			return $"Title {Title} Length {Length} ";
		}
	}
}
