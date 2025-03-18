using System.Net;
using System.Text.RegularExpressions;
using SwimRankings.Api.Extensions;
using SwimRankings.Api.Helpers;
using SwimRankings.Api.Models;

namespace SwimRankings.Api.Services;

internal static class SwimmerDataBuilder
{
    public static SwimmerData WithAthleteDetails(this SwimmerData swimmerData, string pageContents)
    {
        var firstName = "Unknown";
        var lastName = "Unknown";
        int yearOfBirth = 0;
    
        var athleteMatch = RegexHelper.GetMatchValue(pageContents, @"<div id=""name"">(.*?)&");
    
        yearOfBirth = int.Parse(RegexHelper.GetMatchValue(athleteMatch, @"<br>\((.*?)$", yearOfBirth.ToString()));
        lastName = RegexHelper.GetMatchValue(athleteMatch, @"(.*?),", lastName).Trim();
        firstName = RegexHelper.GetMatchValue(athleteMatch, @",(.*?)<br>", firstName).Trim();

        swimmerData.FirstName = firstName.ToNameCasing();
        swimmerData.LastName = lastName.ToNameCasing();
        swimmerData.YearOfBirth = yearOfBirth;
        
        return swimmerData;
    }

    public static SwimmerData WithClub(this SwimmerData swimmerData, string pageContents)
    {
        var matchClub = RegexHelper.GetMatchValue(pageContents, @"<div id=""nationclub""><br>(.*?)</div>");
        swimmerData.Club = RegexHelper.GetMatchValue(matchClub, @"<br>(.*?)$");

        return swimmerData;
    }

    public static SwimmerData WithGender(this SwimmerData swimmerData, string pageContents)
    {
        var gender = Gender.Unknown;
        
        if (pageContents.Contains("athletes/athletemale.png"))
        {
            gender = Gender.Male;
        }
    
        if (pageContents.Contains("athletes/athletefemale.png"))
        {
            gender = Gender.Female;
        }

        swimmerData.Gender = gender;

        return swimmerData;
    }

    public static SwimmerData WithPbs(this SwimmerData swimmerData, string pageContents)
    {
        swimmerData.Pbs = new List<Pb>();
        
        var pbTable = RegexHelper.GetMatchValue(
            Regex.Replace(pageContents, @"escape\('(.*?)'\)", string.Empty),
            @"<table class=""athleteBest""(.*?)</table>");

        var pbLines = Regex.Matches(pbTable, @"<tr class=""athleteBest(.*?)</tr>");
        if (pbLines.Any())
        {
            foreach (Match pbLineMatch in pbLines)
            {
                var pbLine = pbLineMatch.Groups[1].Value.Trim();
                swimmerData.Pbs.Add(CreatePbFromLine(pbLine));
            }
        }

        return swimmerData;
    }
    
    private static Pb CreatePbFromLine(string pbLine)
    {
        var strokeAndDistance = RegexHelper.GetMatchValue(pbLine, @"<td class=""event""><a.*?>(.*?)<");
        var stroke = RegexHelper.GetMatchValue(strokeAndDistance, @"m (.*?)$");
        var distance = RegexHelper.GetMatchValue(strokeAndDistance, @"(.*?)m");
        var poolLength = RegexHelper.GetMatchValue(pbLine, @"<td class=""course"">(.*?)m</td>");
        var timeString = RegexHelper.GetMatchValue(pbLine, @"a  class=""time"".*?>(.*?)<");

        var meetName = RegexHelper.GetMatchValue(pbLine, @"<td class=""name"">.*?title=""(.*?)""");
        var meetDate = RegexHelper.GetMatchValue(pbLine, @"<td class=""date"">(.*?)</td>");
        var meetCity = RegexHelper.GetMatchValue(pbLine, @"<td class=""city"">.*?title="".*?"">(.*?)<");
        
        return new ()
        {
            Stroke = stroke.ToStroke(),
            DistanceInMeters = int.TryParse(distance, out var distanceValue) ? distanceValue : 0,
            PoolLength = int.TryParse(poolLength, out var poolLengthValue) ? poolLengthValue : 0,
            SwimTime = timeString.ToSwimTime(),
            Meet = new ()
            {
                Name = WebUtility.HtmlDecode(meetName),
                Date = WebUtility.HtmlDecode(meetDate).ToDate(),
                City = WebUtility.HtmlDecode(meetCity)
            }
        };
    }
}