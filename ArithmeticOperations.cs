using System;
namespace practiceStuff.ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int potatoes = 3;

            //Addition
            int potatoes_1 = potatoes + 1;
            /* potatoes += 1;
                >this works too, it's a shortcut of the one above
                >doesn't need the "int" tag when using this one cause it's already declared in "int potatoes = 2;" or computer be angy
                > += is an Addiction Assignment Operater, basically means take the thing in the "box" and add more to it 
                >>NOTE!!<<
                    the catch on this is you cannot make a new "box" like with "potatoes_1"
                    (potatoes_1 += 1) wouldn't work because it technically doesn't exist yet
            */
            /*  potatoes++;
                >this also works but strictly only adds 1
                >same catch as before
            */

            //Subtraction >> basically same shit but subtraction, same structure
            int potatoes_2 = potatoes - 1;
            /*
            potatoes -= 1;
            potatoes--;
            */

            //Multiplication >> same stuff but you multiply them
            int potatoes_3 = potatoes * 2;
            //potatoes *= 2;
            /*
            >>Note!!<<
            (potatoes**;) doesnt exist because it's stupid. anything that is multiplied by 1 is literally the number itself
            so that thing doesnt even exist in C#
            */

            //Divission >> same stuff but you divide stuff
            int potatoes_4 = potatoes / 2;  //this is an 'int' data type so the answer will be still a whole number
            //  potatoes /= 2;

            double potatoes_5 = Convert.ToDouble(potatoes) / 2; //gotta convert the thing first if ya wanna get the exact answer with the decimal
            /*  double potatoes_5 = potatoes / 2.0; also works 
            Adding .0 turns the whole math equation into a double
            */
            /* potatoes /= 2.0; is not gonna work
            the thing on top only worked because I made a new box that is capable of holding a decimal value.
            2.0 isnt gonna flip the switch on the thing up there declared as an int by this method
            */

            Console.WriteLine(potatoes);
            Console.WriteLine(potatoes_1);
            Console.WriteLine(potatoes_2);
            Console.WriteLine(potatoes_3);
            Console.WriteLine(potatoes_4);
            Console.WriteLine(potatoes_5);
//______________________________________________________________
            int carrots = 10;

            int remainder = carrots % 3;
//          % >> is "Modullo Operator" or the "Remainder Finder" 
//          / >> is used for division but is only focused on the 'divinding part'

            double turnips = 5;
            double remainder_2 = turnips % 2.3;
//          also works with decimals, kinda weird tho          

            Console.WriteLine(remainder);
            Console.WriteLine(remainder_2);
        }
    }

}