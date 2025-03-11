using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers =  new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        int count = numbers.Count;
        double average = (double) sum/count;
        Console.WriteLine($"The average is: {average}");

        int largest = -1;
        foreach (int num in numbers)

        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}