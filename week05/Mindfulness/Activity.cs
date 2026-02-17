using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name,string description)
    {
        _name = name;
        _description = description;
        //_duration = duration;
    }
    public string GetName()
    {
        return _name;  
    }
    public string GetDescription()
    {
        return _description;  
    }
    public int GetDuration()
    {
        return _duration;  
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {GetName()}" );
        Console.WriteLine();
        Console.WriteLine(GetDescription());
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        
        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
     
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
