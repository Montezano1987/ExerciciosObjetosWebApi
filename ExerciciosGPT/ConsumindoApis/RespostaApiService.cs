using System.Text;
using System.Text.Json;

namespace ObjetosWebApi.ConsumindoApis

{
    public static class RespostaApiService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task<RespostaApiDTO> GetAgeByNameAsync(string name)
        {
            string url = $"https://api.agify.io?name={name}";
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            RespostaApiDTO result = JsonSerializer.Deserialize<RespostaApiDTO>(responseBody);

            return result;
        }
    }
}
