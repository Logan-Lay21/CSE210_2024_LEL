using System;

public class Activity {
    protected string _name = "";
    protected int _duration = 0;
    private string _description = "";
    private string _startMessage = "";
    private string _endMessage = "";

    //You chose the {breathe} activity. This activity will help you {focus on your breathing by directing you to breathe in and out slowly. Clear your mind and focus on the air in your lungs}.

    //Base: You chose the {_name}. This activity will help you {description}.

    //You have completed a 30 second breathing activity.

    //Base: You have completed a {_duration} second {_name} activity.

    // public Activity(string name, int waitTime) {
    //     _name = name;
    //     _waitTime = waitTime;
    // }

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void SetStartMessage() {
        _startMessage =  $"You chose the {_name} activity. This activity will help you {_description}.";
    }
    public string GetStartMessage() {
        return _startMessage;
    }

    public void SetEndMessage() {
        _endMessage = $"You have completed another {_duration} seconds of the {_name} activity.";
    }

    public string GetEndMessage() {
        return _endMessage;
    }

    public string RandomPrompt(List<string> prompts) {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0,prompts.Count);
        string prompt = prompts[i];

        return prompt;
    }

    public void SetDuration() {
        Console.Write($"How long, in 10 second intervals, would you like to run the {_name} activity? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }

    public int GetDuration() {
        return _duration;
    }
}