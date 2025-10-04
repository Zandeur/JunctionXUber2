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
            distance,
            timeOfDay,
        }

        public double cancellationChance;
        public double euroPerHour;
        public double expectedWaitingTime;
        public ConditionType type;

        public ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime, ConditionType type) 
        {
            this.cancellationChance = cancellationChance;
            this.euroPerHour= euroPerHour;
            this.expectedWaitingTime = expectedWaitingTime;
            this.type = type;
        }
    }
}
