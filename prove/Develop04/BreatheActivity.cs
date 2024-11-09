using System;
using System.Threading;

public class BreatheActivity : Activity {
    Spinner spinner = new Spinner();

    public BreatheActivity(string name, string description) : base(name,description) {

    }
    public void RunBreathe() {
        //Display Start message
        SetStartMessage();
        Console.WriteLine(GetStartMessage());
        //Duration Prompt
        SetDuration();
        //Clear console
        Console.Clear();
        //Display spinner and get ready
        Console.WriteLine("Get ready...");

        spinner.StartLoading();

        //Initaite breathe loop
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        do {
            Console.WriteLine("");

            //Breathe in
            for (int i = 1; i < 6; i++)
            {   
                Console.Write($"\rBreathe in... {i}");
                Thread.Sleep(1000); // Pause for 1 second (1000 milliseconds)
            }
            Console.Write("\rBreathe in...           ");
            Console.WriteLine("");

            //Breathe out
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"\rBreathe out... {i}");
                Thread.Sleep(1000); // Pause for 1 second (1000 milliseconds)
            }
            Console.Write("\rBreathe out...           ");
            Console.WriteLine("");
        } while (DateTime.Now < futureTime);

        //End with well done
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        spinner.StartLoading();


        //End message
        SetEndMessage();
        Console.WriteLine(GetEndMessage());


        //Spinner then back to menu
        spinner.StartLoading();
    }
}