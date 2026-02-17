using System;

public class BreathingActivity: Activity
{
    public BreathingActivity(): base ("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"Get ready...");
        ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < GetDuration())
        {
            Console.Write("Breathe in...");
            ShowCountDown(5); 
            elapsed += 5;

            if (elapsed >= GetDuration()) break;
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            elapsed += 5;
            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.WriteLine();
    }
}