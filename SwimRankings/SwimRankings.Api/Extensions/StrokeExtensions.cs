using SwimRankings.Api.Models;

namespace SwimRankings.Api.Extensions;

public static class StrokeExtensions
{
    public static Stroke ToStroke(this string stroke)
    {
        return stroke.ToLowerInvariant() switch
        {
            "freestyle" => Stroke.Freestyle,
            "backstroke" => Stroke.Backstroke,
            "breaststroke" => Stroke.Breaststroke,
            "butterfly" => Stroke.Butterfly,
            "medley" => Stroke.Medley,
            "freestyle lap" => Stroke.FreestyleLap,
            "backstroke lap" => Stroke.BackstrokeLap,
            "breaststroke lap" => Stroke.BreaststrokeLap,
            "butterfly lap" => Stroke.ButterflyLap,
            _ => Stroke.Unknown
        };
    }
}