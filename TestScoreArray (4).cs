using System;
using static System.Console;
class TestScoreArray
{
    static void Main()
    {
        int[] intArray = { 85, 98, 100, 73, 67, 82, 92, 87 };
        WriteLine("The eight numbers are 85, 98, 100, 73, 67, 82, 92, 87.");
        int total = 0;
        for (int i = 0; i < 8; i++)
        {
            total = total + intArray[i];
        }
        double average = (double)total / 8;
        WriteLine("The average is {0}0", average);
    }
}