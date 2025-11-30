using System;

// In the Reflection activity, reflection questions are chosen randomly without repeating until every question
// has been used at least once during that session. Only after all have been used then questions will start to repeat.

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;

                case "2":
                    activity = new ReflectionActivity();
                    break;

                case "3":
                    activity = new ListingActivity();
                    break;

                case "4":
                    running = false;
                    continue;

                default:
                    Console.WriteLine("Please enter a valid option (1-4).");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    continue;
            }

            activity.Run();

            Console.WriteLine();
            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
        }
    }
}
