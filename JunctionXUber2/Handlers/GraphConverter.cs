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
        public void SetWeatherDataPoints(Series series, List<ConditionValue> weatherConditions)
        {
            series.Points.Clear();
            List<ConditionValue> orderedWeatherConditions = weatherConditions.OrderBy(w => w.euroPerHour).ToList();

            for (int i = 0; i < orderedWeatherConditions.Count; i++)
            {
                series.Points.Add(i, orderedWeatherConditions[i].euroPerHour);
            }
        }
    }
}
