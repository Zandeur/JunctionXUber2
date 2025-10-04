using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class Dataworksheets
    {
        public enum WorksheetName
        {
            rides_trips,
            earnings_daily,
            surge_by_hour,
            cancellation_rates,
            heatmap,
            weather_daily,
        }

        public List<DataWorksheet> dataworksheets;

        public Dataworksheets(List<DataWorksheet> dataworksheets)
        {
            this.dataworksheets = dataworksheets;
        }

        public DataWorksheet GetDataWorksheetWithName(WorksheetName worksheetName)
        {
            return dataworksheets.First(w => w.name == worksheetName);
        }
    }
}
