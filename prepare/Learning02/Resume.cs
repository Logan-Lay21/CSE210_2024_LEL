using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DiplayResume()
    {
        Console.WriteLine($"Name {_name}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }
}