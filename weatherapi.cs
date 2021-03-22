using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace convenience_store

{
    public class Weatherapi
    {
        public async Task apiWeather(string[] args)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "leemaijuggle.info");
            var content = await client.GetStringAsync("https://api.weather.gov/points/38.8894,-77.0352");


            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}
