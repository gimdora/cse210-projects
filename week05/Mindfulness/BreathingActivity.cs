using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("\nBreathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}
