namespace SwimRankings.Api.Models;

public class Date(int day, int month, int year)
{
    public int Day { get; set; } = day;
    public int Month { get; set; } = month;
    public int Year { get; set; } = year;

    public string DisplayValue()
    {
        return $"{Day:D2}-{Month:D2}-{Year:D4}";
    }

    public string Ymd()
    {
        return $"{Year:D4}-{Month:D2}-{Day:D2}";
    }
}