/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Alexander Hoang
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System.ComponentModel;
using Microsoft.VisualBasic;

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Text Menu Studio ===\n");

        Console.WriteLine("Welcome to Text Menu Studio!");

        int choice = 0;

        while (choice != 6)
        {
            string title = "Text Menu Studio";
            string subtitle = "Strings + Console Output Patterns";
            string divider = new string('=', 48);

            Console.WriteLine(divider);
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(subtitle);
            Console.WriteLine(divider);

            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            switch (choice)
            {
                case 1:
                {
                    Console.Write("Enter your name: ");
                    string name = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Enter a short message: ");
                    string message = (Console.ReadLine() ?? "").Trim();
                    string upperName = name.ToUpper();
                    string greeting = $"hello, {name.ToLower()}!";
                    string formattedMessage = string.Format("Message: {0}", message);

                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine(greeting);
                    Console.WriteLine(divider);
                    Console.WriteLine(formattedMessage);
                    Console.WriteLine($"From: {upperName}");
                    Console.WriteLine(divider);
                    break;
                }

                case 2:
                {
                    Console.Write("Enter first name: ");
                    string firstName = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Enter last name: ");
                    string lastName = (Console.ReadLine() ?? "").Trim();
                    string fullName = firstName + " " + lastName;
                    char firstInitial = firstName.Length > 0 ? char.ToUpper(firstName[0]) : '?';
                    char lastInitial = lastName.Length > 0 ? char.ToUpper(lastName[0]) : '?';
                    string initials = ($"Initials: {firstInitial}{lastInitial}").ToUpper();
                    string lowerCaseName = ($"Lowercase: {fullName.ToLower()}");

                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine($"Name Tag: [{fullName}]");
                    Console.WriteLine(initials);
                    Console.WriteLine(lowerCaseName);
                    Console.WriteLine(divider);
                    break;
                }

                case 3:
                {
                    Console.Write("Enter a phrase: ");
                    string phrase = (Console.ReadLine() ?? "").Trim();
                    int length = phrase.Length;
                    bool containsA = phrase.ToLower().Contains('a');
                    string dashedVersion = phrase.Replace(' ', '-');
                    string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string wordList = string.Join(", ", words);

                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine($"Length: {length}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed version: {dashedVersion}");
                    Console.WriteLine($"Words: {wordList}");
                    Console.WriteLine(divider);
                    break;
                }

                case 4:
                {
                    Console.Write("Enter item name: ");
                    string itemName = (Console.ReadLine() ?? "").Trim();
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);
                    double total = price * quantity;

                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10}", "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine(string.Format("{0,-20} {1,5} {2,10:C2}", itemName, quantity, total));
                    Console.WriteLine(divider);
                    break;
                }

                case 5:
                {
                    Console.Write("Enter a title: ");
                    string bannerTitle = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = (Console.ReadLine() ?? "").Trim();
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    string border = new string('=', width);
                    string centeredTitle = bannerTitle.ToUpper().PadLeft((width + bannerTitle.Length) / 2);
                    string centeredSubtitle = bannerSubtitle.PadLeft((width + bannerSubtitle.Length) / 2);

                    Console.WriteLine();
                    Console.WriteLine(border);
                    Console.WriteLine("Centered Title (Left to Right alignment):");
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);
                    break;
                }

                case 6:
                {
                    Console.Write("Enter a closing word: ");
                    string closingWord = (Console.ReadLine() ?? "").Trim();
                    bool isGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                    string firstThree = closingWord.Length >= 3 ? closingWord.Substring(0, 3) : closingWord;
                    bool endsWithExclamation = closingWord.EndsWith("!");
                    int spaceIndex = closingWord.IndexOf(' ');

                    Console.WriteLine();
                    Console.WriteLine(divider);
                    Console.WriteLine($"Equals: '{closingWord}' matches 'goodbye': {isGoodbye}");
                    Console.WriteLine($"First 3 characters (Substring): '{firstThree}'");
                    Console.WriteLine($"Ends with '!': {endsWithExclamation}");
                    Console.WriteLine($"Space index: {spaceIndex}");
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine(divider);
                    break;
                }

            }

        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value = 0;
        bool ok = false;

        do
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (input == null)
            {
                return 6; // Return exit code if no more input (tests exhausted stdin)
            }

            input = input.Trim();
            ok = int.TryParse(input, out value);

            if (!ok || value < min || value > max)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                ok = false;
            }
        }
        while (!ok);
        return value;
    }

    private static double ReadDouble(string prompt)
    {
        double value = 0;
        bool ok = false;

        do
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (input == null)
            {
                return 0; // Return 0 if no input available
            }

            input = input.Trim();
            ok = double.TryParse(input, out value);

            if (!ok)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                ok = false;
            }
        }
        while (!ok);
        return value;
    }

}
