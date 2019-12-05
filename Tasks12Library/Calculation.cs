using System;

namespace Tasks12Library
{
    public class Calculation
    {
        private double validatedValue;

        public double GetValidation()
        {
            for (int i = 0; i < 3; i++)
            {
                if (double.TryParse(Console.ReadLine(), out validatedValue) && validatedValue > 0)
                {
                    break;
                }
                else if (i == 2)
                {
                    Random randomNumber = new Random();
                    validatedValue = Convert.ToDouble(randomNumber.Next(5, 51) / 10.0);
                }
                else
                {
                    Console.WriteLine("Entered value is invalid. Please enter a positive numeric value: ");
                }
            }
            return Math.Round(validatedValue, 2);
        }

        public void PrintResult(double circleArea, double squareArea)
        {
            if (Math.Sqrt(circleArea / Math.PI) <= Math.Sqrt(squareArea) / 2)
            {
                Console.WriteLine($"It is possible to put the Circle into the Square");
            }
            else if (Math.Sqrt(circleArea / Math.PI) >= Math.Sqrt(squareArea / 2))
            {
                Console.WriteLine($"It is possible to put the Square into the Circle");
            }
            else
            {
                Console.WriteLine($"It is impossible to put the Circle into the Square or the Square into the Circle");
            }
        }
    }
}