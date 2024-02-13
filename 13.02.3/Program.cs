using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a shape to calculate the area:\n1. Circle\n2. Parallelogram\n3. Square\n4. Triangle\n5. Trapezoid");
        Console.Write("Enter your choice (1-5): ");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid choice. Exiting program.");
            return;
        }
        Console.Clear();
        switch (choice)
        {
            case 1:
                CalcCircle();
                break;
            case 2:
                CalcParallelogram();
                break;
            case 3:
                CalcSquare();
                break;
            case 4:
                CalcTriangle();
                break;
            case 5:
                CalcTrapezoid();
                break;
        }
    }

    static void CalcCircle()
    {
        Console.WriteLine("Circle:\n   * * *\n *       *\n*         *\n *       *\n   * * *");
        Console.Write("Enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of circle with radius {r}: {Math.Round(Math.PI * r * r, 2)}");
    }

    static void CalcParallelogram()
    {
        Console.WriteLine("Parallelogram:\n   ________\n  /       / \n /       /  \n/_______/   ");
        Console.Write("Enter the base of the parallelogram: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the parallelogram: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of parallelogram with base {b} and height {h}: {Math.Round(b * h, 2)}");
    }

    static void CalcSquare()
    {
        Console.WriteLine("Square:\n _______\n|       |\n|       |\n|       |\n|_______|");
        Console.Write("Enter the side length of the square: ");
        double s = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of square with side {s}: {Math.Round(s * s, 2)}");
    }

    static void CalcTriangle()
    {
        Console.WriteLine("Triangle:\n    /\\\n   /  \\\n  /    \\\n /______\\");
        Console.Write("Enter the base of the triangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the triangle: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of triangle with base {b} and height {h}: {Math.Round(0.5 * b * h, 2)}");
    }

    static void CalcTrapezoid()
    {
        Console.WriteLine("Trapezoid:\n   _________\n  /         \\\n /           \\\n/_____________\\");
        Console.Write("Enter the first base of the trapezoid: ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second base of the trapezoid: ");
        double b2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the trapezoid: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of trapezoid with bases {b1} and {b2} and height {h}: {Math.Round(0.5 * (b1 + b2) * h, 2)}");
    }
}
