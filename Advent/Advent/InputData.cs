using System.IO;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace Advent;

public static class InputData
{
    private static readonly string[] Data = new string[26];

    private static readonly HttpClient HttpClient = new();
    
    private static readonly string SessionCookie = $"session={GetSessionCookie()}";
    
    private const string Path = "";
    
    public static string Day(int day)
    {
        if (Data[day] != null) return Data[day];
        
        var fileName = $"{Path}input-day-{day}.txt";
        
        if (File.Exists(fileName))
        {
            Data[day] = File.ReadAllText(fileName);
            return Data[day];
        }
        
        var url = $"https://adventofcode.com/2024/day/{day}/input";
        
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Add("Cookie", SessionCookie);

        var response = HttpClient.SendAsync(request).Result;
        response.EnsureSuccessStatusCode(); // Throw if the request failed

        var input = response.Content.ReadAsStringAsync().Result;
        
        File.WriteAllText(fileName, input);
        
        Data[day] = input; // Cache the input for re-use

        return input;
    }
    
    private static string GetSessionCookie()
    {
        var builder = new ConfigurationBuilder()
            .AddUserSecrets<Program>();
        
        var config = builder.Build();

        return config["session"];
    }
}