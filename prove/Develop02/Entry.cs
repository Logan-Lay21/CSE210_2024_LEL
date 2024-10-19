using System;
using System.Configuration.Assemblies;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Transactions;

class Entry
{
    public string _entry = "this did not work";
    public string _prompt = "prompt broke";
    public string _date = "date broke";
    public string _name = "name broke";
    public void ReadEntry()
    {

    }
    public void WriteEntry(StreamWriter outputFile) //Writes the entry to the .txt file
    {
        outputFile.WriteLine($"{_date}~{_name}~{_prompt}~{_entry}");
    }
    public void InputEntry() //Is what the user will use to write a new entry
    {
        // Console.Write("Enter Date: ");
        // _date = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        PromptGenerator randPrompt = new();
        _prompt = randPrompt.RandomPrompt();
        Console.Write(_prompt);
        _entry = Console.ReadLine();
        Console.Write("Sign your name: ");
        _name = Console.ReadLine();
    }
    public void DisplayEntry() //Displays all of the previous entries written by the user.
    {
        Console.WriteLine($"{_date}\t{_name}\n{_prompt}\n{_entry}\n\n");
    }
}

