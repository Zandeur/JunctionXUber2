using JunctionXUber2.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
