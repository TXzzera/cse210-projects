using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._company = "Oracle";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobtitle = "Data Engineer";
        job2._company = "SalesForce";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myresume = new Resume();
        myresume._name = "Bruno Teixeira";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        
        myresume.Display();

    }
}