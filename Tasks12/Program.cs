using System;
using Tasks12Library;

namespace Tasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");
            Circle circle = new Circle(Console.ReadLine());
            circle.PrintArea();

            Console.WriteLine("Enter Side: ");
            Square square = new Square(Console.ReadLine());
            square.PrintArea();

            InsertShape insertShape = new InsertShape(circle.Area, square.Area);
            insertShape.PrintResult();

            Console.ReadKey();
        }
    }
}