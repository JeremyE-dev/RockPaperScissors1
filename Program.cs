using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("How many rounds would you like to play?  ");
                int x = GetIntFromUser();
                int numberOfRounds = IsNumberInRange(x);
                PlayGame(numberOfRounds);
              
                Console.WriteLine("Would you like to play again?, enter any number for yes and 0 for no ");
               
                int number = GetIntFromUser();
               
                    if( number == 0)
                    {
                        Console.WriteLine("Thank you for playing, goodbye");
                        break;
                    }
                

             
                
            }
        

        }

        //Checks if number is int
        //asks for user input
        //asks repeatedly if enter does not enter a number
       
        public static int GetIntFromUser()
        {

            int number;
            while (true)
            {
                
                string userInput = Console.ReadLine();


                if (int.TryParse(userInput, out number))
                {

                    break;
                }

                else
                {
                    Console.WriteLine("That is not a number");
                }

            }

            return number;

        }


        //checks if number is between 1 and 10
        //returns number of rounds if number is in that range
        public static int IsNumberInRange(int number)
        {

            if (number >= 1 && number <= 10)
            {

                return number;
            }

            else
            {
                Console.WriteLine("  {0} is Not in range", number);
                return -1;
            }
        }

        // method to play game for given number of rounds
        // calculates and reports winner or game
        public static void PlayGame(int rounds)
        {
            int computerWins = 0;
            int userWins = 0;
            int ties = 0;
            int numberOfRounds = rounds;
          
            int computerChoice = 0;
            int userChoice = 0;
            //string userRockPaperScissors = "";
            //string computerRockPaperScissors = "";

            while (numberOfRounds > 0)
            {

                userChoice = GetChoiceFromUser();

                // assign string to user choice
               /* if (userChoice == 1)
                {
                    userRockPaperScissors = "Rock";
                }

                else if (userChoice == 2)
                {
                    userRockPaperScissors = "Paper";
                }



                else
                {
                    userRockPaperScissors = "Scissors";
                }
                */

                Random random = new Random();

                computerChoice = random.Next(1, 4);

                // assign string to computer choice
               /* if (computerChoice == 1)
                {
                    computerRockPaperScissors = "Rock";
                }

                else if (computerChoice == 2)
                {
                    computerRockPaperScissors = "Paper";
                }

                else
                {
                    computerRockPaperScissors = "Scissors";
                }
                */

                //Determine winner

                if (computerChoice == userChoice)
                {
                    Console.WriteLine("it is a tie");
                    ties++;

                }
                // 1 - rock, 2- paper, 3- scissors

                else if (computerChoice == 1 && userChoice == 2)
                {
                    Console.WriteLine("computer chooses ROCK player chooses PAPER player wins");
                    Console.WriteLine();
                    userWins++;

                }

                else if (computerChoice == 1 && userChoice == 3)
                {
                    Console.WriteLine("computer chooses ROCK player chooses SCISSORS computer wins");
                    Console.WriteLine();
                    computerWins++;
                }


                else if (computerChoice == 2 && userChoice == 1)
                {
                    Console.WriteLine("computer chooses PAPER player chooses ROCK computer wins");
                    Console.WriteLine();
                    computerWins++;
                }

                else if (computerChoice == 2 && userChoice == 3)
                {
                    Console.WriteLine("computer chooses PAPER player chooses SCISSORS player wins");
                    Console.WriteLine();
                    userWins++;
                }

                else if (computerChoice == 3 && userChoice == 1)
                {
                    Console.WriteLine("computer chooses SCISSORS player chooses ROCK player wins");
                    Console.WriteLine();
                    userWins++;
                }

                else if (computerChoice == 3 && userChoice == 2)
                {
                    Console.WriteLine("computer chooses SCISSORS player chooses PAPER computer wins");
                    Console.WriteLine();
                    computerWins++;
                }

                else
                {
                    Console.WriteLine("it is a tie");
                    Console.WriteLine();
                    ties++;

                }

                numberOfRounds--;

            }

            //report results
            if(computerWins > userWins)
            {
                Console.WriteLine("The computer won {0} game(s), the user won {1} game(s), there were {2} ties COMPUTER WINS", computerWins, userWins, ties);
                Console.WriteLine();
            }
            else if (userWins > computerWins)
            {
                Console.WriteLine("The computer won {0} game(s), the user won {1} game(s), there were {2} ties USER WINS", computerWins, userWins, ties);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("The computer won {0} game(s), the user won {1} game(s), there were {2} ties IT IS A TIE", computerWins, userWins, ties);
                Console.WriteLine();
            }

        }

        //requests and validates user choice
        // returns integer indicating that choice
       public static int GetChoiceFromUser()
        {
            int number;
            while (true)
            {
                Console.Write("Choose 1 for Rock, 2 for Paper, or 3 for Scissors  ");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(userInput, out number) && ValidateChoice(number))
                {

                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input Please choose 1 for Rock, 2 for Paper, or 3 for Scissors  ");
                    Console.WriteLine();
                }
            }

            return number;

        }

        public static bool ValidateChoice(int x)
        {
  
     
                if (x == 1|| x == 2 || x == 3)
                {

                return true;
                    
                }

                else
                {
               
                return false;

                }

           
         
        }


    }
}
