class Office
{
    public string Name { get; set; }

    public string Activity { get; set; }

    public Office(string activity, string name)
    {
        Activity = activity;
        Name = name;
    }
}