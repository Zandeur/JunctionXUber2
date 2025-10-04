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
                string weatherType = enumConverter.ConvertWeahter(weatherCondition.type);
                series.Points.AddXY(weatherType, weatherCondition.euroPerHour);
            });
        }
    }
}
