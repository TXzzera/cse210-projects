using System;
using System.Web;

class Program
{
    static void Main(string[] args)
    {
        List<Activity>activities = new List<Activity>
        {
          new Running(new DateTime(2025,04,01), 30, 5.2),
          new Cycling(new DateTime(2025,03,09), 45, 30.2),
          new Swimming(DateTime.Today, 20, 8),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}