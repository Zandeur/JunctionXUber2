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

            List<ConditionValue> results = new List<ConditionValue>
            {
                new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherClear),
                new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherRain),
                new ConditionValue(0, CalculateEarningsPerHour(clearTrips), 0, ConditionValue.ConditionType.weatherSnow)
            };

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

            return values.Count() > 0 ? values.Average() : -1;
        }
    }
}
