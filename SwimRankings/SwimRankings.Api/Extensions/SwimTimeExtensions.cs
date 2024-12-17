using SwimRankings.Api.Models;

namespace SwimRankings.Api.Extensions;

public static class SwimTimeExtensions
{
    public static SwimTime ToSwimTime(this string timeString) =>
        new()
        {
            TimeInMs = GetTimeInMs(timeString),
            DisplayValue = timeString
        };

    private static int GetTimeInMs(string timeString)
    {
        var timeParts = timeString.Split(':');
        
        var minutes = 0;

        if (timeParts.Length == 2)
        {
            if (!int.TryParse(timeParts[0], out minutes))
            {
                return 0;
            }
        }

        var secondsAndMs = timeParts.Last().Split('.');
        if (secondsAndMs.Length != 2)
        {
            return 0;
        }

        if (!int.TryParse(secondsAndMs[0], out var seconds))
        {
            return 0;
        }

        if (!int.TryParse(secondsAndMs[1], out var ms))
        {
            return 0;
        }

        return ((minutes * 60 + seconds) * 100 + ms) * 10;
    }
}