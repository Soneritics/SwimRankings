namespace SwimRankings.Api.Helpers;

public static class SwimrankingsUrlHelper
{
    public static string Get(string swimrankingsId, string language = "us") =>
        $"https://www.swimrankings.net/index.php?page=athleteDetail&athleteId={swimrankingsId}&language=us";
}