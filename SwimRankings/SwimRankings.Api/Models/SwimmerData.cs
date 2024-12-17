using System.Text.Json.Serialization;

namespace SwimRankings.Api.Models;

public class SwimmerData(string id) : Swimmer(id)
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Gender Gender { get; set; } = Gender.Unknown;

    public string Club { get; set; } = string.Empty;

    public int YearOfBirth { get; set; }

    public List<Pb> Pbs { get; set; } = new();

    public DateTime LastUpdated { get; set; } = DateTime.Now;
}