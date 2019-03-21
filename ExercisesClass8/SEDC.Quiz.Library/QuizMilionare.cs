using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Quiz.Library
{
	public class QuizMilionare :Quiz
	{
		private Random rnd;
		private Question[] questions15;
		private Dictionary<string, int> answerChoises;
		public QuizMilionare() :base("Millionaire")
		{
			this.rnd = new Random();
			this.questions15 = new Question[15];
			this.answerChoises = new Dictionary<string, int>();
			this.answerChoises.Add("A", 0);
			this.answerChoises.Add("B", 1);
			this.answerChoises.Add("C", 2);
			this.answerChoises.Add("D", 3);
		}
		public override void Start()
		{
			try
			{
				GenerateQuestion15();
				int i = 0;
				while(i < questions15.Length)
				{
					Question q = questions15[i];
					PrintQuestion(i, q);
					i++;

					Console.WriteLine("Answer= ");
					string answer = Console.ReadLine();
					if (answerChoises.ContainsKey(answer))
					{
						q.SelectedAnswer = answerChoises[answer];
						i++;
					}
					else
					{
						Console.Clear();
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
		private void GenerateQuestion15()
		{
			ShufflePossibleQuestions();
			questions15 = PossibleQuestions
				.Take(15)
				.ToArray();
		}
		private void PrintQuestion(int questionNum, Question q )
		{
			Console.WriteLine("---------------------------------");
			Console.WriteLine($"Question {questionNum +1}: {q.Text}");
			for (int i = 0; i < PossibleAnswers.Length  ; i++)
			{
				string answerLetter = answerChoises
					.FirstOrDefault(x => x.Value == i)
					.Key;
				Console.WriteLine($"{q.PossibleAnswers[i]}");

			}
		}
		
		private void ShufflePossibleQuestions()
		{
			int n = PossibleQuestions.Count;
			while(n > 1)
			{
				n--;
				int r = rnd.Next(n + 1);
				Question temp = PossibleQuestions[r];
				PossibleQuestions[r] = PossibleQuestions[n];
				PossibleQuestions[n] = temp;
			}

		}
	}
}
