using System;

namespace TicTacToe
{
	class Game
	{
		static void Main(string[] args){

			// Board Array...
			string[] board = {"-", "-", "-",
							  "-", "-", "-",
							  "-", "-", "-"};

			// Game Characters...
			string playerOne = "X";
			string playerTwo = "O";
			string winner;

			// User Inputs...
			int userInput1;
			int userInput2;

			// Game Flag (The Controller of the Game)...
			bool gameFlag = true;


			while (gameFlag)
			{
				Console.Write("X\'s Move > ");
				userInput1 = Convert.ToInt32(Console.ReadLine());
	
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
					gameFlag = false;
				}
				else if (board[3] == board[4] && board[3] == board[5] && board[3] != "-")
				{
					winner = board[3];
					gameFlag = false;
				}
				else if (board[6] == board[7] && board[6] == board[8] && board[6] != "-")
				{
					winner = board[6];
					gameFlag = false;
				}

				// Checking For Row...
				if (board[0] == board[3] && board[0] == board[6] && board[0] != "-")
				{
					winner = board[0];
					gameFlag = false;
				}
				else if (board[1] == board[4] && board[1] == board[7] && board[1] != "-")
				{
					winner = board[1];
					gameFlag = false;
				}
				else if (board[2] == board[5] && board[2] == board[8] && board[2] != "-")
				{
					winner = board[2];
					gameFlag = false;
				}

				// Checking For Diagonal...
				if (board[0] == board[4] && board[0] == board[8] && board[0] != "-")
				{
					winner = board[0];
					gameFlag = false;
				}
				else if (board[2] == board[4] && board[2] == board[6] && board[2] != "-")
				{
					winner = board[2];
					gameFlag = false;
				}

			}

		}
	}
}
