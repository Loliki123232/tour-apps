using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace URLQueryLibary
{
    public class UrlQiery
    {
        string City1 { get; set; }
        string City2 { get; set; }
        public double distanceBetweenCities { get; private set; }

        public UrlQiery(string city1, string city2)
        {
            City1 = city1;
            City2 = city2;
        }

        public async Task<double> GetDistanceAsync()
        {
            
            try
            {
        
                distanceBetweenCities = await GetDistanceBetweenCities(City1, City2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            return distanceBetweenCities;
        }

        // Метод для получения координат города
        static async Task<(double lon, double lat)> GetCoordinates(string city)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "DistanceCalculator/1.0");

                string url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(city)}&format=json";
                string response = await httpClient.GetStringAsync(url);

                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    JsonElement firstResult = doc.RootElement[0];

                    return (
                        firstResult.GetProperty("lon").GetDouble(),
                        firstResult.GetProperty("lat").GetDouble()
                    );
                }
            }
        }



        static async Task<double> GetDistanceBetweenCities(string city1, string city2)
        {
            var coords1 = await GetCoordinates(city1);
            double lon1 = coords1.lon;
            double lat1 = coords1.lat;
            var coords2 = await GetCoordinates(city2);
            double lon2 = coords2.lon;
            double lat2 = coords2.lat;
            using (var httpClient = new HttpClient())
            {
                string url = $"http://router.project-osrm.org/route/v1/driving/{lon1},{lat1};{lon2},{lat2}?overview=false";
                string response = await httpClient.GetStringAsync(url);

                using (JsonDocument doc = JsonDocument.Parse(response))
                {
                    double distanceMeters = doc.RootElement
                        .GetProperty("routes")[0]
                        .GetProperty("distance")
                        .GetDouble();

                    return distanceMeters / 1000; 
                }
            }
        }
    }
}