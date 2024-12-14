using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("The Matrix", "The Wachowskis", 136*60);
        v1.StoreComment("Logan", "This movie was awesome!");
        v1.StoreComment("Jacob", "A true masterpiece!");
        v1.StoreComment("Hayden", "That was so confusing, but cool!");
        v1.StoreComment("Ben", "What if we're in the matrix??");

        Console.WriteLine(v1.Report());

        Video v2 = new Video("The Matrix Reloaded", "The Wachowskis", 138*60);
        v2.StoreComment("Logan", "A crazy addition to the first movie!");
        v2.StoreComment("Jacob", "An ever truer masterpiece.");
        v2.StoreComment("Hayden", "Okay now I am really confused.");
        v2.StoreComment("Ben", "It's official, we're in the matrix.");

        Console.WriteLine(v2.Report());

        Video v3 = new Video("The Matrix Revolutions", "The Wachowskis", 140*60);
        v3.StoreComment("Logan", "So, could I be the chosen one?");
        v3.StoreComment("Jacob", "No chance, it's me.");
        v3.StoreComment("Hayden", "Still confused.");
        v3.StoreComment("Ben", "We're still in the matrix.");

        Console.WriteLine(v3.Report());
    }
}