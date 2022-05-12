using System;

namespace GC_CircleObjects
{
    internal class Program
    {
        public class Circle
        {
            // trying to figure out build specs 1g & 1h
            private double R;
            public double r
            {
                get => R;
                set => R = value;
            }

            // I have consolidated the formatting methods with their matching calculation methods
            // Using "Math.Round" made more sense to me, rather than adding extra steps for formatting
            public static double CalculateCircumference(double r)
            {
                return Math.Round(2 * Math.PI * r, 2);
            }
            public static double CalculateArea( double a )
            {
                return Math.Round(Math.PI * Math.Pow(a, 2), 2);
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
                    Console.WriteLine("Circumference: " + Circle.CalculateCircumference(circle.r));
                    Console.WriteLine("Area: " + Circle.CalculateArea(circle.r));
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
                        // if extra time, make this ask again
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
