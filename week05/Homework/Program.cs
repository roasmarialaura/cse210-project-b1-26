using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Laura");
        assignment1.SetTopic("fraction");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Jane Austin");
        assignment2.SetTopic("Division");
        assignment2.SetTextbookSection("7.1");
        assignment2.SetProblems("8-19");

        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Kevin");
        assignment3.SetTopic("Geography");
        assignment3.SetTitle("The Wonderful Alazka");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());


    }
}