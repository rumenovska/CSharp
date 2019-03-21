namespace SEDC.Quiz.Library
{
	public class Question
	{
		public string Text { get; set; }
		public string [] PossibleAnswers { get; set; }
		public int CorrectAnswer { get; set; }
		public int SelectedAnswer { get; set; }

		public Question()
		{
		}

		public Question(string text, string[] possibleAnswer, int correctAnswer)
		{
			this.Text = text;
			this.PossibleAnswers = possibleAnswer;
			this.CorrectAnswer = correctAnswer;

		}


	}
}
