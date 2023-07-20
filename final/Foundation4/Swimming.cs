class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base (date, duration)
        {
            _laps = laps;
        }

    public override double GetDistance()
    {
        double LapDistance = _laps * 50.0 / 1609.34; 
        return Math.Round(LapDistance, 2);
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / (GetDuration() / 60.0);
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        double pace = (GetDuration() / 60.0) / GetDistance();
        return Math.Round(pace, 2); 
    }

    public override string DisplaySummary()
    {
        string summary = base.DisplaySummary();
        summary = summary.Replace("Activity", "Swimming");
        summary += $", Laps: {_laps}";
        return summary;
    }
}