using System.Text.Json;
using SwimRankings.Api;

var swimrankingsId = "4046710";

var httpClient = new HttpClient();
var api = new SwimmerApi(httpClient);

var swimmer = await api.GetAsync(swimrankingsId);

Console.WriteLine(JsonSerializer.Serialize(swimmer, new JsonSerializerOptions { WriteIndented = true }));

