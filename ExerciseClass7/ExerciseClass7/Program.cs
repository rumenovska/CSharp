using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass7
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee a = new Employee();
			a.FirstName = "Marija";
			a.LastName = "Rumenovska";
			a.Role = Role.Manager;
			
			a.PrintInfo();
		}
	}
}
