using System;
namespace practiceStuff.UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speak thou name, mortal.");
            //WriteLine is the user input prompt, let's user type in stuff
            String name = Console.ReadLine();
            //ReadLine literally "read the thing" that the user typed in

            Console.WriteLine("Greatings quote on quote human with the name " + name + ".");

            Console.WriteLine("How many revolutions have you bear witness to?");
            int age = Convert.ToInt32(Console.ReadLine());
            //yeah you have to type cast it, c# cries when you dont
            //Console.ReadLine(Convert.ToInt32()) dont work, it wrong

            Console.WriteLine("So you are " + age + " now, mortal.");        
        }
    }
}