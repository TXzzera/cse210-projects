using System;

public class Listing_Act : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private List<string> usedPrompts = new List<string>();
    private Random random = new Random();
    public Listing_Act() : base("Listing Activity","This activity will help you to list your strenghts in some area/aspect of your life. You need to be more positive and list them here!")
    {}

    public void Run()
    {
        StartMessage();

        if (prompts.Count == 0)
        {
            Console.WriteLine("All the prompts were answered, reloading...");
            prompts.AddRange(usedPrompts);
            usedPrompts.Clear();
            return;
        }

        int index = random.Next(prompts.Count());
        string selectedPrompt = prompts[index];
        Console.WriteLine(selectedPrompt);
        usedPrompts.Add(selectedPrompt);
        prompts.RemoveAt(index);
        Console.WriteLine("You have to list items after the countdown, one by one.");
        Countdown(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while( DateTime.Now < endTime)
        {
            Console.WriteLine("Enter your answer: ");
            string input = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You countered {items.Count} items in this activity.");

        EndMessage();
    }
}