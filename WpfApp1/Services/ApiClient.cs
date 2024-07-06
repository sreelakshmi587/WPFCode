using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public class ApiClient:IApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ApiClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            // Set BaseAddress for HttpClient
            _httpClient.BaseAddress = new Uri(_configuration["ApiSettings:BaseUrl"]);
        }


        
        public async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T content)
        {
            var fullUrl = $"{_httpClient.BaseAddress}{endpoint}";

            var jsonContent = System.Text.Json.JsonSerializer.Serialize(content);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(fullUrl, httpContent);
            return response;
        }

    }
}
