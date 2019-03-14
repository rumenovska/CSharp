using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClass7
{
	class Employee
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Role Role { get; set; }
		protected double Salary { get; set; }

		public Employee() { 
}
		public void PrintInfo()
		{
			Console.WriteLine($"Name: {this.FirstName} {this.LastName}, Salary= {Salary}");
		}

		public virtual double GetSalary()
		{
			return this.Salary;


		}
	}
}
