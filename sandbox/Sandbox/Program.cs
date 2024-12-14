using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Workspace w = new Workspace();
        Console.WriteLine(w.SimpsonRule(x => x*x / Math.Cos(x), 0, 5, 10));
    }
}