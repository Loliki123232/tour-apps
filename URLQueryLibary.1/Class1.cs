using System;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace URLQueryLibary
{
    public class urlQiery
    {
        private readonly string _city1;
        private readonly string _city2;

        public urlQiery(string city1, string city2)
        {
            _city1 = city1 ?? throw new ArgumentNullException(nameof(city1));
            _city2 = city2 ?? throw new ArgumentNullException(nameof(city2));
        }

        public async Task<double> GetDistanceAsync()
        {
            try
            {
                var (lon1, lat1) = await GetCoordinates(_city1);
                var (lon2, lat2) = await GetCoordinates(_city2);
                return await CalculateDistance(lon1, lat1, lon2, lat2);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при расчете расстояния: {ex.Message}", ex);
            }
        }

        private static async Task<(double lon, double lat)> GetCoordinates(string city)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "DistanceCalculator/1.0");

            var url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(city)}&format=json";
            var response = await httpClient.GetStringAsync(url);

            using var doc = JsonDocument.Parse(response);

            if (doc.RootElement.GetArrayLength() == 0)
                throw new Exception($"Город '{city}' не найден");

            var firstResult = doc.RootElement[0];

            try
            {
                // Обрабатываем разные форматы координат
                var lon = ParseCoordinate(firstResult, "lon");
                var lat = ParseCoordinate(firstResult, "lat");
                return (lon, lat);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка обработки координат для города '{city}': {ex.Message}", ex);
            }
        }

        private static double ParseCoordinate(JsonElement element, string propertyName)
        {
            if (element.TryGetProperty(propertyName, out var prop))
            {
                // Пробуем разные варианты парсинга
                if (prop.ValueKind == JsonValueKind.Number)
                    return prop.GetDouble();

                if (prop.ValueKind == JsonValueKind.String)
                {
                    if (double.TryParse(prop.GetString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
                        return result;
                }
            }

            throw new FormatException($"Не удалось преобразовать координату '{propertyName}'");
        }

        private static async Task<double> CalculateDistance(double lon1, double lat1, double lon2, double lat2)
        {
            using var httpClient = new HttpClient();
            var url = $"http://router.project-osrm.org/route/v1/driving/{lon1.ToString(CultureInfo.InvariantCulture)},{lat1.ToString(CultureInfo.InvariantCulture)};{lon2.ToString(CultureInfo.InvariantCulture)},{lat2.ToString(CultureInfo.InvariantCulture)}?overview=false";

            var response = await httpClient.GetStringAsync(url);
            using var doc = JsonDocument.Parse(response);

            try
            {
                var route = doc.RootElement.GetProperty("routes")[0];
                var distanceProp = route.GetProperty("distance");

                // Обрабатываем разные форматы расстояния
                double distanceMeters = distanceProp.ValueKind switch
                {
                    JsonValueKind.Number => distanceProp.GetDouble(),
                    JsonValueKind.String when double.TryParse(distanceProp.GetString(), NumberStyles.Any, CultureInfo.InvariantCulture, out var result) => result,
                    _ => throw new FormatException("Неподдерживаемый формат расстояния")
                };
                return Convert.ToInt32(Math.Ceiling(distanceMeters)/1000); // Конвертируем в километры
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка обработки данных маршрута", ex);
            }
        }
    }
}