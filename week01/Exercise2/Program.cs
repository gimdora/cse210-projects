using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float grade_flt = float.Parse(grade);

        if (grade_flt >= 90)
            Console.WriteLine("A");
        else if (grade_flt >= 80)
            Console.WriteLine("B");
        else if (grade_flt >= 70)
            Console.WriteLine("C");
        else if (grade_flt >= 60)
            Console.WriteLine("D");
        else if (grade_flt < 60)
            Console.WriteLine("F");

        if (grade_flt >= 70)
            Console.WriteLine("Congratulations! You have passed!");
        if (grade_flt < 70)
            Console.WriteLine("You have not passed. Don't worry, you can do better next time!");

        Console.Write($"{grade_flt}");
    }
}