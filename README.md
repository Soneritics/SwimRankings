# SwimRankings
Download swimmer data directly from SwimRankings.com

Example code:
```csharp
var swimrankingsId = "4046710";

var httpClient = new HttpClient();
var api = new SwimmerApi(httpClient);

var swimmer = await api.GetAsync(swimrankingsId);

Console.WriteLine(JsonSerializer.Serialize(swimmer, new JsonSerializerOptions { WriteIndented = true }));
```

This will write the following to the console:
```json
{
  "Gender": "Male",
  "Club": "ENC Arnhem",
  "YearOfBirth": 1986,
  "Pbs": [
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 28390,
        "DisplayValue": "28.39"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "Open Nederlandse Masters Kampioenschappen 2018 lb",
        "Date": "4\u00A0May\u00A02018",
        "City": "Den\u00A0Haag"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 25790,
        "DisplayValue": "25.79"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "9\u00A0Mar\u00A02008",
        "City": "Arnhem"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 58950,
        "DisplayValue": "58.95"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "",
        "Date": "29\u00A0May\u00A02005",
        "City": "Nijmegen"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 56500,
        "DisplayValue": "56.50"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "15\u00A0Sep\u00A02007",
        "City": "Veenendaal"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 200,
      "SwimTime": {
        "TimeInMs": 135150,
        "DisplayValue": "2:15.15"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "12\u00A0Jan\u00A02019",
        "City": "Wageningen"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 400,
      "SwimTime": {
        "TimeInMs": 293040,
        "DisplayValue": "4:53.04"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "Deel 1 KNZB zwemcompetitie landelijk B/C",
        "Date": "29\u00A0Sep\u00A02007",
        "City": "Doetinchem"
      }
    },
    {
      "Stroke": "Freestyle",
      "DistanceInMeters": 800,
      "SwimTime": {
        "TimeInMs": 673460,
        "DisplayValue": "11:13.46"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "A. Jansen Lange Afstand Circuit  periode 1",
        "Date": "8\u00A0Dec\u00A02024",
        "City": "Doetinchem"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 31910,
        "DisplayValue": "31.91"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "Open Nederlandse Masters Kampioenschappen 2018 lb",
        "Date": "4\u00A0May\u00A02018",
        "City": "Den\u00A0Haag"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 31050,
        "DisplayValue": "31.05"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "13\u00A0Nov\u00A02022",
        "City": "Arnhem"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 66310,
        "DisplayValue": "1:06.31"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "",
        "Date": "21\u00A0May\u00A02005",
        "City": "Nijmegen"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 67410,
        "DisplayValue": "1:07.41"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "9\u00A0Mar\u00A02008",
        "City": "Arnhem"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 200,
      "SwimTime": {
        "TimeInMs": 154460,
        "DisplayValue": "2:34.46"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "",
        "Date": "29\u00A0May\u00A02005",
        "City": "Nijmegen"
      }
    },
    {
      "Stroke": "Backstroke",
      "DistanceInMeters": 200,
      "SwimTime": {
        "TimeInMs": 149360,
        "DisplayValue": "2:29.36"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "9\u00A0Feb\u00A02008",
        "City": "Wapenveld"
      }
    },
    {
      "Stroke": "Breaststroke",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 34110,
        "DisplayValue": "34.11"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "23\u00A0Jun\u00A02018",
        "City": "Westervooort"
      }
    },
    {
      "Stroke": "Breaststroke",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 81420,
        "DisplayValue": "1:21.42"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "Deel 1 KNZB zwemcompetitie landelijk B/C",
        "Date": "29\u00A0Sep\u00A02007",
        "City": "Doetinchem"
      }
    },
    {
      "Stroke": "Breaststroke",
      "DistanceInMeters": 200,
      "SwimTime": {
        "TimeInMs": 183010,
        "DisplayValue": "3:03.01"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "23\u00A0Feb\u00A02019",
        "City": "Westervoort"
      }
    },
    {
      "Stroke": "Butterfly",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 29450,
        "DisplayValue": "29.45"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "Open Nederlandse Masters Kampioenschappen 2018 lb",
        "Date": "6\u00A0May\u00A02018",
        "City": "Den\u00A0Haag"
      }
    },
    {
      "Stroke": "Butterfly",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 27950,
        "DisplayValue": "27.95"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "9\u00A0Feb\u00A02008",
        "City": "Wapenveld"
      }
    },
    {
      "Stroke": "Butterfly",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 71850,
        "DisplayValue": "1:11.85"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "17\u00A0Mar\u00A02018",
        "City": "Wageningen"
      }
    },
    {
      "Stroke": "Medley",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 65480,
        "DisplayValue": "1:05.48"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "Deel 1 KNZB zwemcompetitie landelijk B/C",
        "Date": "29\u00A0Sep\u00A02007",
        "City": "Doetinchem"
      }
    },
    {
      "Stroke": "Medley",
      "DistanceInMeters": 200,
      "SwimTime": {
        "TimeInMs": 151980,
        "DisplayValue": "2:31.98"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "15\u00A0Sep\u00A02007",
        "City": "Veenendaal"
      }
    },
    {
      "Stroke": "FreestyleLap",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 26410,
        "DisplayValue": "26.41"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "Open Nederlandse Masters Kampioenschappen 2018 lb",
        "Date": "6\u00A0May\u00A02018",
        "City": "Den\u00A0Haag"
      }
    },
    {
      "Stroke": "FreestyleLap",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 25420,
        "DisplayValue": "25.42"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "5\u00A0Oct\u00A02019",
        "City": "Westervoort"
      }
    },
    {
      "Stroke": "FreestyleLap",
      "DistanceInMeters": 100,
      "SwimTime": {
        "TimeInMs": 59870,
        "DisplayValue": "59.87"
      },
      "PoolLength": 50,
      "Meet": {
        "Name": "Open Nederlandse Masters Kampioenschappen 2018 lb",
        "Date": "6\u00A0May\u00A02018",
        "City": "Den\u00A0Haag"
      }
    },
    {
      "Stroke": "ButterflyLap",
      "DistanceInMeters": 50,
      "SwimTime": {
        "TimeInMs": 29790,
        "DisplayValue": "29.79"
      },
      "PoolLength": 25,
      "Meet": {
        "Name": "",
        "Date": "23\u00A0Feb\u00A02019",
        "City": "Westervoort"
      }
    }
  ],
  "LastUpdated": "2024-12-17T14:19:54.4286768+01:00",
  "Id": "4046710",
  "FirstName": "Jordi",
  "LastName": "Jolink"
}
```