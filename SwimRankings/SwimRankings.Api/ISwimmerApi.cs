using SwimRankings.Api.Models;

namespace SwimRankings.Api;

public interface ISwimmerApi
{
    /// <summary>
    /// Retrieves swimmer data for a specified SwimRankings ID.
    /// </summary>
    /// <param name="swimrankingsId">The SwimRankings ID of the swimmer to retrieve data for.</param>
    /// <returns>The <see cref="SwimmerData"/> object populated with the swimmer's details, club, gender, personal bests (PBs), and other relevant information.</returns>
    Task<SwimmerData> GetAsync(string swimrankingsId);
}