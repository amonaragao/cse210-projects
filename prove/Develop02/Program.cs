using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static Journal journal = new Journal();
    private static Random random = new Random();
    private static List<string> prompts = new List<string>
    {
        "How would you describe your spirituality today?",
        "If you'd had another hour during the day, how would you have spent it?",
        "What scripture just popped into your head right now?",
        "How can you make tomorrow (even) better than today?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was your first crush?",
        "What is your favorite song?",
        "What is your favorite food?",
        "Who is the best football player? Pelé or Maradona?",
        "Do you like surfing?",
        "Tell me about your dream.",
        "Tell me about yourself."

    };

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Welcome to your Journal. Choose an option:");
            Console.WriteLine("1 - Write a new entry");
            Console.WriteLine("2 - Show Journal Display");
            Console.WriteLine("3 - Save Journal");
            Console.WriteLine("4 - Load the Journal");
            Console.WriteLine("5 - Exit");
            Console.WriteLine();

            int option = ReadInput();

            switch (option)
            {
                case 1:
                    JournalNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Option. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void JournalNewEntry()
    {
        string prompt = RandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Write your answer: ");
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;

        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = date
        };

        journal.AddEntry(entry);
    }

    static void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    static void SaveJournalToFile()
    {
        Console.Write("Write the filename to save the Journal: ");
        string filename = Console.ReadLine();
        journal.SaveJournal(filename);
        Console.WriteLine("Journal Save.");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Write the filename to load the Journal:");
        string filename = Console.ReadLine();
        journal.LoadJournal(filename);
        Console.WriteLine("Journal Load.");
    }

    static string RandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    static int ReadInput()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid Entry. Try again.");
        }
        return value;
    }
}