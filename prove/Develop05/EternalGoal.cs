
public class EternalGoals : Goal
{
    private string _points, _name, _description;
    public EternalGoals(string name, string description, string points) 
        : base(name, description, points)
        {
            _points = points;
            _name = name;
            _description = description;
        }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:|{_name}|-{_description}|-{_points}";
    }
}