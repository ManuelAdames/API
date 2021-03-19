using API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace API.Services
{
    public class APIService : IAPIService
    {
        public async Task<Language> GetLanguageAsync()
        {
            Language language = null;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://world.openfoodfacts.org/languages.json"),
            };
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                language = JsonConvert.DeserializeObject<Language>(await response.Content.ReadAsStringAsync());
            }
            return language;
        }
    }
}
