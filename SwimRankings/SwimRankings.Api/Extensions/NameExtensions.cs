namespace SwimRankings.Api.Extensions;

public static class NameExtensions
{
    public static string ToNameCasing(this string name) =>
        string.Join(" ", name.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
}