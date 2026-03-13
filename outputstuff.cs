using System;
namespace outputstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("confusing");
            /*Console.Write(""); >>makes you display text with no line for itself
            >>no personal space
            */
            
            Console.WriteLine("stuff");
            //Console.WriteLine(""); >>makes you display text stuff, has its own line

            //double slash is comment in c#
            /*
            this slash-asterisk combo makes multi-linear comment
            can make paragraphes with these, invissible paragraphs purely code notes
            */ 

            Console.WriteLine("\taaaaahh!!");
            /*Console.WriteLine("\t"); -adds tab on the text. \t literally TAB
                ex: Consoel.WriteLine("inhale");
                    Console.WriteLine("\taaaaaaaaaaaahh!!");
                output: inhale
                            aaaaaaaaaaaahh!!
            */

            Console.WriteLine("wh\bat");
            /*Console.WriteLine("\b"); -removes one letter before it; \b literally means BACKSPACE
                output: wat
            */

            Console.WriteLine("Pepa\nPix");
            /*Console.WriteLine("\n"); - adds a new line
                output: Pepa
                        Pix
            */            

            Console.ReadKey();
            //hides the unnecessary stuff under the displayed text, specifically the path n stuff
            
            Console.Beep();
            //uhh makes beeping sounds
            //dunno why it doesn't work here in vscode. it works on visual studio tho 


            //what a fucking diva this language is
        }
    }    
}