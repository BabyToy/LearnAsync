using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncTest
{
    public class WebScraper
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<string> GetPageAsync(string url)
        {
            using (var result = await httpClient.GetAsync(url))
            {
                var content = await result.Content.ReadAsStringAsync();
                return content;
            }
        }
    }
}
