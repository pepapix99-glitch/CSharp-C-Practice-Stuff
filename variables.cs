using System;

namespace practiceStuff.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 123; //initialization

            int y = 321; //declaration n initialization, shortcut version of the one above

            int n = x + y;
            //the "n" here is the variable name that youre assigning variables too. can be anything you want

            /*
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(n);
            Console.WriteLine(n - x);
            */

            int age = 23;
            //Console.WriteLine("You are " + age);
            //Console.WriteLine("you'll turn " + (age + 1) + " next month!");
            /*Console.WriteLine($"you'll turn {age + 1} next month!");
                >>this also works but the dollar sign($) is important here, without it everything within the parethesis gets smooshed into one line.
                  without the $, output will literally be:
                        you'll turn {age + 1} next month!!
            */    

            double height = 5.3;
            //Console.WriteLine("you are " + height + "ft tall.");

            bool potato = true;
            //Console.WriteLine("Is thou a potato??" + potato);
            
            char symbol = '#'; //dont enclose it with double qoutations(""), it aint gon work
            //char >> holds only ONE character
            //Console.WriteLine(symbol);

            String name = "PepaPix"; //now you use double quotations here because apostrophies('') aint gon work... touche
            //Console.WriteLine("My gamertag is " + name);

            String User_Name = name + symbol;
            Console.WriteLine("The ancient runes speaks of le name, " + User_Name + ". And thy coming is foretold.");

        }
    }

}