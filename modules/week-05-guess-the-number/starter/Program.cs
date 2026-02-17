/**************************************************************
* Course: DEV 110
* Term: Winter 2026
*
* Programmer: Alexander Hoang
* Assignment: Guess the Number Game
*
* Description:
* The program generates a random number and has the user guess the number.
* The game tracks the number of tries the user attempts before success and the total amount of rounds the user plays.
*
**************************************************************/
namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        Console.WriteLine("Welcome to Guess the Number!\n");
        Console.WriteLine("To play, guess the secret number by entering a number between the given numbers.");


        // Get validated max value (10-100) and number of rounds (1-3)
        int maxValue = ReadIntInRange("Enter a max value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        PlayGame(maxValue, rounds);

    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value = 0;
        bool isValid;
        do
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            isValid = int.TryParse(input, out value) && value >= min && value <= max;
            if (!isValid)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }

        } while (!isValid);

        return value;
    }

    private static void PlayGame(int maxValue, int rounds)
    {
        playAgainLoop:
        int totalRoundsPlayed = 0;

        for (int round = 1; round <= rounds; round++)
        {
            Console.WriteLine($"\n=== Round {round} of {rounds} ===");
            int secretNumber = new Random().Next(1, maxValue + 1);
            int guessCount = 0;
            int guess = 0;

            while (guess != secretNumber)
            {
                Console.Write($"Guess a number between 1 and {maxValue}: ");
                string? guessInput = Console.ReadLine();

                if (guessInput == null)
                {
                    // no more input (e.g. tests exhausted stdin) - stop the game
                    return;
                }

                if (!int.TryParse(guessInput, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                guessCount++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }

                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high.");
                }

                else
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
                }

            }

            totalRoundsPlayed++;
        }

        Console.WriteLine($"\n=== Game Over ===");
        Console.WriteLine($"You completed {totalRoundsPlayed} rounds!");

        bool validInput;
        do
        {
            validInput = true;
            Console.WriteLine("Thanks for playing! Would you like to play again? (y/n)");
            string? playAgainInput = Console.ReadLine();
            if (playAgainInput == null)
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            if (playAgainInput == "y" || playAgainInput == "Y")
            {
                goto playAgainLoop;
            }

            else if (playAgainInput == "n" || playAgainInput == "N")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                validInput = false;
            }

        } while (!validInput);

    }

}
