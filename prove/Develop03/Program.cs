using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _r = new Reference("Enos", "5", "3", "6");
        _r.DisplayVerse();

        Scripture _s = new();
        _s.DefVerseList();
        _s.RandomIndex();

    }
}