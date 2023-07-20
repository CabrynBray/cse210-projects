class ActivityTracker
{
    private List<Activity> activities;

    public ActivityTracker()
    {
        activities = new List<Activity>();
    }

    public void AddActivity(Activity _activity)
    {
        activities.Add(_activity);
    }

    public List<string> GetDetailsSummary()
    {
        List<string> summaries = new List<string>();
        foreach (Activity activity in activities)
        {
            summaries.Add(activity.DisplaySummary());
        }
        return summaries;
    }
}