﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Admin: Person
	{
		public Admin(string firstName, string lastName, string userName, string password)
			: base(firstName, lastName, userName, password, Role.Admin)
		{

		}
	}
}
