using System;
/*is the toolbox.
"using" is a command
"System" IS the toolbox being used so it's not as ease all the time
differs depending on what the project/program needs, different tool kits may be used 
*/

namespace practiceStuff.Program
/*address thingy
This tag tells the computer: "This specific piece of code lives in the 'Program' neighborhood."
It’s a fence to keep your code from wandering off and starting fights with other random files.
Name it according to the folder it's in. in this case it's inside "practiceStuff" then add a dot(.) then name it whatever or according to your file name
*/
{
    class Program
    /*Class is just yet another box, can be named anything. the tutorial is just named Program.
      c# likes unboxing a hell lot  
    */
    {
        static void Main(string[] args)
        /*gemini says it's the ignition thingy, just never have it absent.
        static  =   Skip the building process; just run.
        void    =   I'm not giving you a result/receipt.
        Main    =   must always be capital; The only door the computer can see.
        args    =   A basket for extra terminal data.        
        */
        {
            Console.WriteLine("wOt the fOcK");
            Console.WriteLine("wHy So HaBa?!?!?!");
            Console.WriteLine("Kay python print() lang yan eh");
            Console.Beep();
            /*Console. >> this ia added to tags when you wanna use the terminal or display stuff there like text n numbers. dont forget the dot(.) because it's the connector chuchu
              is yet another box in a box of boxes
              is one of the tools within a toolbox that also still is a fucking box, go figure  
            */
        }
    }
}