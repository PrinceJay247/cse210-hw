using System;

class Program
{
    static void Main(string[] args)
    {
        {
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name:");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite number:");
        int favNum = int.Parse(Console.ReadLine());

        int squareNumber = favNum * favNum;

        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
    }
}