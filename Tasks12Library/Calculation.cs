using System;

namespace Tasks12Library
{
    public class Calculation
    {

        public double GetNotNegativeValue(string valueName, string figureName)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter {valueName} of {figureName}: ");
                var enteredValue = Console.ReadLine();
                bool isParsed = double.TryParse(enteredValue, out double validatedValue);
                if (isParsed && validatedValue > 0)
                {
                    return Math.Round(validatedValue, 2);
                }

                if (!isParsed)
                {
                    Console.WriteLine($"Entered value is not number.{Environment.NewLine}");
                }

                if (isParsed && validatedValue <= 0)
                {
                    Console.WriteLine($"Entered value is negative or zero.{Environment.NewLine}");
                }
            }
            Console.WriteLine($"Random value will be set after three failed attempts.{Environment.NewLine}");
            return Math.Round(GetRandomNumber());
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