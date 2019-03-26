using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace AcademyManagementApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Subject> subjects = new List<Subject>();
			subjects.Add(new Subject("C# Basic"));
			subjects.Add(new Subject("C# Advance"));
			subjects.Add(new Subject("JS Basic"));
			subjects.Add(new Subject("JS Advance"));

			List<Person> user = new List<Person>();
			user.Add(new Admin("Risto", "", "Risto1", "123454"));
			user.Add(new Trainer("Trajan", "Stevkovski", "Trajan1", "789456"));
			

		}
	}
}
