using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage? ");
        int grade_percentage = int.Parse(Console.ReadLine());

        string letter;
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if(grade_percentage >= 80)
        {
            letter = "B";
        }
        else if(grade_percentage >= 70)
        {
            letter = "C";
        }
        else if(grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine();
        Console.WriteLine($"Your letter grade is: {letter}. ");
        Console.WriteLine();

        if(grade_percentage >= 70)
        {
            Console.WriteLine("Congrats, you were approved! ");
        }
        else
        {
            Console.WriteLine("Sorry, you were not approved! ");
        }
        
    }
}