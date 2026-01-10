using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;
        int totalSum = 0;
        float average = 0;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        foreach (int number in numbers)
        {
            totalSum += number;
        }
        average = ((float)totalSum) / numbers.Count;

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        //Stretch Challenge

        int smallest = largest;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}