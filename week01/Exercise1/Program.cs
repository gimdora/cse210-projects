using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        first_name = textInfo.ToTitleCase(first_name.ToLower());
        last_name = textInfo.ToTitleCase(last_name.ToLower());

        Console.WriteLine();
        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");
    }
}