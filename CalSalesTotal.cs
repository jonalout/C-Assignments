using static System.Console;
class CalSalesTotal
{
    static void Main()
    {
        double price;
        int quantity;
        WriteLine("Enter the unit price in $ >>");
        price = double.Parse(ReadLine());

        WriteLine("Enter the quantity of purchase >>");
        quantity = int.Parse(ReadLine());

        double totalSales = CalSales(price, quantity);

        WriteLine("The total purchase is {0:C} ", totalSales);
    }

    private static double CalSales(double price, int quantity)
    {
        return price * quantity;
    }
}