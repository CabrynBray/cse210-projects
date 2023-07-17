
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    private string _name, _description, _points;
    
    public ChecklistGoal(string name, string description, string points, int target, int bouns) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bouns;
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        _amountCompleted = _amountCompleted + 1;
        if (_amountCompleted == _target)
        {
            _points = _points + _bonus;
        }
        // else
        // {
        
        // }


    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_name} {_description} --- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_name} {_description} --- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:|{_name}|-{_description}|-{_points}|-{_bonus}|-{_amountCompleted}|-{_target}";
    }
}