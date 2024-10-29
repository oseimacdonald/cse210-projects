using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50) / 1000.0 * 0.62; // Distance in miles

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // Speed in mph

    public override double GetPace() => Duration / GetDistance(); // Pace in min per mile
}
