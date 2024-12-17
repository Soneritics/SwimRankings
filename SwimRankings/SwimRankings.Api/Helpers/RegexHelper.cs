using System.Text.RegularExpressions;

namespace SwimRankings.Api.Helpers;

public static class RegexHelper
{
    public static string GetMatchValue(string contents, string regex, string defaultValue = "")
    {
        var match = Regex.Match(contents, regex, RegexOptions.Singleline);
        return match.Success ? match.Groups[1].Value.Trim() : defaultValue;
    }
}
