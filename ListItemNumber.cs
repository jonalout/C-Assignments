using static System.Console;
using System.Collections.Generic;

class ListItemNumber
{
    static void Main()
    {
        List<int> items = new List<int> { 101, 108, 201, 213, 266, 304, 311, 409, 411, 412 };
        List<int> backOrdered = new List<int>();

        while (true)
        {
            Write("Enter item number to search 0 to exit>> ");
            int searchItem = int.Parse(ReadLine());

            if (searchItem == 0)
            {
                WriteLine("Have a nice day!");
                break;
            }

            if (items.Contains(searchItem))
            {
                WriteLine("The item is found");
            }
            else
            {
                backOrdered.Add(searchItem);
                WriteLine("Item not found, back ordered");
                foreach (int item in backOrdered)
                {
                    Write(item + " ");
                }
                WriteLine();
            }
        }
    }
}