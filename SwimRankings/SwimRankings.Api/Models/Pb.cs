using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SwimRankings.Api.Models;

public class Pb
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public Stroke Stroke { get; set; } = Stroke.Unknown;

    public int DistanceInMeters { get; set; }
    public SwimTime SwimTime { get; set; } = new();
    public int PoolLength { get; set; }
    public Meet? Meet { get; set; }
}