using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main()
        {
            // Prompt the user to enter the lengths of the three sides
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");

            // Read the lengths from the console
            Console.Write("Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Determine the type of the triangle
            string triangleType = GetTriangleType(side1, side2, side3);

            // Display the result
            Console.WriteLine($"The triangle is {triangleType}");
        }

        static string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }

    }
}
