using System;
namespace practiceStuff.Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Constants
                >>immutable value which are known at compile time
                >>doesnt change for the life of the program
                >>literally constant or unchanging yada yada
                >>cannot be updated when the tag (const) has been added. it lit wotn run if you try
            */

            const double pi = 3.14159;
            //pi = 456564;
            
            Console.WriteLine(pi);
        }
    }
}