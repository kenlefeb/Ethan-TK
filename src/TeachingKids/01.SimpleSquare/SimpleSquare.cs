using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		/// <summary>
		/// This method starts the program.
		/// </summary>
		public static void Main()
		{
			Tortoise.Show();
			Tortoise.SetSpeed(10);
			for (int i = 0; i < 360; i++)
			{
				switch (i)
				{
					case 0:
						Tortoise.SetPenColor("green");
						Tortoise.SetSpeed(10);
						break;
					case 2:
						Tortoise.SetPenColor("blue");
						Tortoise.SetSpeed(10);
						break;
					case 1:
						Tortoise.SetPenColor("pink");
						Tortoise.SetSpeed(10);
						break;
					case 3:
						Tortoise.SetPenColor("red");
						break;
				}
				Tortoise.Move(5);
				Tortoise.Turn(1);
			}
			
		}
	}
}