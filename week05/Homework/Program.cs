using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignments math1 = new MathAssignments("Robert Downey Jr." , "Algebra", "7.11","8-18");
        string summary1 = math1.GetSummary();
        string homeworkList1 = math1.GetHomeWorkList();
        Console.WriteLine(summary1);
        Console.WriteLine(homeworkList1);

        Console.WriteLine();
        
        WritingAssignments write1 = new WritingAssignments("Michael Jordan", "Social Science", "I Can't Accept Not Trying: Michael Jordan on the Pursuit of Excellence");
        string summary2 = write1.GetSummary();
        string writeinformation1 = write1.GetWritingInformation();
        Console.WriteLine(summary2);
        Console.WriteLine(writeinformation1);

    }
}