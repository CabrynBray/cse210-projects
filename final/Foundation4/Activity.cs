abstract class Activity
{
    private string _date;
    private int _duration;
    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    private string _Type()
    {
        return GetType().Name;
    }
    
    public virtual string DisplaySummary()
    {
        string summary = $"{_date:dd MMM YYYY} {_Type()} ({_duration} min) -";
        summary += $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
        return summary;
    }
}