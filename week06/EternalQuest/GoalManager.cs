using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    
    public GoalManager() { }

    public void Start()
    {
        string option = "";

        while (option != "6")
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
            }
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal( name, description, points, false));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, 0, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Select goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal selectedGoal = _goals[index];

        int earnedPoints = selectedGoal.GetPoints();

        if (selectedGoal is ChecklistGoal checklist)
        {
            int before = checklist.GetAmountCompleted();
            selectedGoal.RecordEvent();
            if (checklist.IsComplete() && before < checklist.GetTarget())
                earnedPoints += checklist.GetBonus();
        }
        else
        {
            selectedGoal.RecordEvent();
        }

        _score += earnedPoints;
        Console.WriteLine($"You earned {earnedPoints} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string file = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
                writer.WriteLine(g.GetStringRepresentation());
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                        int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}    
        
    