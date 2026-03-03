/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Alexander Hoang
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    private static StoryTemplate ChooseTemplate()
    {
        int choice;
        while (true)
        {
            Console.WriteLine("Choose a template:");
            Console.WriteLine("1) Debugging at the Zoo");
            Console.WriteLine("2) The Standup Meeting");
            Console.Write("Enter your choice (1 or 2): ");
            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 2)
            {
                break;
            }

            Console.WriteLine("Invalid input. Please enter a number between 1 and 2.");
            Console.WriteLine();
        }

        if (choice == 1)
        {
            return new StoryTemplate(
                "Debugging at the Zoo",
                new string[]
                {
                    "an emotion (ex: excited)",
                    "a plural noun",
                    "a verb that pairs with the emotion you used (ex: excited -> love, nervous -> fear, etc.)",
                    "an adjective",
                    "a verb",
                    "a verb",
                },
                "Today, I went on a class trip. Normally anyone would be {0}, however this zoo wasn’t any zoo, " +
                "it was a zoo for {1}. I {2} {1}! " +
                "The reason why I {2} {1} is because they can be {3}. " +
                "They {4} everywhere and most of all they know how to {5} really well. " +
                "If I had to describe this zoo, it would be a zoo for the {4} {1}.");
        }
        else
        {
            return new StoryTemplate(
                "The Standup Meeting",
                new string[]
                {
                    "a tech company name",
                    "a person's name",
                    "a UI thing (noun)",
                    "what page would that UI thing be on? (adjective)",
                    "an adjective that would describe a rabbid animal",
                    "what would you call a bunch of those rabbid animals? (plural noun)",
                    "an item to keep you awake (noun)",
                    "a verb ending in -ing and water (ex: chugging, sipping, spraying, etc.)",
                },
                "It’s the standard meeting at {0}, but this time was different than any other day. " +
                "You see, {1} was going to start us off, but {1} didn’t get enough sleep.\n\n" +
                "{1}'s report:\n" +
                "Today I was working on the {2} for our {3} page. " +
                "There were all sorts of {4} {5}, so I had to order some {4} {6}. " +
                "The {4} {5} never had a chance. " +
                "I had them {7} in no time.");
        }
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info("Starting word collection for template: " + template.Title);
        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString($"Enter {template.Prompts[i]}: ");
        }

        Console.WriteLine();
        return words;
    }

    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int number;
        bool ok;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            ok = int.TryParse(input, out number) && number >= min && number <= max;

            if (!ok)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
            }
        }
        while (!ok);
        return number;
    }

    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid value.");
            }
        }
    }
}
