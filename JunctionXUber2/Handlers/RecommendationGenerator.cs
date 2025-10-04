using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class RecommendationGenerator
    {
        public Recommendation GetWeatherRecommendation(DataWorksheet rides_trips, DataWorksheet weather_daily)
        {
            Recommendation recommendation = new Recommendation();

            List<RowData> clearDays = GetAllRidesWithWeather(rides_trips, weather_daily, WeatherTypes.Type.clear);
            List<RowData> rainDays = GetAllRidesWithWeather(rides_trips, weather_daily, WeatherTypes.Type.rain);
            List<RowData> snowDays = GetAllRidesWithWeather(rides_trips, weather_daily, WeatherTypes.Type.snow);

            return recommendation;
        }

        private List<RowData> GetAllRidesWithWeather(DataWorksheet rides_trips, DataWorksheet weather_daily, WeatherTypes.Type weatherType)
        {
            return rides_trips.rowDatas.FindAll(trip =>
            {
                string date = trip.data["date"];
                string city_id = trip.data["city_id"];
                RowData correspondingDay = weather_daily.rowDatas.FirstOrDefault(row => row.data["date"].Equals(date) && row.data["city_id"].Equals(city_id));
                if (correspondingDay == null) return false;
                return correspondingDay.data["weather"].ToString().Equals(WeatherTypes.Type.clear.ToString());
            });
        }
    }
}
