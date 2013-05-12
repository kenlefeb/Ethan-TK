using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquareQuiz
	{
		private static void question1()
		{
			// Turn the tortoise 1/5 of 360 degrees to the right
			Tortoise.Turn(360/5);
		}

		private static void question2()
		{
			// Move the tortoise 110 pixels
		Tortoise.Move(110);
		}

		private static void question3()
		{
			//  Change the color the tortoise draws to yellow
		Tortoise.SetPenColor("yellow");
		}

		private static void question4()
		{
			//  Change the width of the line the tortoise draws to 5 pixels
		Tortoise.SetPenWidth(5);
		}

		#region Ignore

		public static void Main()
		{
			Quiz.StartSquareQuizAt += question1;
		}

		#endregion
	}
}