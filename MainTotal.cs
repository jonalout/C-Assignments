using System;
using static System.Console;
class Program
{
    static void Main()
    {
        double price;
        int quantity;

        Write("Enter the unit price in $ >>");
        price = Convert.ToDouble(ReadLine());

        Write("Enter the quantity of purchase >>");
        quantity = Convert.ToInt32(ReadLine());

        double totalSales = CalSales(price, quantity);
        WriteLine("The total purchase is {0:C}", totalSales);
    }

    static double CalSales(double price, int quantity)
    {
        return price * quantity;
    }
}
