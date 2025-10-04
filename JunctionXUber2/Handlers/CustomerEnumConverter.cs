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
        private string ConvertDistance(ConditionValue.ConditionType distance)
        {
            switch(distance)
            {
                case ConditionValue.ConditionType.distance3: return "<3";
                case ConditionValue.ConditionType.distance37: return "3-7";
                case ConditionValue.ConditionType.distance710: return "7-10";
                case ConditionValue.ConditionType.distance10: return ">10";
                default: return "-";
            }
        }

        private string ConvertWeahter(ConditionValue.ConditionType weather)
        {
            switch(weather)
            {
                case ConditionValue.ConditionType.weatherClear: return "clear";
                case ConditionValue.ConditionType.weatherSnow: return "snowing";
                case ConditionValue.ConditionType.weatherRain: return "raining";
                default: return "-";
            }
        }

        private string ConvertCity(ConditionValue.ConditionType city)
        {
            switch (city)
            {
                case ConditionValue.ConditionType.city1: return "city 1";
                case ConditionValue.ConditionType.city2: return "city 2";
                case ConditionValue.ConditionType.city3: return "city 3";
                case ConditionValue.ConditionType.city4: return "city 4";
                case ConditionValue.ConditionType.city5: return "city 5";
                default: return "-";
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
            return newLabelText.Replace("[weather]", ConvertWeahter(weatherCondition.type));
        }
        public string GetOptimalCity(string defaultText, ConditionValue cityCondition)
        {
            string newLabelText = defaultText.Replace("[money]", cityCondition.euroPerHour.ToString("F2"));
            return newLabelText.Replace("[city]", ConvertCity(cityCondition.type));
        }
    }
}
