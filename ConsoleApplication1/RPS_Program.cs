using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSApplication
{
    class RPS_Program
    {
        static int playerScore = 0, compScore = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Rock, Paper, Scissors game\n");
            GameFunc();

        }

        public static void GameFunc()
        {
            Random numberGen = new Random();

            string rock = "R";
            string paper = "P";
            string scissors = "S";
            string noGame;

            do
            {
                Console.WriteLine("Rock, Paper or Scissors? (R, P, S):");
                string choice = Console.ReadLine();

                int random = numberGen.Next(1, 4);
                choice = choice.ToUpper();
                switch (random)
                {
                    case 1:
                        if (choice == rock)
                        {
                            Console.WriteLine("You've entered Rock" + "! \nComputer choose Rock" + "! \n");
                            Console.WriteLine("Same result!");
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + ": Computer score " + compScore);

                        }
                        else if (choice == paper)
                        {
                            Console.WriteLine("You've entered Paper" + " ! \nComputer choose Rock " + "! \n");
                            Console.WriteLine("Paper beats Rock");
                            playerScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }
                        else if (choice == scissors)
                        {

                            Console.WriteLine("You've entered Scissors" + " ! \nComputer choose Rock " + "! \n");
                            Console.WriteLine("Rock beates Scissor");
                            compScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }

                        break;
                    case 2:
                        if (choice == rock)
                        {
                            Console.WriteLine("You've entered Rock" + "! \n Computer choose Paper " + "! \n");
                            Console.WriteLine("Paper beats Rock");
                            compScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);


                        }
                        else if (choice == paper)
                        {

                            Console.WriteLine("You've entered Paper" + "! \nComputer choose Paper " + "! \n");
                            Console.WriteLine("Same result!");
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }
                        else if (choice == scissors)
                        {
                            Console.WriteLine("You've entered Scissor" + " ! \nComputer choose Paper" + "! \n");
                            Console.WriteLine("Scissors beats paper");
                            playerScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }

                        break;
                    case 3:
                        if (choice == rock)
                        {
                            Console.WriteLine("You've entered Rock" + " ! \nComputer choose Scissor" + "! \n");
                            Console.WriteLine("Rock beates Scissor");
                            playerScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }
                        else if (choice == paper)
                        {
                            Console.WriteLine("You've entered Paper " + " ! \nComputer choose Scissor " + "! \n");
                            Console.WriteLine("Scissors beats paper");
                            compScore++;
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }
                        else if (choice == scissors)
                        {

                            Console.WriteLine("You've entered Scissor" + "! \nComputer choose Scissor" + "! \n");
                            Console.WriteLine("Same result!");
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);

                        }
                        break;
                }
                Console.WriteLine("________________________________________\n");
                Console.WriteLine("Do you want to continue? (Y or N):");
                noGame = Console.ReadLine();

                if (noGame == "N")
                {
                    Console.WriteLine("________________________________________\n");
                    Console.WriteLine("Final score \n ");
                    Console.WriteLine("Your score " + playerScore + " : Computer score " + compScore);
                }

            } while (noGame == "Y");
            Console.ReadKey();
        }
    }
}
