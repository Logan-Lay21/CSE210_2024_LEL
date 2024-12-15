using System;

class Program
{
    private List<Activity> _activities;
    static void Main(string[] args) {
        Console.Clear();
        Program p = new Program();
        Cycling c = new Cycling("12/14/2024", 30, 8);
        Running r = new Running("12/14/2024", 30, 3.4);
        Swimming s = new Swimming("12/14/2024", 30, 20);

        p._activities = new List<Activity>{c,r,s};
        foreach (Activity activity in p._activities) {
            Console.WriteLine(activity.GetSummary());
        }

    }
}