using System;

namespace GC_CircleObjects
{
    internal class Program
    {
        public class Circle
        {
            /*
            private static double Radius;
            public static double r
            {
                get { return Radius; }
                set { Radius = r; }
            }
            */

            public double r;

            public static double CalculateCircumference(double r)
            {
                return 2 * Math.PI * r;
            }
            public static double CalculateArea( double a )
            {
                return Math.PI * Math.Pow(a, 2);
            }
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
                    circle.r = Double.Parse(radiusInput);
                    Console.WriteLine("Circumference: " + Math.Round(Circle.CalculateCircumference(circle.r), 2));
                    Console.WriteLine("Area: " + Math.Round(Circle.CalculateArea(circle.r), 2));
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
