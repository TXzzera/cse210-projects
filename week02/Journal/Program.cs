using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        int choice;

        do
          {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choice= int.Parse(Console.ReadLine());

             if (choice == 1)
            {
                Entry entry = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();

                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(randomPrompt);
                Console.Write("> ");

                entry._promptText = randomPrompt;
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the filename to save: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename that you wanna open? ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
            
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("You selected an invalid option. Try again");
            }
        } while (choice != 5);
    }
}