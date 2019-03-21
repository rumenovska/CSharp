using SEDC.Quiz.Library;

namespace ExercisesClass8
{
	class Program
	{
		static void Main(string[] args)
		{
			QuizMilionare milionare = new QuizMilionare();
			int possibleQuestionsCount = 100;
			for (int i = 0; i < possibleQuestionsCount; i++)
			{
				Question q = new Question();
				q.Text = $"Question {i}--{i%4}";
				q.PossibleAnswers = new string[4] {"Answer0", "Answer1", "Answer2", "Answer3" };
				q.CorrectAnswer = i % 4;
				milionare.PossibleQuestions.Add(q);

			}
			
			

		}
	}
}
