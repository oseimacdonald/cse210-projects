using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double distance; // in miles

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / Duration) * 60; // Speed in mph

    public override double GetPace() => Duration / distance; // Pace in min per mile
}
