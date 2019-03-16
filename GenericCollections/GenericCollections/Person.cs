using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
	class Person
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public EnumGenre FavoriteMusicType { get; set; }
		public List<Song> FavoriteSong { get; set; }


		public Person( string firstname, string lastname, EnumGenre favMusicType)
		{
			this.FirstName = firstname;
			this.LastName = lastname;
			this.FavoriteMusicType = favMusicType;
		}

	}
}
