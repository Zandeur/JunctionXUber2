using JunctionXUber2.DataObjects;
using System;
using System.CodeDom;
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
            List<RowData> clearTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.WeatherType.weatherClear);
            List<RowData> rainTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.WeatherType.weatherRain);
            List<RowData> snowTrips = GetAllRidesWithWeather(rides_trips, weather_daily, ConditionValue.WeatherType.weatherSnow);

            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(CalculateAverageTips(clearTrips), CalculateEarningsPerHour(clearTrips), CalculateTripsPerDay(clearTrips), ConditionValue.WeatherType.weatherClear),
                new ConditionValue(CalculateAverageTips(rainTrips), CalculateEarningsPerHour(rainTrips), CalculateTripsPerDay(rainTrips), ConditionValue.WeatherType.weatherRain),
                new ConditionValue(CalculateAverageTips(snowTrips), CalculateEarningsPerHour(snowTrips), CalculateTripsPerDay(snowTrips), ConditionValue.WeatherType.weatherSnow)
            };

            return new Recommendation(results);
        }

        public List<RowData> GetAllRidesWithWeather(DataWorksheet rides_trips, DataWorksheet weather_daily, ConditionValue.WeatherType weatherType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                string date = trip.data["date"];
                string city_id = trip.data["city_id"];
                RowData correspondingDay = weather_daily.rowDatas.FirstOrDefault(row => row.data["date"].Equals(date) && row.data["city_id"].Equals(city_id));
                if (correspondingDay == null) return false;

                string weatherString = null;
                switch(weatherType)
                {
                    case ConditionValue.WeatherType.weatherSnow:
                        {
                            weatherString = "snow";
                            break;
                        }
                    case ConditionValue.WeatherType.weatherRain:
                        {
                            weatherString = "rain";
                            break;
                        }
                    case ConditionValue.WeatherType.weatherClear:
                        {
                            weatherString = "clear";
                            break;
                        }
                }
                if (weatherString == null) return false;
                return correspondingDay.data["weather"].ToString().Equals(weatherString);
            });
        }

        public Recommendation GetCityRecommendations(DataWorksheet rides_trips)
        {
            List<RowData> city1Trips = GetAllRidesWithCity(rides_trips, ConditionValue.CityType.city1);
            List<RowData> city2Trips = GetAllRidesWithCity(rides_trips, ConditionValue.CityType.city2);
            List<RowData> city3Trips = GetAllRidesWithCity(rides_trips, ConditionValue.CityType.city3);
            List<RowData> city4Trips = GetAllRidesWithCity(rides_trips, ConditionValue.CityType.city4);
            List<RowData> city5Trips = GetAllRidesWithCity(rides_trips, ConditionValue.CityType.city5);


            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(CalculateAverageTips(city1Trips), CalculateEarningsPerHour(city1Trips), CalculateTripsPerDay(city1Trips), ConditionValue.CityType.city1),
                new ConditionValue(CalculateAverageTips(city2Trips), CalculateEarningsPerHour(city2Trips), CalculateTripsPerDay(city2Trips), ConditionValue.CityType.city2),
                new ConditionValue(CalculateAverageTips(city3Trips), CalculateEarningsPerHour(city3Trips), CalculateTripsPerDay(city3Trips), ConditionValue.CityType.city3),
                new ConditionValue(CalculateAverageTips(city4Trips), CalculateEarningsPerHour(city4Trips), CalculateTripsPerDay(city4Trips), ConditionValue.CityType.city4),
                new ConditionValue(CalculateAverageTips(city5Trips), CalculateEarningsPerHour(city5Trips), CalculateTripsPerDay(city5Trips), ConditionValue.CityType.city5)
            };

            return new Recommendation(results);
        }

        public List<RowData> GetAllRidesWithCity(DataWorksheet rides_trips, ConditionValue.CityType cityType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                return trip.data["city_id"].ToString().Equals(CityNumber(cityType).ToString());
            });
        }

        public Recommendation GetDistanceRecommendations(DataWorksheet rides_trips)
        {
            List<RowData> distance3Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.DistanceType.distance3);
            List<RowData> distance37Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.DistanceType.distance37);
            List<RowData> distance710Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.DistanceType.distance710);
            List<RowData> distance10Trips = GetAllRidesWithDistance(rides_trips, ConditionValue.DistanceType.distance10);

            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(CalculateAverageTips(distance3Trips), CalculateEarningsPerHour(distance3Trips), CalculateAverageTips(distance3Trips), ConditionValue.DistanceType.distance3),
                new ConditionValue(CalculateAverageTips(distance37Trips), CalculateEarningsPerHour(distance37Trips), CalculateAverageTips(distance37Trips), ConditionValue.DistanceType.distance37),
                new ConditionValue(CalculateAverageTips(distance710Trips), CalculateEarningsPerHour(distance710Trips), CalculateAverageTips(distance710Trips), ConditionValue.DistanceType.distance710),
                new ConditionValue(CalculateAverageTips(distance10Trips), CalculateEarningsPerHour(distance10Trips), CalculateAverageTips(distance10Trips), ConditionValue.DistanceType.distance10)
            };

            return new Recommendation(results);
        }

        public List<RowData> GetAllRidesWithDistance(DataWorksheet rides_trips, ConditionValue.DistanceType distanceType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                if (!double.TryParse(trip.data["distance_km"].ToString(), out double distance))
                    return false;

                switch (distanceType)
                {
                    case ConditionValue.DistanceType.distance3:
                        return distance < 3;

                    case ConditionValue.DistanceType.distance37:
                        return distance >= 3 && distance <= 7;

                    case ConditionValue.DistanceType.distance710:
                        return distance > 7 && distance <= 10;

                    case ConditionValue.DistanceType.distance10:
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

            return values.Count() > 0 ? values.Average() : 0;
        }

        private double CalculateAverageTips(List<RowData> trips)
        {
            List<double> values = trips.Select(trip =>
            {
                double tip = double.Parse(trip.data["tips"]);
                return tip;
            }).ToList();
            return values.Count() > 0 ? values.Average() : 0;
        }

        private double CalculateTripsPerDay(List<RowData> trips)
        {
            var values = trips.Select(trip =>
            {
                string startString = trip.data["start_time"];
                DateTime startTime = DateTime.ParseExact(startString, "yyyy-MM-dd HH:mm:ss", null);
                return startTime;
            }).ToList();

            int uniqueDays = values
                .Select(t => t.Date)
                .Distinct()
                .Count();

            return uniqueDays == 0 ? 0 : (double)values.Count / uniqueDays;
        }

        public int CityNumber(ConditionValue.CityType type)
        {
            switch (type)
            {
                case ConditionValue.CityType.city1:
                    return 1;
                case ConditionValue.CityType.city2:
                    return 2;
                case ConditionValue.CityType.city3:
                    return 3;
                case ConditionValue.CityType.city4:
                    return 4;
                case ConditionValue.CityType.city5:
                    return 5;
                default:
                    return -1;
            }
        }
    }
}
