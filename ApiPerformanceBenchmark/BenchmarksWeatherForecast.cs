using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiPerformanceBenchmark
{
    [IterationCount(3)]
    public class BenchmarksWeatherForecast
    {
        [GlobalSetup]
        public void Setup()
        {
        }

        private readonly Consumer consumer = new Consumer();

        [Benchmark]
        public async Task TryGetWeather()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7282/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("WeatherForecast");

            IEnumerable<WeatherForecast> myInstance;
            myInstance = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(await response.Content.ReadAsStringAsync());
            myInstance.Consume(consumer);
        }
    }
}
