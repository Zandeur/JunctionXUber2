using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class ConditionValue
    {
        public enum ConditionType
        {
            weatherClear,
            weatherRain,
            weatherSnow,
            city1,
            city2,
            city3,
            city4,
            city5,
            distance3,
            distance37,
            distance710,
            distance10,
            timeOfDay,
        }

        public double cancellationChance { get; set; }
        public double euroPerHour { get; set; }
        public double expectedWaitingTime { get; set; }
        public ConditionType type { get; set; }

        public ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime, ConditionType type) 
        {
            this.cancellationChance = cancellationChance;
            this.euroPerHour= euroPerHour;
            this.expectedWaitingTime = expectedWaitingTime;
            this.type = type;
        }
    }
}
