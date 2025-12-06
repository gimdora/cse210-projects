using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =
        [
            new Running(new DateTime(2025, 12, 7), 30, 3.0),
            new Cycling(new DateTime(2025, 12, 9), 45, 12.0),
            new Swimming(new DateTime(2025, 12, 10), 40, 30),
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
