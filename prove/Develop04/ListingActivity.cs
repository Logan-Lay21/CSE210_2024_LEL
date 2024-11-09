using System;

public class ListingActivity : Activity {
    Spinner spinner = new Spinner();
    private List<string> _userResponses = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this week?",
        "What is something good that happened today?",
        "Who are you especially grateful for lately?",
        "How have you been productive lately?"
    };

    public ListingActivity(string name, string description) : base(name,description) {
        
    }

    public void RunListing() {
        //Display Start message
        SetStartMessage();
        GetStartMessage();

        //Get duration time
        SetDuration();

        //Get ready
        Console.WriteLine("Get ready...");

        //spinner
        spinner.StartLoading();

        //Display random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {RandomPrompt(_prompts)} --- ");
        //Display countdown
        Console.WriteLine(" ");
        for (int i = 5; i > 0; i--)
            {   
                Console.Write($"\rYou may begin in: {i}");
                Thread.Sleep(1000); // Pause for 1 second (1000 milliseconds)
            }

        //Start DateTime loop :)
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        Console.WriteLine(" ");
        do {
            //Record/display number of entries
            Console.Write("> ");
            string response = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(response))
                continue;
                
            _userResponses.Add(response);
        }   while (DateTime.Now < futureTime);
        Console.WriteLine($"You listed {_userResponses.Count} items!");
            
        //Well done
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