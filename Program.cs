using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int secretNumber = rand.Next(1, 11);

            int guessesGiven = 0;

            int guessesLeft = 5;

            Console.WriteLine("Choose difficulty. Easy, Medium, Hard. Cheater!");
            string userDif = Console.ReadLine();
            int difNum = 0;

            if (userDif == "Easy")
            {
                difNum = 8;
                guessesGiven = 0;
                guessesLeft = 9;
            }
            else if (userDif == "Medium")
            {
                difNum = 6;
                guessesGiven = 0;
                guessesLeft = 7;
            }
            else if (userDif == "Hard")
            {
                difNum = 4;
                guessesGiven = 0;
                guessesLeft = 5;
            }
            else if (userDif == "Cheater")
            {
                difNum = int.MaxValue;
                guessesGiven = 0;
                guessesLeft = int.MaxValue;
            }

            while (guessesGiven < difNum || userDif == "Cheater")
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1}). You have ({guessesLeft -1}) guesses left");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine("Yup! You guessed it!");
                    break;
                }
                else
                {
                    Console.WriteLine("Nope, that wasn't it!");
                }

                if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("You guessed too high! Try again.");
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("You guessed too low! Try again.");
                }

                guessesGiven++;
                guessesLeft--;
            }

        }
    }
}