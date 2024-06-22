using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using WeatherApp.Models;

public class WeatherService
{
    private readonly string apiKey = "d721bd5e941a890a616f7cd45fad41a6";
    private readonly string baseUrl = "http://api.openweathermap.org/data/2.5/weather";

    public async Task<WeatherInfo> GetWeatherAsync(string city)
    {
        var options = new RestClientOptions(baseUrl)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
        var client = new RestClient(options);
        var request = new RestRequest();

        request.AddParameter("q", city);
        request.AddParameter("appid", apiKey);
        request.AddParameter("units", "metric");
        request.Method = Method.Get;

        RestResponse response = await client.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return JsonConvert.DeserializeObject<WeatherInfo>(response.Content);
        }
        else
        {
            throw new Exception("Bład");
        }
    }
}
