public class EternalGoals : Goal
{
    public EternalGoals(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No need to record event for eternal goals
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoals|{GetName()}|{GetDiscription()}|{GetPoints()}";
    }
}