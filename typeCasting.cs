using System;
using System.Diagnostics;
namespace practiceStuff.typeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Type Casting
                >>changing data type from one to another like string to int n the other stuff
            */

            //Double(decimal) to => Int(integer/whole number)

            double x = 754.62;
            int y = Convert.ToInt32(x);
            int z = (int)x;
            /* Convert.ToInt32
                >>converts the double(decimal number) into an int(integer/whole number) data type
                >>the 32 is a matter of size, in here it's 32bit
                >>there are 3 sizes to this: 16, 32, and 64.
                    ~ 16-bit (short): Can only fit up to 5 digits (max 32,767).
                    ~ 32-bit (int): Can fit up to 10 digits (max 2,147,483,647).
                    ~ 64-bit (long): Can fit up to 19 digits (max 9,223,372,036,854,775,807).
                >>Note!!<<
                    even if a number is within the same amount of digits, if it's range is higher than the specified amount, it will break the stupid box    
            */
            //c# and its obsession with stupid boxes
            
            Console.WriteLine(x);
            Console.WriteLine(x.GetTypeCode());
            // output will look like >> Double
            //Console.WriteLine(x.GetType());
            /* output will look like >> System.Double
                just adds System. before the data type being displayed 
            */

            Console.WriteLine(y);
            Console.Write(y.GetTypeCode());
            // since this one is type casted the output will look like this >> Int32
            // data type: Int | bit size: 32

            Console.WriteLine(z);
            //this on the other hand doesnt round off, it just chops the decimal off so it's output is just gon be 754
//_____________________________________________________________________________________________________________________________________________________________________________________________
            //Int(whole number) to => Double(decimal)

            int a = 543;
            //double b = Convert.ToDouble(a);
            //this converts the int into a decimal number but because the indicated number is whole, it technicaly remains whole despite the data type changing 
            double b = Convert.ToDouble(a) + 0.3245;
            //this doesn't just converts it BUT will add a decimal point making it a full fledge double.
            //idiot, dont forget you cant have [double b = Convert.ToDouble(a);] and [double b = Convert.ToDouble(a) + 0.3245;] or else it wont run. computer will get confused.
            Console.WriteLine(b);
            Console.WriteLine(b.GetTypeCode());
//_____________________________________________________________________________________________________________________________________________________________________________________________
            //Int(number) to => String(text)

            int c = 53647;
            String d = Convert.ToString(c);
            //this makes it into a text and no longer is deemed a number by the computer. cant do math with it no moe

            Console.WriteLine(d);
            Console.WriteLine(d.GetTypeCode());

            /*
            int e = c + d;
            Console.WriteLine(e);
            */
            //this resulted in an error because this is INT + STRING, computer is angy. it also hates algebra
            
            /*
            int e = 67;
            String thingy = "n";
            >>not exactly alegbra, kinda makes it look like it tho. it still runs n turns to 67n

            Console.WriteLine(e + thingy);
            int f = e + thingy;
            Console.WriteLine(f);
            >>nope, doesnt run
            */
//____________________________________________________________________________________________________________________________________________________________________________________________            
            //String(text) to => Char(single Character)
            //Char is a single character or letter. cant hold a word, just a letter

            String f = "&";
            char g = Convert.ToChar(f);
            Console.WriteLine(g);
            Console.WriteLine(g.GetTypeCode());
//____________________________________________________________________________________________________________________________________________________________________________________________
            //String to Bool
            //Bool or Boolean = true/false

            String potato = "true";
            bool h = Convert.ToBoolean(potato);
            Console.WriteLine(h);
            Console.WriteLine(h.GetTypeCode());

        }
    }
}
