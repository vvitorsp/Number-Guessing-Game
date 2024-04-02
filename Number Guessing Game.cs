using System;
using System.Runtime.CompilerServices;
using System.Text;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random Random = new Random();

            bool playAgain = true;
            int min = 0;
            int max = 100;
            int guesses;
            string response;
            int guess;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                int number = Random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " and " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    guesses++;

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " to high!");

                    } else if (guess < number) 
                    {
                        Console.WriteLine(guess + " to low!");
                    } 
                }
                    Console.WriteLine("it is the number " + number + "!");
                    Console.WriteLine("YOU WIN! CONGRATS!");
                    Console.WriteLine("You tried " + guesses + " Times before you find the right number!");

                    Console.WriteLine("Do you want to play again? (Y/N) ");
                    response = Console.ReadLine();
                    response = response.ToUpper(); 

                      if (response == "Y") {
                        playAgain = true;
                    } else if (response == "N"){
                        playAgain = false;
                        Console.WriteLine("Thanks for play!");
                    }
                Console.ReadLine();
            }


        }
    }
}