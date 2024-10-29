using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string date;
    private int duration; // in minutes

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    protected int Duration => duration; // add a protected property

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date}: {GetType().Name} ({duration} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
