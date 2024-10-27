using System;
using System.Dynamic;

// I took the original suggestion to exceed the requirements 
// by selecting only from the words that had not been chosen to be
// hidden. It was tricky but having the WinScripture object have 
// the boolean var and the string var really helped. You can see the
// loop that hides them in the scripture class, it is contained 
// within the method "RandomIndex."

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Scripture _s = new();
        string entry = "";
        _s.DisplayScripture();
        Console.WriteLine("\n\nType quit to exit the program, press enter to lose three words.");
        do {
            entry = Console.ReadLine();
            Console.Clear();
            if (_s.RandomIndex() == true) {
                entry = "quit";
                break;
            }
            _s.DisplayScripture();
            Console.WriteLine("\n\nType quit to exit the program, press enter to lose three words.");
        } while (entry != "quit");
        Console.Clear();
        _s.DisplayScripture();
        Console.WriteLine("\n\nType quit to exit the program, press enter to lose three words.");
    }
}