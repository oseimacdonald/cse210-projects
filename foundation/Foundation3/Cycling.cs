using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * Duration) / 60; // Distance in miles

    public override double GetSpeed() => speed; // Speed is given in mph

    public override double GetPace() => 60 / speed; // Pace in min per mile
}
