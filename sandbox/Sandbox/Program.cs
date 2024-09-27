using System;
using System.Runtime.CompilerServices;

class Program
{
    static void AwesomeFunction(int x)
    {
        Console.WriteLine($"The argumment {x} was passed to the awesome funciton");
    }
    static void Main(string[] args)
    {
        AwesomeFunction(65);
        List<int> numberList;
        numberList = new();

        int input=-1;
        while (input != 0) 
        {
            Console.Write("Enter a number: ");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);
            if (input != 0)
            {
                numberList.Add(input);
            }
        }

        foreach (int item in numberList)
        {
            Console.WriteLine(item);
        }

    }
}