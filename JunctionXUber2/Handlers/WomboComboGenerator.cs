using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class WomboComboGenerator
    {
        public WomboCombo GetOptimalCombination(
            List<RowData> trips,
            DataWorksheet weather_daily,
            ConditionValue.ConditionType? filterWeather = null,
            ConditionValue.ConditionType? filterCity = null,
            ConditionValue.ConditionType? filterDistance = null)
        {
            var filteredTrips = trips.Where(trip =>
            {
                var weather = MapToWeather(trip, weather_daily);
                var city = MapToCity(trip);
                var distance = MapToDistance(trip);

                bool matchWeather = !filterWeather.HasValue || weather == filterWeather.Value;
                bool matchCity = !filterCity.HasValue || city == filterCity.Value;
                bool matchDistance = !filterDistance.HasValue || distance == filterDistance.Value;

                return matchWeather && matchCity && matchDistance;
            }).ToList();

            if (!filteredTrips.Any()) return null;

            var tripEarnings = filteredTrips.Select(trip =>
            {
                double earnings = double.Parse(trip.data["net_earnings"]);
                DateTime startTime = DateTime.ParseExact(trip.data["start_time"], "yyyy-MM-dd HH:mm:ss", null);
                DateTime endTime = DateTime.ParseExact(trip.data["end_time"], "yyyy-MM-dd HH:mm:ss", null);

                double hours = (endTime - startTime).TotalHours;
                if (hours <= 0) return null;

                return new
                {
                    Weather = MapToWeather(trip, weather_daily),
                    City = MapToCity(trip),
                    Distance = MapToDistance(trip),
                    EarningsPerHour = earnings / hours
                };
            })
            .Where(x => x != null)
            .ToList();

            if (!tripEarnings.Any()) return null;

            var optimalCombo = tripEarnings
                .GroupBy(t => new { t.Weather, t.City, t.Distance })
                .Select(g => new WomboCombo
                {
                    Weather = g.Key.Weather,
                    City = g.Key.City,
                    Distance = g.Key.Distance,
                    AvgEarningsPerHour = g.Average(x => x.EarningsPerHour)
                })
                .OrderByDescending(c => c.AvgEarningsPerHour)
                .FirstOrDefault();

            return optimalCombo;
        }

        private static ConditionValue.ConditionType MapToWeather(RowData trip, DataWorksheet weather_daily)
        {
            string date = trip.data["date"];
            string city_id = trip.data["city_id"];

            RowData correspondingDay = weather_daily.rowDatas
                .FirstOrDefault(row => row.data["date"].Equals(date) && row.data["city_id"].Equals(city_id));

            if (correspondingDay == null)
                return ConditionValue.ConditionType.weatherClear;

            string weatherString = correspondingDay.data["weather"].ToString().ToLower().Trim();

            switch (weatherString)
            {
                case "snow":
                    return ConditionValue.ConditionType.weatherSnow;

                case "rain":
                    return ConditionValue.ConditionType.weatherRain;

                case "clear":
                    return ConditionValue.ConditionType.weatherClear;

                default:
                    Console.WriteLine($"[Warning] Unknown weather string: {weatherString}");
                    return ConditionValue.ConditionType.weatherClear;
            }
        }

        private ConditionValue.ConditionType MapToCity(RowData trip)
        {
            string city = trip.data["city_id"].ToString().ToLower();

            switch (city)
            {
                case "1":
                    return ConditionValue.ConditionType.city1;
                case "2":
                    return ConditionValue.ConditionType.city2;
                case "3":
                    return ConditionValue.ConditionType.city3;
                case "4":
                    return ConditionValue.ConditionType.city4;
                case "5":
                    return ConditionValue.ConditionType.city5;
                default:
                    return ConditionValue.ConditionType.city1;
            }
        }

        private ConditionValue.ConditionType MapToDistance(RowData trip)
        {
            double dist = double.Parse(trip.data["distance_km"]);
            if (dist < 3) return ConditionValue.ConditionType.distance3;
            else if (dist < 7) return ConditionValue.ConditionType.distance37;
            else if (dist < 10) return ConditionValue.ConditionType.distance710;
            else return ConditionValue.ConditionType.distance10;
        }
    }
}
