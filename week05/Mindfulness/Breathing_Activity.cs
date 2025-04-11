using System;

public class Breathing_Act : Activity
{
    public Breathing_Act() : base("Breathing Activity", "This activity will help you to adjust your Breathing. Just forget about the problems and enjoy it!")
    {
    }

    public void Run()
    {
      StartMessage();
      DateTime endTime = DateTime.Now.AddSeconds(duration);

      while (DateTime.Now < endTime)
      {
        Console.Clear();
        Console.WriteLine("Breathe in...");
        Countdown(5);

        Console.Clear();
        Console.WriteLine("Breathe out...");
        Countdown(5);
      }
       EndMessage();
    }
}