using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_name}\n{_description}");
        Console.WriteLine("Please, type how many time do you want to spend with this activity: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("The activity will begin soon, prepare yourself...");
        Countdown(3);
    }

    public void EndMessage()
    {
        Console.WriteLine($"Well job! You have completed the {_name} in {duration} seconds.");
        Countdown(3);
    }

    public void Countdown(int seconds)
    {
       for (int i = seconds; i > 0; i--)
        {
         Console.WriteLine($"{i} seconds left...");
         System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}