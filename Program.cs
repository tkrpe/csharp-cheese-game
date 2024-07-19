using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {

        Console.Clear();

        Console.Beep();

        Console.Write("Please enter your username -> ");

        string username = Console.ReadLine();

        Console.Beep();

        Console.WriteLine("Hello, " + username + "! Welcome to a random game I made all in C#!");
        Thread.Sleep(1500);
        Console.WriteLine("You might be asking me \"What the actual hell is this game?\".");
        Thread.Sleep(1750);
        Console.WriteLine("Well... you're about to find out!");

        Console.Write("Do you love eating cheese? [Y/N] -> ");

        string question = Console.ReadLine();

        if (question == "Y")
        {
            Console.WriteLine("Great Choice! Thank you for playing!");
        } else if (question == "N")
        {
            Console.WriteLine(">:( YOU MADE ME ANGRY!!!!!!!");
        } else if (question == "y")
        {
            Console.WriteLine("Great Choice! Thank you for playing!");
        } else if (question == "n")
        {
            Console.WriteLine(">:( YOU MADE ME ANGRY!!!!!!!");
        }
        
    }
}