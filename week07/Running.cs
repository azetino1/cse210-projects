class Running : Activity
{
    private double Distance { get; }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

}