
public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _name, _description, _points;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
        {
            _name = name;
            _description = description;
            _points = points;
        }
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:|{_name}|-{_description}|-{_points}|-{IsComplete()}";
    }
}