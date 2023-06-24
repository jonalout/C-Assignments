using System;
using static System.Console;
using System.Collections.Generic;

class AverageScoreArray
{
    static void Main()
    {
        List<int> myScores = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Write("Enter an integer test score >> ");
            int inputNum = Convert.ToInt32(ReadLine());
            myScores.Add(inputNum);
        }
        WriteLine();

        WriteLine("The integers entered are:");
        for (int i = 0; i < myScores.Count; ++i)
        {
            WriteLine(myScores[i]);
        }
        WriteLine();

        int total = 0;
        for (int i = 0; i < myScores.Count; i++)
        {
            total += myScores[i];
        }
        double average = (double)total / myScores.Count;
        WriteLine("The average score is {0}0", average);
    }
}