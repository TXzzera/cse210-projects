using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Buddy! This is the Mindfulness App.");

        while (true)
        {
            Console.WriteLine("Select an activity to practice or an option to exit the app:\n");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflection Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4 - Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing_Act breathing_activity = new Breathing_Act();
                breathing_activity.Run();
            }

            else if (choice =="2")
            {
                Reflection_Act reflection_activity = new Reflection_Act();
                reflection_activity.Run();
            }

            else if (choice == "3")
            {
                Listing_Act listing_activity = new Listing_Act();
                listing_activity.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness App!");
                Console.WriteLine("Don't forget to rate the app on GooglePlay or Apple Store!");
                break;
            }

            else
            {
                Console.WriteLine("It's not a valid option. Try again!");
            }

        }
        
    }
}