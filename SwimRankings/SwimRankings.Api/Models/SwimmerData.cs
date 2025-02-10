using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SwimRankings.Api.Models;

public class SwimmerData(string id) : Swimmer(id)
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public Gender Gender { get; set; } = Gender.Unknown;

    public string Club { get; set; } = string.Empty;

    public int YearOfBirth { get; set; }

    public List<Pb> Pbs { get; set; } = new();

    public DateTime LastUpdated { get; set; } = DateTime.Now;
}