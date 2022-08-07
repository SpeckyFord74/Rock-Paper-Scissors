using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();  //Creates a new random//
            bool playAgain = true;  //Creates a new boolean value and makes it true//
            String Player;  //Creates a new string called player and doesn't give it a value//
            String Computer;  //Creates a new string called Computer and doesn't give it a value//
            String Answer;  //Creates a new string called Answer and doesn't give it a value//

            while (playAgain)  //Only executes while playAgain is true//
            {
                Player = "";  //Makes the string Player ""//
                Computer = "";  //Makes the string Computer ""//
                Answer = "";  //Makes the string Answer ""//

                while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS")  //Only executes when Player is either ROCK, PAPER or SCISSORS//
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");  
                    Player = Console.ReadLine().ToUpper();  //Reads line above it//
                }

                switch (random.Next(1, 4))  //Creates a switch using a random integer between 1 and 3//
                {
                    case 1:  //Executes if number = 1//
                        Computer = "ROCK";  //Makes the string Computer ROCK//
                        break;  //Exits the switch//

                    case 2:  //Executes if number = 2//
                        Computer = "PAPER";  //Makes the string Computer PAPER//
                        break;  //Exits the switch//

                    case 3:  //Executes if number = 13//
                        Computer = "SCISSORS";  //Makes the string Computer SCISSORS//
                        break;  //Exits the switch//
                }

                Console.WriteLine("Player: " + Player);
                Console.WriteLine("Computer: " + Computer);

                switch (Player)  //Creates a switch using the string Player//
                {
                    case "ROCK":  //Executes if player string is ROCK//
                        if (Computer == "ROCK")  //Only executes if Computer string is ROCK//
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        if (Computer == "PAPER")  //Only executes if Computer string is PAPER//
                        {
                            Console.WriteLine("You Lose!");
                        }

                        if (Computer == "SCISSORS")  //Only executes if Computer string is SCISSORS//
                        {
                            Console.WriteLine("You Win!");
                        }

                        break;

                    case "PAPER":  //Executes if player string is PAPER//
                        if (Computer == "ROCK")  //Only executes if Computer string is ROCK//
                        {
                            Console.WriteLine("You Win!");
                        }

                        if (Computer == "PAPER")  //Only executes if Computer string is PAPER//
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        if (Computer == "SCISSORS")  //Only executes if Computer string is SCISSORS//
                        {
                            Console.WriteLine("You Lose!");
                        }

                        break;

                    case "SCISSORS":  //Executes if player string is SCISSORS//
                        if (Computer == "ROCK")  //Only executes if Computer string is ROCK//
                        {
                            Console.WriteLine("You Lose!");
                        }

                        if (Computer == "PAPER")  //Only executes if Computer string is PAPER//
                        {
                            Console.WriteLine("You Win!");
                        }

                        if (Computer == "SCISSORS")  //Only executes if Computer string is SCISSORS//
                        {
                            Console.WriteLine("It's a draw!");
                        }

                        break;  //Exits the switch//
                }

                Console.WriteLine("Do you want to play again? (Y/N): ");
                Answer = Console.ReadLine().ToUpper();  //Reads the line above, converts it to upper case and assigns it to the string Answer//

                if (Answer == "Y")  //Only executes if answer is Y//
                {
                    playAgain = true;  //Keeps playAgain as true//
                }

                else if (Answer == "N")  //Only executes if answer is N//
                {
                    playAgain = false;  //Changes playAgain to false//
                }

            }
        }
    }
}
