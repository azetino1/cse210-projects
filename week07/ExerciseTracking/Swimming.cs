class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

}