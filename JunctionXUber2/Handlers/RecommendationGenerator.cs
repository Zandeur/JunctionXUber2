using JunctionXUber2.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class RecommendationGenerator
    {
        public Recommendation GetWeatherRecommendations(DataWorksheet rides_trips, DataWorksheet weather_daily)
        {
            List<RowData> clearTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.ConditionType.weatherClear);
            List<RowData> rainTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.ConditionType.weatherRain);
            List<RowData> snowTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.ConditionType.weatherSnow);

            List<ConditionValue> results = new List<ConditionValue>();
            results.Add(new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherClear));
            results.Add(new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherRain));
            results.Add(new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherSnow));

            return new Recommendation(results);
        }

        private List<RowData> GetAllRidesWithWeather(DataWorksheet rides_trips, DataWorksheet weather_daily, ConditionValue.ConditionType weatherType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                string date = trip.data["date"];
                string city_id = trip.data["city_id"];
                RowData correspondingDay = weather_daily.rowDatas.FirstOrDefault(row => row.data["date"].Equals(date) && row.data["city_id"].Equals(city_id));
                if (correspondingDay == null) return false;
                return correspondingDay.data["weather"].ToString().Equals(weatherType.ToString());
            });
        }

        public Recommendation GetCityRecommendations(DataWorksheet rides_trips)
        {
            List<RowData> city1Trips = GetAllRidesWithCity(rides_trips, ConditionValue.ConditionType.city1);
            List<RowData> city2Trips = GetAllRidesWithCity(rides_trips, ConditionValue.ConditionType.city2);
            List<RowData> city3Trips = GetAllRidesWithCity(rides_trips, ConditionValue.ConditionType.city3);
            List<RowData> city4Trips = GetAllRidesWithCity(rides_trips, ConditionValue.ConditionType.city4);
            List<RowData> city5Trips = GetAllRidesWithCity(rides_trips, ConditionValue.ConditionType.city5);

            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(0, CalculateEarningsPerHour(city1Trips), 0, ConditionValue.ConditionType.city1),
                new ConditionValue(0, CalculateEarningsPerHour(city2Trips), 0, ConditionValue.ConditionType.city2),
                new ConditionValue(0, CalculateEarningsPerHour(city3Trips), 0, ConditionValue.ConditionType.city3),
                new ConditionValue(0, CalculateEarningsPerHour(city4Trips), 0, ConditionValue.ConditionType.city4),
                new ConditionValue(0, CalculateEarningsPerHour(city5Trips), 0, ConditionValue.ConditionType.city5)
            };

            return new Recommendation(results);
        }

        private List<RowData> GetAllRidesWithCity(DataWorksheet rides_trips, ConditionValue.ConditionType cityType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                return trip.data["city_id"].ToString().Equals(cityType.ToString());
            });
        }

        public Recommendation GetDistanceRecommendations(DataWorksheet rides_trips)
        {
            List<RowData> distance3Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.ConditionType.distance3);
            List<RowData> distance37Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.ConditionType.distance37);
            List<RowData> distance710Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.ConditionType.distance710);
            List<RowData> distance10Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.ConditionType.distance10);

            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(0, CalculateEarningsPerHour(distance3Trips), 0, ConditionValue.ConditionType.distance3),
                new ConditionValue(0, CalculateEarningsPerHour(distance37Trips), 0, ConditionValue.ConditionType.distance37),
                new ConditionValue(0, CalculateEarningsPerHour(distance710Trips), 0, ConditionValue.ConditionType.distance710),
                new ConditionValue(0, CalculateEarningsPerHour(distance10Trips), 0, ConditionValue.ConditionType.distance10)
            };

            return new Recommendation(results);
        }

        private List<RowData> GetAllRidesWithDistance(DataWorksheet rides_trips, ConditionValue.ConditionType distanceType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                if (!double.TryParse(trip.data["distance_km"].ToString(), out double distance))
                    return false;

                switch (distanceType)
                {
                    case ConditionValue.ConditionType.distance3:
                        return distance < 3;

                    case ConditionValue.ConditionType.distance37:
                        return distance >= 3 && distance <= 7;

                    case ConditionValue.ConditionType.distance710:
                        return distance > 7 && distance <= 10;

                    case ConditionValue.ConditionType.distance10:
                        return distance > 10;

                    default:
                        return false;
                }
            });
        }

        private double CalculateEarningsPerHour(List<RowData> trips)
        {
            List<double> values =  trips.Select(trip =>
            {
                double earning = double.Parse(trip.data["net_earnings"]);

                string startString = trip.data["start_time"];
                string endString = trip.data["end_time"];

                DateTime startTime = DateTime.ParseExact(startString, "yyyy-MM-dd HH:mm:ss", null);
                DateTime endTime = DateTime.ParseExact(endString, "yyyy-MM-dd HH:mm:ss", null);

                TimeSpan duration = endTime - startTime;

                double earningsPerHour = earning / duration.TotalHours;
                return earningsPerHour;
            }).ToList();

            if (values.Count() > 0)
            {
                return values.Average();
            } else
            {
                return -1;
            }
        }
    }
}
