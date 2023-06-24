using System;
using static System.Console;
class NumDisplay
{
    static void Main()
    {
        Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(ReadLine());

        Write("Enter the number of columns: ");
        int columns = Convert.ToInt32(ReadLine());

        int num = 1;
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                Write((num++)+"\t");
            }
            WriteLine();
        }
    }
}