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
            timeOfDay,
        }

        public enum WeatherType
        {
            weatherClear,
            weatherRain,
            weatherSnow,
        }

        public enum CityType
        {
            city1,
            city2,
            city3,
            city4,
            city5,
        }

        public enum DistanceType
        {
            distance3,
            distance37,
            distance710,
            distance10,
        }

        public double cancellationChance { get; set; }
        public double euroPerHour { get; set; }
        public double expectedWaitingTime { get; set; }

        public WeatherType weatherType { get; set; }
        public CityType cityType { get; set; }
        public DistanceType distanceType { get; set; }

        private ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime)
        {
            this.cancellationChance = cancellationChance;
            this.euroPerHour = euroPerHour;
            this.expectedWaitingTime = expectedWaitingTime;
        }

        public ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime, WeatherType type) : this(cancellationChance, euroPerHour, expectedWaitingTime)
        {
            this.weatherType = type;
        }

        public ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime, CityType cityType) : this(cancellationChance, euroPerHour, expectedWaitingTime)
        {
            this.cityType = cityType;
        }

        public ConditionValue(double cancellationChance, double euroPerHour, double expectedWaitingTime, DistanceType distanceType) : this(cancellationChance, euroPerHour, expectedWaitingTime)
        {
            this.distanceType = distanceType;
        }
    }
}
