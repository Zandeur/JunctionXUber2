using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JunctionXUber2.Handlers
{
    internal class GraphConverter
    {
        CustomerEnumConverter enumConverter = new CustomerEnumConverter();

        public void SetWeatherDataPoints(Series series, List<ConditionValue> weatherConditions)
        {
            series.Points.Clear();
            weatherConditions.OrderBy(w => w.euroPerHour).ToList().ForEach(weatherCondition =>
            {
                string weatherType = enumConverter.ConvertWeahter(weatherCondition.weatherType);
                series.Points.AddXY(weatherType, weatherCondition.euroPerHour);
            });
        }

        public void SetCityDataPoints(Series series, List<ConditionValue> cityConditions)
        {
            series.Points.Clear();
            cityConditions.ForEach(cityCondition =>
            {
                string city = cityCondition.cityType.ToString();
                series.Points.AddXY(city, cityCondition.euroPerHour);
            });
        }

        public void SetDistanceDataPoints(Series series, List<ConditionValue> distanceConditions)
        {
            series.Points.Clear();
            distanceConditions.ForEach(distanceCondition =>
            {
                string distance = $"{enumConverter.ConvertDistance(distanceCondition.distanceType)} km";
                series.Points.AddXY(distance, distanceCondition.euroPerHour);
            });
        }

        public void SetOptimalDataPoints(Series series, DataWorksheet rides_trips, DataWorksheet weather_daily, WomboCombo womboCombo)
        {
            if(womboCombo == null)
            {
                series.Points.AddXY(0,0);
                return;
            }
            series.Points.Clear();

            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            List<RowData> tripsWithOptimalWeather = recommendationGenerator.GetAllRidesWithWeather(rides_trips, weather_daily, womboCombo.Weather);
            DataWorksheet optimalWeatherWorksheet = new DataWorksheet(Dataworksheets.WorksheetName.rides_trips, tripsWithOptimalWeather);
            List<RowData> tripsWithOptimalWeatherAndDistance = recommendationGenerator.GetAllRidesWithDistance(optimalWeatherWorksheet, womboCombo.Distance);
            DataWorksheet optimalWeatherWorksheetAndDistance = new DataWorksheet(Dataworksheets.WorksheetName.rides_trips, tripsWithOptimalWeatherAndDistance);
            List<RowData> tripsOptimal = recommendationGenerator.GetAllRidesWithCity(optimalWeatherWorksheetAndDistance, womboCombo.City);

            var dailyAverages = tripsOptimal
            .Select(t =>
            {
                DateTime start = DateTime.Parse(t.data["start_time"]);
                DateTime end = DateTime.Parse(t.data["end_time"]);

                double netEarnings = Convert.ToDouble(t.data["net_earnings"]);

                double hours = (end - start).TotalHours;
                double earningsPerHour = hours > 0 ? netEarnings / hours : 0;

                return new
                {
                    Date = start.Date,
                    EarningsPerHour = earningsPerHour
                };
            })
            .GroupBy(x => x.Date)
            .Select(g => new
            {
                Date = g.Key,
                AverageEarnings = g.Average(x => x.EarningsPerHour)
            })
            .OrderBy(x => x.Date)
            .ToList();

            series.Points.Clear();

            foreach (var day in dailyAverages)
            {
                series.Points.AddXY(day.Date.ToShortDateString(), day.AverageEarnings);
            }

        }
    }
}
