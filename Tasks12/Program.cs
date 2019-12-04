using System;
using Tasks12Library;

namespace Tasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of Circle: ");
            Validation validation1 = new Validation();
            Calculation circleCalculation = new Calculation(validation1.GetValidatedValue());
            circleCalculation.CalculateCircleArea();

            Console.WriteLine("Enter Side of Square: ");
            Validation validation2 = new Validation();
            Calculation squareCalculation = new Calculation(validation2.GetValidatedValue());
            squareCalculation.CalculateSquareArea();

            InsertShape insertShape = new InsertShape(circleCalculation.AreaResult, squareCalculation.AreaResult);
            insertShape.PrintResult();

            Console.ReadKey();
        }
    }
}