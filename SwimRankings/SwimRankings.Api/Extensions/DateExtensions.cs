using SwimRankings.Api.Models;

namespace SwimRankings.Api.Extensions;

public static class DateExtensions
{
    public static Date? ToDate(this string dateString) =>
        DateTime.TryParse(dateString, out var date)
            ? new Date(date.Day, date.Month, date.Year)
            : null;
}