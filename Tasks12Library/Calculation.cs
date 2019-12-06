using System;

namespace Tasks12Library
{
    public class Calculation
    {
        private double _validatedValue = 0;

        public double GetValidatedValue(string valueName, string figureName)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter {valueName} of {figureName}: ");
                if (!(double.TryParse(Console.ReadLine(), out _validatedValue)))
                {
                    Console.WriteLine("Entered value is not number.\n");
                    continue;
                }
                if (_validatedValue <= 0)
                {
                    Console.WriteLine("Entered value is negative or zero.\n");
                    continue;
                }
                break;
            }

            if (_validatedValue <= 0)
            {
                Console.WriteLine("Random value will be set after three failed attempts.\n");
                _validatedValue = GetRandomNumber();
            }
            return Math.Round(_validatedValue, 2);
        }

        private double GetRandomNumber()
        {
            Random random = new Random();
            return random.NextDouble() * (Constants.randomMaximum - Constants.randomMinimum) + Constants.randomMinimum;
            //return Convert.ToDouble(randomNumber.Next(5, 51) / 10.0);
        }

        public void PrintInsertFigureResult(double circleArea, double squareArea)
        {
            if (Math.Sqrt(circleArea / Math.PI) <= Math.Sqrt(squareArea) / 2)
            {
                Console.WriteLine($"It is possible to put the Circle into the Square.");
            }
            else if (Math.Sqrt(circleArea / Math.PI) >= Math.Sqrt(squareArea / 2))
            {
                Console.WriteLine($"It is possible to put the Square into the Circle.");
            }
            else
            {
                Console.WriteLine($"It is impossible to put the Circle into the Square or the Square into the Circle.");
            }
        }
    }
}