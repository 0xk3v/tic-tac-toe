using System;

namespace Game
{
	class TicTacToe
	{
		static void Main(string[] args){

			// Board Array...
			string[] board = {"-", "-", "-","-", "-", "-","-", "-", "-"};

			// Game Characters...
			string playerOne = "X";
			string playerTwo = "O";
			string winner;

			// User Inputs...
			int userInput1;
			int userInput2;

			// Game Controls...
			bool gameFlag = true;
			bool gameRunning = true;
			int gameMenu;
			string exitFlag;

			while (gameRunning) {
				Console.WriteLine("\nWelcome to TicTacToe!!\n");
				Console.WriteLine("1. New Game");
				Console.WriteLine("2. About The Author");
				Console.WriteLine("3. Exit");

				// Checking for User Input...
				Console.Write("\n> ");
				while(!int.TryParse(Console.ReadLine(), out gameMenu) || gameMenu < 1 || gameMenu > 3);

				if (gameMenu == 1) {
					// Resetting the Game Controller...
					gameFlag = true;					
					// Resetting the board in case of Re Match...
					for (int i = 0; i < board.Length; i++)
					{
						board[i] = "-";
					}

					Console.Clear();
					// The big while goes here...
					while (gameFlag)
					{

					// Checking for a tie...
					if ((Array.IndexOf(board, "-")) == -1)
					{
					// Printing the Game Board...
						Console.WriteLine( "\n  " + board[0] + " | " + board[1] + " | " + board[2]);
						Console.WriteLine(" ---+---+---");
						Console.WriteLine( "  " + board[3] + " | " + board[4] + " | " + board[5]);
						Console.WriteLine(" ---+---+---");
						Console.WriteLine( "  " + board[6] + " | " + board[7] + " | " + board[8]);	
						
					// Ending The Game due to a Tie...
						Console.Clear();
						Console.WriteLine("It\'s a Tie!!");
					    gameFlag = false;
						break;

					} // End IF

					// Printing the Game Board...
					Console.WriteLine( "\n  " + board[0] + " | " + board[1] + " | " + board[2]);
					Console.WriteLine(" ---+---+---");
					Console.WriteLine( "  " + board[3] + " | " + board[4] + " | " + board[5]);
					Console.WriteLine(" ---+---+---");
					Console.WriteLine( "  " + board[6] + " | " + board[7] + " | " + board[8]);

					// Checking For Column...
					if (board[0] == board[1] && board[0] == board[2] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[3] == board[4] && board[3] == board[5] && board[3] != "-")
					{
						winner = board[3];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[6] == board[7] && board[6] == board[8] && board[6] != "-")
					{
						winner = board[6];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}

					// Checking For Row...
					if (board[0] == board[3] && board[0] == board[6] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[1] == board[4] && board[1] == board[7] && board[1] != "-")
					{
						winner = board[1];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[2] == board[5] && board[2] == board[8] && board[2] != "-")
					{
						winner = board[2];
					    Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}

					// Checking For Diagonal...
					if (board[0] == board[4] && board[0] == board[8] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[2] == board[4] && board[2] == board[6] && board[2] != "-")
					{
						winner = board[2];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}

					// Getting User 1 Input...
					Console.Write("X\'s Move > ");
					while(!int.TryParse(Console.ReadLine(), out userInput1));

					// Validating User Input 1...
					if (userInput1 >= 1 && userInput1 <= 9 && board[userInput1-1] == "-" )
					{
						board[userInput1-1] = playerOne;
					}
					else
					{
						Console.WriteLine("Invalid Move");
					}

					// Printing the Game Board...
					Console.WriteLine( "\n  " + board[0] + " | " + board[1] + " | " + board[2]);
					Console.WriteLine(" ---+---+---");
					Console.WriteLine( "  " + board[3] + " | " + board[4] + " | " + board[5]);
					Console.WriteLine(" ---+---+---");
					Console.WriteLine( "  " + board[6] + " | " + board[7] + " | " + board[8]);	
					
					// Checking For Column...

					if (board[0] == board[1] && board[0] == board[2] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[3] == board[4] && board[3] == board[5] && board[3] != "-")
					{
						winner = board[3];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[6] == board[7] && board[6] == board[8] && board[6] != "-")
					{
						winner = board[6];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}

					// Checking For Row...
					if (board[0] == board[3] && board[0] == board[6] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[1] == board[4] && board[1] == board[7] && board[1] != "-")
					{
						winner = board[1];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[2] == board[5] && board[2] == board[8] && board[2] != "-")
					{
						winner = board[2];
					    Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}

					// Checking For Diagonal...
					if (board[0] == board[4] && board[0] == board[8] && board[0] != "-")
					{
						winner = board[0];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					else if (board[2] == board[4] && board[2] == board[6] && board[2] != "-")
					{
						winner = board[2];
						Console.WriteLine("The Winner is {0}", winner);
						gameFlag = false;
						break;
					}
					
					// Checking for a tie...
					if ((Array.IndexOf(board, "-")) == -1)
					{
						// Printing the Game Board...
						Console.WriteLine( "\n  " + board[0] + " | " + board[1] + " | " + board[2]);
						Console.WriteLine(" ---+---+---");
						Console.WriteLine( "  " + board[3] + " | " + board[4] + " | " + board[5]);
						Console.WriteLine(" ---+---+---");
						Console.WriteLine( "  " + board[6] + " | " + board[7] + " | " + board[8]);

						// Ending The Game due to a Tie...
						Console.WriteLine("It\'s a Tie!!");
						gameFlag = false;
						break;
					} // End IF

					// Getting User 2 Input...
					Console.Write("O\'s Move > ");
					while(!int.TryParse(Console.ReadLine(), out userInput2));

					// Validating User Input 2...
					if (userInput2 >= 1 && userInput2 <= 9 && board[userInput2-1] == "-" )
					{
						board[userInput2-1] = playerTwo;
					}
					else
					{
						Console.WriteLine("Invalid Move");
					}

				} // End of While

				}// End of IF-1
				else if (gameMenu == 2) {
					Console.WriteLine("Kevin, A Computer Science Student at WSB University in Poznan :)");
					Console.Write("Press Enter to Return to Main Menu!");
					ConsoleKey key = Console.ReadKey().Key;
					if (key == ConsoleKey.Enter)
					{
						continue;
					}
				}
				else if (gameMenu == 3) {
					Console.Write("Are you sure you want to Exit??  [y/n] > ");
					exitFlag = Console.ReadLine();
					if (exitFlag.ToLower() == "y") {
						gameRunning = false;
					}
					else if (exitFlag.ToLower() == "n")
					{
						continue;
					}
					else{
						Console.WriteLine("Invalid Input");
					}
				}
				else{
					Console.WriteLine("Invalid Input!!");
				}
			}
		}
	}
}

