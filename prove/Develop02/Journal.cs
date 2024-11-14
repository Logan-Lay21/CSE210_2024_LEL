using System;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    public List<Entry> _entries = new();
    public void WriteFile(string filename) //Save Function
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry x in _entries)
            {
                x.WriteEntry(outputFile);
            }
        }

    }
    public void DisplayJournal()
    {
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

    public void LoadJournal(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry newEntry = new();
            newEntry._date = parts[0];
            newEntry._name = parts[1];
            newEntry._prompt = parts[2];
            newEntry._entry = parts[3];

            _entries.Add(newEntry);
        }
    }
}