// When hiding words, the program randomly selects only from words that are not already hidden. This avoids over doing on words that are already hidden.
// When the scripture is completely hidden, the program shows a ending message and ends automatically.

using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input) &&
                input.Trim().ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Good job!");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
