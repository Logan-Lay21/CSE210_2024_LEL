using System;

class PromptGenerator
{
    public string[] _promptList = ["How was your day? ","Tell me how you are doing. ","What was the weather like? ","Did you have a good day? "];

    public string RandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0,4);
        string prompt = _promptList[randomNumber];
        return prompt;
    }
}