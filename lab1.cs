using System;

public delegate void DisplayDelegate(int minutes);

class Time
{
    private int hour;
    private int minutes;

    public int Hour
    {
        get { return hour; }
        set
        {
            hour = value;
            minutes = value * 60;
            OnHourSet(minutes);
        }
    }

    public int Minutes
    {
        get { return minutes; }
    }

    public event DisplayDelegate OnHourSet;

}

class Program
{
    static void Main4(string[] args)
    {
        Time time = new Time();

        time.OnHourSet += DisplayMinutes;
        Console.WriteLine("Practical by: Nirdosh Lamichhane.");
        Console.Write("Enter the hour: ");
        int hour = int.Parse(Console.ReadLine());

        time.Hour = hour;
    }

    static void DisplayMinutes(int minutes)
    {
        Console.WriteLine("Minutes: {0}", minutes);
    }
}