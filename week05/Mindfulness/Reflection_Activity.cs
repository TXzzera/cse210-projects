using System;

public class Reflection_Act : Activity
{
    List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private Random random = new Random();
    List<string> usedPrompts = new List<string>();
    List<string> usedQuestions = new List<string>();
    public Reflection_Act() : base("Reflection Activity", "This activity will help you to reflect about moments that you demonstrated strenght or was succesfull.")
    {}

    public void Run()
    {
        StartMessage();

        if (prompts.Count == 0)
        {
            Console.WriteLine("All the prompts were displayed, reloading...");
            prompts.AddRange(usedPrompts);
            usedPrompts.Clear();
            return;
        }

        int index = random.Next(prompts.Count);
        string selectedPrompt = prompts[index];
        Console.WriteLine("\nThink about this:");
        Console.WriteLine($">{selectedPrompt}<");
        usedPrompts.Add(selectedPrompt);
        prompts.RemoveAt(index);

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        string input = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions...");

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
          int question = random.Next(questions.Count);
          string selectedQuestion = questions[question];
          Console.WriteLine(questions[question]);
          usedQuestions.Add(selectedQuestion);
          questions.RemoveAt(question);
          Countdown(10);
        }

        EndMessage();
    }
}