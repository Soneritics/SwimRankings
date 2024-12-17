namespace SwimRankings.Api.Models;

public class Swimmer(string id)
{
    public string Id { get; set; } = id;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;
}