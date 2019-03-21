using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Quiz.Library
{
	public class Quiz: Question
	{
		public string Name { get; set; }
		public List<Question> PossibleQuestions { get; set; }

		public Quiz()
		{
			this.PossibleQuestions = new List<Question>();
		}

		public Quiz(string name) :this()
		{
			this.Name = name;
		}
		public virtual void Start()
		{

		}
	}
}
