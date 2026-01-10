using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";


        if (grade >= 90)
        {
            letter = "A";
        }
        else if (90 > grade && grade >= 80)
        {
            letter = "B";
        }
        else if (80 > grade && grade >= 70)
        {
            letter = "C";
        }
        else if (70 > grade && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Stretch Challenge
        
        int remainder = grade % 10;


        if (remainder >= 7 && grade >= 60)
        {
            sign = "+";
        }
        if (remainder < 3 && grade >= 60)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine($"You passed the course. Congratulations!");
        }
        else
        {
            Console.WriteLine($"You didn't pass the course. Do your best the next time!");
        }

    }
} 