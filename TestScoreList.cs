using System;
using System.Collections.Generic;
using static System.Console;

class TestScoreList
{
    static void Main()
    {
        List<int> scores = new List<int> { 85, 98, 100, 73, 67, 82, 92, 87 };
        double total = 0;
        WriteLine("The eight numbers are 85, 98, 100, 73, 67, 82, 92, 87.");
        for (int i = 0; i < scores.Count; i++)
        {
            total += scores[i];
        }

        double average = total / scores.Count;
        WriteLine("The average is {0:F2}", average);

        WriteLine("Please input a new score >>");
        int newScore = Convert.ToInt32(ReadLine());
        scores.Add(newScore);

        WriteLine();
        for (int i = 0; i < scores.Count; i++)
        {
            Write("{0} ", scores[i]);
        }

        total = 0;
        for (int i = 0; i < scores.Count; i++)
        {
            total += scores[i];
        }

        average = total / scores.Count;
        WriteLine("\nThe average is {0:F2}", average);
    }
}
