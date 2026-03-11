using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        string userName = GetName();
        int favNum = GetFavoriteNumber();
        int squareNumber = SquareNumber(favNum);

        DisplayResult(userName, squareNumber);
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}