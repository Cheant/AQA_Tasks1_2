using System;
using Tasks12Library;

namespace Tasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of Circle: ");
            Validation validation1 = new Validation(Console.ReadLine());
            validation1.GetValidatedValue();

            Calculation circleCalculation = new Calculation(validation1.ValidatedValue);
            circleCalculation.CalculateCircleArea();

            Console.WriteLine("Enter Side of Square: ");
            Validation validation2 = new Validation(Console.ReadLine());
            validation2.GetValidatedValue();

            Calculation squareCalculation = new Calculation(validation2.ValidatedValue);
            squareCalculation.CalculateSquareArea();

            InsertShape insertShape = new InsertShape(circleCalculation.AreaResult, squareCalculation.AreaResult);
            insertShape.PrintResult();

            Console.ReadKey();
        }
    }
}