using System;

namespace GC_CircleObjects
{
    internal class Program
    {
        public static double CalculateCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double CalculateArea(double a)
        {
            return Math.PI * Math.Pow( a, 2 );
        }
        public class Circle
        {
            public double r, c;
        }
        static void Main( string[] args )
        {
            Console.WriteLine("Welcome to the Circle Tester!");
            Console.Write("Enter radius: ");

            bool tryAgain = true;
            int circlesCreated = 0;
            while (tryAgain)
            {
                try
                {
                    string radiusInput = Console.ReadLine();
                    Circle circle = new Circle();
                    double r = Double.Parse(radiusInput);
                    Console.WriteLine("Circumference: " + Math.Round(CalculateCircumference(r), 2));
                    Console.WriteLine("Area: " + Math.Round(CalculateArea(r), 2));
                    circlesCreated++;
                    Console.WriteLine("Continue (y/n?)");
                    string response = Console.ReadLine().ToLower();
                    if (response == "n")
                    {
                        
                        tryAgain = false;
                    }
                    else if (response == "y")
                    {
                        Console.Write("Enter radius: ");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid response.");
                        tryAgain = false;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please input a valid number.");
                }
            }
            Console.WriteLine($"You created {circlesCreated} Circle object(s). Goodbye!");
        }
    }
}
