using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        float userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            userNumber = float.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float max = numbers[0];
        foreach (float number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}