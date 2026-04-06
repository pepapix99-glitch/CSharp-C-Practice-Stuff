using System;
namespace practiceStuff.MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 7;

            double a = Math.Pow(x, 3);
            // Math.Pow() >> (power, exponent stuff) = it basically 5 raised to 3
            // 5^3 = 5 x 5 x 5

            double b = Math.Sqrt(x);
            // Math.Sqrt() >> squareroot
            // haha, squirt
            
            double c = Math.Abs(b);
            // Math.Abs() >> (absolute value) the number farthest from 0
            // even if it's a negative number, it will turn positive...
            // it like steps forward n steps backward, still steps made nonetheless uwu
            // unga bungga

            double d = Math.Round(b);
            // Math.Round() >> (round off) rounds off to the nearest whole number
            // this one rounds up if the closest decimal numbah is 5+, if not then just cuts off

            double e = Math.Ceiling(b);
            // Math.Ceiling() >> now this one rounds up the nearest whole numbah
            /* >>Note<<
                will always round up even if the closest decimal number is below 5
                rules doesn't apply, it stays high af
            */

            double f = Math.Floor(b);
            // Math.Floor() >> this one the other hand rounds down
            /* >>Note<<
                will only chop off the decimal, even if the closest decimal is 5+
                bitch stays depressed on tha fuckin FLOOR
            */

            double g = Math.Max(x, y);
            // Math.Max() >> (maximum) takes the one with the highest value

            double h = Math.Min(x, y);
            // Math.Min() >> (minimum) the one with the lowest value

            /*  >>Note<<
                Max n Min can only compare 2 variables at a time. mention more n you get an error
            */

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            //Console.WriteLine(a/b);
        }
    }
}