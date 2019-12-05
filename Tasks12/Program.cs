using System;
using Tasks12Library;

namespace Tasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            Console.WriteLine("Enter Radius of Circle: ");
            Circle circle = new Circle(calculation.GetValidation());
            circle.CircleArea();

            Console.WriteLine("Enter Side of Square: ");
            Square square = new Square(calculation.GetValidation());
            square.SquareArea();

            calculation.PrintResult(circle.Area, square.Area);

            Console.ReadKey();
        }
    }
}