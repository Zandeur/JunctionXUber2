using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class CustomerEnumConverter
    {
        public string ConvertDistance(ConditionValue.DistanceType distance)
        {
            switch(distance)
            {
                case ConditionValue.DistanceType.distance3: return "<3";
                case ConditionValue.DistanceType.distance37: return "3-7";
                case ConditionValue.DistanceType.distance710: return "7-10";
                case ConditionValue.DistanceType.distance10: return ">10";
                default: return "-";
            }
        }

        public ConditionValue.DistanceType? ConvertDistanceString(String distance)
        {
            switch (distance)
            {
                case "<3": return ConditionValue.DistanceType.distance3;
                case "3-7": return ConditionValue.DistanceType.distance37;
                case "7-10": return ConditionValue.DistanceType.distance710;
                case ">10": return ConditionValue.DistanceType.distance10;
                default: return null;
            }
        }

        public string ConvertWeahter(ConditionValue.WeatherType weather)
        {
            switch(weather)
            {
                case ConditionValue.WeatherType.weatherClear: return "clear";
                case ConditionValue.WeatherType.weatherSnow: return "snowing";
                case ConditionValue.WeatherType.weatherRain: return "raining";
                default: return "-";
            }
        }

        public ConditionValue.WeatherType? ConvertWeahterString (String weather)
        {
            switch (weather)
            {
                case "clear": return ConditionValue.WeatherType.weatherClear;
                case "snowing": return ConditionValue.WeatherType.weatherSnow;
                case "raining": return ConditionValue.WeatherType.weatherRain;
                default: return null;
            }
        }

        public string ConvertCity(ConditionValue.CityType city)
        {
            switch (city)
            {
                case ConditionValue.CityType.city1: return "city 1";
                case ConditionValue.CityType.city2: return "city 2";
                case ConditionValue.CityType.city3: return "city 3";
                case ConditionValue.CityType.city4: return "city 4";
                case ConditionValue.CityType.city5: return "city 5";
                default: return "-";
            }
        }

        public ConditionValue.CityType? ConvertCityString(String city)
        {
            switch (city)
            {
                case "city 1": return ConditionValue.CityType.city1;
                case "city 2": return ConditionValue.CityType.city2;
                case "city 3": return ConditionValue.CityType.city3;
                case "city 4": return ConditionValue.CityType.city4;
                case "city 5": return ConditionValue.CityType.city5;
                default: return null;
            }
        }

        public string GetOptimalSuggestion(string defaultText, WomboCombo womboCombo)
        {
            string newLabelText = defaultText.Replace("[weather]", ConvertWeahter(womboCombo.Weather));
            newLabelText = newLabelText.Replace("[money]", womboCombo.AvgEarningsPerHour.ToString("F2"));
            newLabelText = newLabelText.Replace("[city]", womboCombo.City.ToString());
            return newLabelText.Replace("[distance]", ConvertDistance(womboCombo.Distance));
        }

        public string GetOptimalWeather(string defaultText, ConditionValue weatherCondition)
        {
            string newLabelText = defaultText.Replace("[money]", weatherCondition.euroPerHour.ToString("F2"));
            return newLabelText.Replace("[weather]", ConvertWeahter(weatherCondition.weatherType));
        }
        public string GetOptimalCity(string defaultText, ConditionValue cityCondition)
        {
            string newLabelText = defaultText.Replace("[money]", cityCondition.euroPerHour.ToString("F2"));
            return newLabelText.Replace("[city]", ConvertCity(cityCondition.cityType));
        }
        public string GetOptimalDistance(string defaultText, ConditionValue distanceCondition)
        {
            string newLabelText = defaultText.Replace("[money]", distanceCondition.euroPerHour.ToString("F2"));
            return newLabelText.Replace("[distance]", ConvertDistance(distanceCondition.distanceType));
        }
    }
}
