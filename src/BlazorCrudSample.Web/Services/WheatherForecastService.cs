using System.Net.Http;
using System.Threading.Tasks;
using BlazorCrudSample.Web.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorCrudSample.Web.Services
{
    public class WheatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WheatherForecastService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<WeatherForecast[]> GetAll()
        {
            var url = "https://localhost:5001/api/wheatherforecast";
            return await _httpClient.GetJsonAsync<WeatherForecast[]>(url);
        }
    }
}