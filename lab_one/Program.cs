using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] quizQuestions = new string[] 
			{
				"1. Who created .Net Core?",
				"2. When was .Net Core released?",
				"3. What license does .Net Core use?",
				"4. When was .Net Core 2.0 Released?",
				"5. When was .Net Core 3.0 Announced?",
				"6. Which Language does .Net Core not have support for?",
				"7. What is the current .Net Core version?",
			};

			string[,] quizAnswers = new string[10, 4]{
				{"A) Apple", "B) .Net Foundation", "C) Microsoft", "D) Amazon"},
				{"A) 2015", "B) 2016", "C) 2006", "D) 2013"},
				{"A) GNU GPL ", "B) GNU LGPL", "C) MIT License", "D) BSD 3"},
				{"A) 2017", "B) 2015", "C) 2013", "D) 2018"},
				{"A) 2017", "B) 2015", "C) 2013", "D) 2018"},
				{"A) Ruby", "B) C#", "C) F#", "D) VB .NET"},
				{"A) 2.2", "B) 2.0", "C) 2.0.2", "D) 2.3.1"},
				{"A) ", "B) ", "C) Microsoft", "D) "},
				{"A) ", "B) ", "C) ", "D) yes"},
				{"A) yes ", "B) ", "C) ", "D) "}
				};

			string EXIT = "";
			string tempAnswer = "";
			string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
			int amntCorrect = 0;

			Housekeeping();

			while (EXIT != "Q")
			{
				Console.Clear();
				for (int i = 0; i < quizQuestions.Length; i++)
				{
					Console.WriteLine(quizQuestions[i]);
					Console.WriteLine("");
					for (int j = 0; j < 4; j++)
					{
						Console.WriteLine(quizAnswers[i, j]);
					}
					Console.WriteLine("");
					tempAnswer = Console.ReadLine();
					tempAnswer = tempAnswer.ToUpper();
					if (tempAnswer == answerKey[i])
					{
						amntCorrect++;
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Correct!");
						Console.ResetColor();
						Console.WriteLine("Press <ENTER> to move on to the next question");
						while (Console.ReadKey().Key != ConsoleKey.Enter) { }
						Console.Clear();

					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Incorrect");
						Console.ResetColor();
						Console.WriteLine("Press <ENTER> to move on to the next question");
						while (Console.ReadKey().Key != ConsoleKey.Enter) { }
						Console.Clear();
					}
				}
				if (amntCorrect >= 6)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Congratulations! You have passed!");
					Console.ResetColor();
					Console.WriteLine("You got a score of {0}/10", amntCorrect);
					Console.WriteLine("Press any key to take the quiz again or enter 'Q' to quit.");
					EXIT = Console.ReadLine();
					EXIT = EXIT.ToUpper();
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Sorry, you have failed the quiz.");
					Console.ResetColor();
					Console.WriteLine("You got a score of {0}/10", amntCorrect);
					Console.WriteLine("If you would like to take the quiz again enter any key. Or press 'Q' to quit");
					EXIT = Console.ReadLine();
					EXIT = EXIT.ToUpper();
				}
			}
        }

		public static void Housekeeping()
		{
			Console.WriteLine("Welcome to the .Net Core Quiz.");
			Console.WriteLine("Press enter to begin");
			while (Console.ReadKey().Key != ConsoleKey.Enter) { }
		}
    }
}
