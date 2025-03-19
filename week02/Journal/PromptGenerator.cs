using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts = [
            "What did I learn from today?",
            "Is there a fun history to record today?",
            "Is there someone I met today?",
            "Was there a moment when I felt bad today? Why?",
            "How did I feel the hands of God in my life today?"
        ];
       
        Random randomGenerator = new Random();
        int promptI = randomGenerator.Next(0, _prompts.Count());

        return _prompts[promptI];

    }
}