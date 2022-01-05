using System;

namespace Program
{
	class TicTacToe
	{

		static void Main(string[] args)
		{
			// Class Instantiation...
			Menu menu = new Menu();
			Game game = new Game();

			// Game Controller...
			
			// Game's Main Loop...
			do
			{
				int UserInput = menu.GetInput(1, 3);

				if (UserInput == 1)
					game.Run();
				else if (UserInput == 2)
					menu.ShowAuthor();
				else if (UserInput == 3)
					menu.Quit();
			} while (menu.GameState);	
		}
	}

	// Class to handle Menu...
	public class Menu
	{
		public bool GameState = true;

		// Method to Display The Game Menu...
		public void Display()
		{
			Console.WriteLine("\n Welcome to TicTacToe!!\n");
			Console.WriteLine("   1. New Game");
			Console.WriteLine("   2. About The Author");
			Console.WriteLine("   3. Exit");
		}

		// Method to Receive and Sanitize Inputs...
		public int GetInput(int Min, int Max)
		{
			Display();
			if( Min >= Max )
				throw new Exception("Wrong Input");
			int Choice;
			do
				Console.Write("> ");
			while(!int.TryParse(Console.ReadLine(), out Choice) || Choice < Min || Choice > Max );
			return Choice;
		}
		
		// Method to Display Information on the Author...
		public void ShowAuthor()
		{
			Console.WriteLine("A Computer Science Student at WSB University in Poznan :)");
			Console.WriteLine("\nPress Enter to Return to Main Menu!");
			ConsoleKey key = Console.ReadKey().Key;
			if (key == ConsoleKey.Enter)
				GameState = true;
		}	

		// Method to Terminate The Game...
		public void Quit()
		{
			Console.Write("Are you sure you want to Exit??  [y/n] > ");
			string exitFlag = Console.ReadLine();
			if (exitFlag.ToLower() == "y") {
				GameState = false;
			}
			else if (exitFlag.ToLower() == "n")
				GameState = true;
			else{
				Console.WriteLine("Invalid Input");
			}
		}
	}

	// Class to handle the Game Logic...
	public class Game
	{
		// Board Declaration...
		public string[] Board = {"-", "-", "-","-", "-", "-","-", "-", "-"};
		public string CurrentPlayer = "X";
		public string Winner;
		public bool GameFlag = true;

		// Method to Draw The Board...
		public void DrawBoard()
		{
			// Drawing the Board...
			Console.WriteLine();
			Console.WriteLine("\n  " + Board[0] + " | " + Board[1] + " | " + Board[2]);
			Console.WriteLine(" ---+---+---");
			Console.WriteLine("  " + Board[3] + " | " + Board[4] + " | " + Board[5]);
			Console.WriteLine(" ---+---+---");
			Console.WriteLine("  " + Board[6] + " | " + Board[7] + " | " + Board[8]);	
			Console.WriteLine();
		}

		// Method to handle user inputs...
		public void HandleInputs()
		{
			int userInput;
			Console.Write($"{CurrentPlayer}\'s Move > ");
			while(!int.TryParse(Console.ReadLine(), out userInput));
			if (userInput >= 1 && userInput < 10 && Board[userInput-1] == "-")
				Board[userInput-1] = CurrentPlayer;
			else
				Console.WriteLine("Invalid Move");
		}

		// Method to Check The Winner through Vertical Moves...
		public bool CheckVertical()
		{
			if (Board[0] == Board[3] && Board[0] == Board[6] && Board[0] != "-")
			{
				Winner = Board[0];
				return true;
			}
			else if (Board[1] == Board[4] && Board[1] == Board[7] && Board[1] != "-")
			{
				Winner = Board[1];
				return true;
			}
			else if (Board[2] == Board[5] && Board[2] == Board[8] && Board[2] != "-")
			{
				Winner = Board[2];
				return true;
			}
			else
				return false;

		}

		// Method to Check The Winner through Horizontal Moves...
		public bool CheckHorizontal()
		{
			if (Board[0] == Board[1] && Board[0] == Board[2] && Board[0] != "-")
			{
				Winner = Board[0];
				return true;
			}
			else if (Board[3] == Board[4] && Board[3] == Board[5] && Board[3] != "-")
			{
				Winner = Board[3];
				return true;
			}
			else if (Board[6] == Board[7] && Board[6] == Board[8] && Board[6] != "-")
			{
				Winner = Board[6];
				return true;
			}
			else
				return false;
		}

		// Method to Check The Winner through Diagonal Moves...
		public bool CheckDiagonal()
		{
			if (Board[0] == Board[4] && Board[0] == Board[8] && Board[0] != "-")
			{
				Winner = Board[0];
				return true;
			}
			else if (Board[2] == Board[4] && Board[2] == Board[6] && Board[2] != "-")
			{
				Winner = Board[2];
				return true;
			}
			else
				return false;
		}

		// Method to Check for a Draw...
		public void CheckDraw()
		{
			if ((Array.IndexOf(Board, "-")) == -1)
			{
				Console.Clear();
				DrawBoard();
				Console.WriteLine("\nIt's a Draw :)");
				GameFlag = false;
				/* ResetGame(); */
			}
		}
		
		// Method to Switch Players...
		public void SwitchPlayers()
		{
			if (CurrentPlayer == "X")
				CurrentPlayer = "O";
			else
				CurrentPlayer = "X";
		}

		// Method to Check the winner...
		public void CheckWinner()
		{
			if (CheckVertical() || CheckHorizontal() || CheckDiagonal() )
			{
				Console.Clear();
				DrawBoard();
				Console.WriteLine($"The Winner is {Winner}");
				GameFlag = false;
				/* ResetGame(); */
			}
		}

		// Method to Reset The Game...
		public void ResetGame(){
			for (int i = 0; i < Board.Length; i++)
				Board[i] = "-";
		}
		// Method to Run the Game Loop...
		public void Run()
		{
			while (GameFlag)
			{
				Console.Clear();
				DrawBoard();
				HandleInputs();
				CheckWinner();
				CheckDraw();
				SwitchPlayers();
			}
		}
	}
}

