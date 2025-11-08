using System;
class Program
{
    static void Main(string[] args)
    {
        Random rgr = new Random();
        int magicnum = rgr.Next(1, 101);
        int guess = -1;

        while (guess != magicnum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}