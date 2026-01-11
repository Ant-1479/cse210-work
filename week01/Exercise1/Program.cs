using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string first = Console.ReadLine();
         
        Console.WriteLine("What is your favourite colour?");
        string colour = Console.ReadLine();

        Console.WriteLine("Hello " + first + ", your favourite colour is " + colour + "!");

    }
}