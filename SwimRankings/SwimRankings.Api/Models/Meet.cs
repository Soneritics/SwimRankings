namespace SwimRankings.Api.Models;

public class Meet
{
    public string Name { get; set; } = string.Empty;

    public Date? Date { get; set; }

    public string City { get; set; } = string.Empty;
}