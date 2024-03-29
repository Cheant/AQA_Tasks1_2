﻿using System;
using Tasks12Library;

namespace Tasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            Circle circle = new Circle(calculation.GetNotNegativeValue("Radius", "Circle"));
            circle.PrintRadiusCircleArea();

            Square square = new Square(calculation.GetNotNegativeValue("Side", "Square"));
            square.PrintSideSquareArea();

            calculation.PrintInsertFigureResult(circle.Area, square.Area);

            Console.ReadKey();
        }
    }
}