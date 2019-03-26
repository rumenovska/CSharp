using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Person
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Role Role { get;}
		public string UserName { get; set; }
		private string Password { get;}
		

		public Person(string firstName, string lastName, string userName, string password, Role role)
		{
			this.Role = role;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.UserName = userName;
			this.Password = password;
		}

		public bool ValidPassword( string password)
		{

		}
	}
}
