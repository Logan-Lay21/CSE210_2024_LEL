using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),SquaredNumber(PromptUserNumber()));
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string entry = Console.ReadLine();
        int favNum = int.Parse(entry);
        return favNum;
    }
    static int SquaredNumber(int num)
    {
        int square = num * num;
        return square;
    }
    static void DisplayResult(string userName, int sqrNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNum}");
    }
    
}