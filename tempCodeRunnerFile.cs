using System;
using static System.Console;
class PaintingEstimate
{
    static void Main()
    {

        Write("Enter length of the room in feet >>");
        double length = Convert.ToDouble(ReadLine());

        Write("Enter width of room in feet >>");
        double width = Convert.ToDouble(ReadLine());

        double cost = CalculatePaintingCost(length, width);
        WriteLine("Cost of painting the room is ${0:F2}", cost);
    }
    private static double CalculatePaintingCost(double length, double width)
    {
        const double pricePerSquareFoot = 12.0;
        const double height = 15.0;

        double areaOfWalls = 2 * height * (length + width);
        double areaOfCeiling = length * width;
        double totalArea = areaOfWalls + areaOfCeiling;

        double cost = totalArea * pricePerSquareFoot;
        return cost;
    }
}
