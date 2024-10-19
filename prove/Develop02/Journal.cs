using System;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<Entry> _entries = new();

    
    public string filename = "";

    public void WriteFile() //Save Function
    {
        Console.Write("Enter a filename: ");
        filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry x in _entries)
            {
                x.WriteEntry(outputFile);
            }
            // outputFile.WriteLine("This will be the firstline in the file");

            // string color = "Blue";
            // outputFile.WriteLine($"My favorite color is {color}");
        }

    }
    public void DisplayJournal()
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry newEntry = new();
            newEntry._date = parts[0];
            newEntry._name = parts[1];
            newEntry._prompt = parts[2];
            newEntry._entry = parts[3];


        }

        foreach (Entry x in _entries)
        {
            x.DisplayEntry();
        }
    }

    public void InputNewEntry()
    {
        Entry newEntry = new();
        newEntry.InputEntry();

        _entries.Add(newEntry);
    }
}


// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }