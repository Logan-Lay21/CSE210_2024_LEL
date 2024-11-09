using System;

public class ReflectActivity : Activity {
    Spinner spinner = new Spinner();
    Spinner spinner15 = new Spinner(15, 1000);
    private List<string> prompts = new List<string>
    {
        "Think of a time when you did something really difficult",
        "Think of the hardest thing you overcame recently",
        "Think of your most recent accomplishment"
    };

    private List<string> followUps = new List<string>
    {
        "How did you feel when you finished?",
        "What is something you learned?",
        "What is something positive that came from this experience?",
        "How did you grow as a person through this experience?"
    };

    public ReflectActivity(string name, string description) : base(name,description) {
        
    }

    public void RunReflect() {
        //Display Start message
        SetStartMessage();
        Console.WriteLine(GetStartMessage());

        //Prompt for duration
        SetDuration();

        //Clear the console
        Console.Clear();

        //Get ready
        Console.WriteLine("Get ready...");

        //spinner
        spinner.StartLoading();

        //Display first prompt and pause (wait for user), after user presses enter
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(@$"
        
 --- {RandomPrompt(prompts)} ---
        
        ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
        
        //Begin process to display followUp questions
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
        //countdown
        Console.WriteLine(" ");
        for (int i = 5; i > 0; i--)
            {   
                Console.Write($"\rYou may begin in: {i}");
                Thread.Sleep(1000); // Pause for 1 second (1000 milliseconds)
            }

        //Clear the console
        Console.Clear();

        //Start loop!
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        do {
            //Display follow up questions
            Console.WriteLine($"{RandomPrompt(followUps)}"); 
            spinner15.StartLoading();

        } while (DateTime.Now < futureTime);

        //End message
        SetEndMessage();
        Console.WriteLine(GetEndMessage());


        //Spinner then back to menu
        spinner.StartLoading();
    }
}