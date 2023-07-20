public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) // int amountCompleted)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
       
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
     public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDiscription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
}