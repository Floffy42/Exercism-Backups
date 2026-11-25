public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int month;
    private readonly int year;

    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int daysInMonth = DateTime.DaysInMonth(year, month);
        if (schedule == Schedule.Last)
        {
            for (int i = daysInMonth; i >= 1; i--)
            {
                DateTime date = new DateTime(year, month, i);
                if (date.DayOfWeek == dayOfWeek) return date;
            }
        }
        else
        {
            int count = 0;
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime date = new DateTime(year, month, i);
                if (date.DayOfWeek != dayOfWeek) continue;

                if (schedule == Schedule.Teenth)
                {
                    if (i >= 13 && i <= 19) return date;
                }
                else
                {
                    count++;
                    if (count == (int)schedule) return date;
                }
            }
        }
        throw new ArgumentException();
    }
}