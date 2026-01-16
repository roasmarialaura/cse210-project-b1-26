using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int percent = int.Parse(gradePercentage);

        string letter = "";
        

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine($"You passed the course. Congratulations!");
        }
        else
        {
            Console.WriteLine($"You didn't pass the course. Do your best the next time!");
        }

        //Stretch Challenge

        string sign = "";        
        int lastDigit= percent % 10;

        if (lastDigit >= 7 && percent >= 60)
        {
            sign = "+";
        }
        if (lastDigit < 3 && percent >= 60)
        {
            sign = "-";
        }

        Console.WriteLine("");
        Console.WriteLine($"Your grade is {letter}{sign}");
    }

} 