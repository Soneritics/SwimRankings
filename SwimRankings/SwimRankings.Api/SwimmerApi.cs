using SwimRankings.Api.Helpers;
using SwimRankings.Api.Models;
using SwimRankings.Api.Services;

namespace SwimRankings.Api;

public class SwimmerApi(HttpClient httpClient) : ISwimmerApi
{
    /// <summary>
    /// Retrieves swimmer data for a specified SwimRankings ID.
    /// </summary>
    /// <param name="swimrankingsId">The SwimRankings ID of the swimmer to retrieve data for.</param>
    /// <returns>The <see cref="SwimmerData"/> object populated with the swimmer's details, club, gender, personal bests (PBs), and other relevant information.</returns>
    public async Task<SwimmerData> GetAsync(string swimrankingsId)
    {
        var pageContents = await GetSwimRankingsPageContentsAsync(swimrankingsId);
        var swimmer = new SwimmerData(swimrankingsId)
            .WithAthleteDetails(pageContents)
            .WithClub(pageContents)
            .WithGender(pageContents)
            .WithPbs(pageContents);

        return swimmer;
    }
    
    private Task<string> GetSwimRankingsPageContentsAsync(string swimrankingsId) =>
        httpClient.GetStringAsync(SwimrankingsUrlHelper.Get(swimrankingsId));
}