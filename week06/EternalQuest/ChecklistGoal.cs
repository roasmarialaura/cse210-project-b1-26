using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points,int amountCompleted, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
     
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    
    public override bool IsComplete()=> _amountCompleted >= _target;
    
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }


    public int GetBonus() => _bonus;
    public int GetAmountCompleted() => _amountCompleted;
    public int GetTarget() => _target;
}
