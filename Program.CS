using System;
class Program
{
    static double Circle(double radius)
    {
        return Math.PI * radius * radius;
    }
    static double Rectangle(double length, double width)
    {
        return length * width;
    }
    static double Triangle(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
    static double Trapezoid(double a, double b, double height)
    {
        return 0.5 * (a + b) * height;
    }
    static double Parallelogram(double baseLength, double height)
    {
        return baseLength * height;
    }
    static double Square(double side)
    {
        return side * side;
    }
    static double Ellipse(double a, double b)
    {
        return Math.PI * a * b;
    }
    static void Main()
    {
        string choice = "";
        while (choice != "X")
        {
            Console.WriteLine("AREA CALCULATOR");           
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Trapezoid");
            Console.WriteLine("5. Parallelogram");
            Console.WriteLine("6. Square");
            Console.WriteLine("7. Ellipse");
            Console.WriteLine("X. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine().ToUpper();
            double area = 0;
            double a, b, height;
            switch (choice)
            {
                case "1":
                    Console.Write("Enter the radius: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    area = Circle(a);
                    Console.WriteLine("Area = " + area);
                    break;
                case "2":
                    Console.Write("Enter the length: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    area = Rectangle(a, b);
                    Console.WriteLine("Area = " + area);
                    break;
                case "3":
                    Console.Write("Enter the base: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    area = Triangle(a, height);
                    Console.WriteLine("Area = " + area);
                    break;
                case "4":
                    Console.Write("Enter the first parallel side: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second parallel side: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    area = Trapezoid(a, b, height);
                    Console.WriteLine("Area = " + area);
                    break;
                case "5":
                    Console.Write("Enter the base: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    area = Parallelogram(a, height);
                    Console.WriteLine("Area = " + area);
                    break;
                case "6":
                    Console.Write("Enter the side length: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    area = Square(a);
                    Console.WriteLine("Area = " + area);
                    break;
                case "7":
                    Console.Write("Enter the first semi-axis: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second semi-axis: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    area = Ellipse(a, b);
                    Console.WriteLine("Area = " + area);
                    break;
                case "X":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
