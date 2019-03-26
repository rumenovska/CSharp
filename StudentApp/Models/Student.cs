using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Student: Person
	{
		public Subject CurrentSubject { get; set; }
		public Dictionary<Subject, int> Subjects { get; set; }

		public Student(string firstName, string lastName, string userName, string password, Dictionary<Subject, int> subjects)
			:base(firstName, lastName, userName, password, Role.Student)
		{
			
			
			this.Subjects = subjects;
		}
		
		public void Enrol(Subject subject)
		{
			this.CurrentSubject = subject;
		}

		public string GetInfo()
		{
			var message = $"{this.UserName}";

			foreach(var grade in Subjects)
			{
				message += $"{grade.Key.Name}: {grade.Value}";
			}

			return message;
		}
	}
}
