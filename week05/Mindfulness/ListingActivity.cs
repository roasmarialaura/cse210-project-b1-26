using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
   
    public ListingActivity(int count=0): base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = count;
           
    }
    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine($"List as many responses you can to the following prompt: ");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();

        SetCount(items.Count);

        Console.WriteLine();
        Console.WriteLine($"You listed {GetCount()} items!");

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser()
    {
       List<string> items = new List<string>();
        DateTime start = DateTime.Now;

        while ((DateTime.Now - start).TotalSeconds < GetDuration())
        {
            
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        return items;
    } 
}
