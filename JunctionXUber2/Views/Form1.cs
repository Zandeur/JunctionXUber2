using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using JunctionXUber2.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunctionXUber2
{
    public partial class Form1 : Form
    {
        private readonly CustomerEnumConverter enumConverter = new CustomerEnumConverter();
        private readonly DataWorksheetHandler dataWorksheetHandler = new DataWorksheetHandler();
        private Dataworksheets dataworksheets;

        private readonly string defaultOptimalString;
        private readonly string defaultWeatherLabelString;
        private readonly string defaultCityLabelString;

        public Form1()
        {
            InitializeComponent();

            defaultOptimalString = labelOptimalSuggestion.Text;
            defaultWeatherLabelString = labelWeatherSuggestion.Text;
            defaultCityLabelString = labelCitySuggestion.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectUserId_Click(object sender, EventArgs e)
        {
            dataworksheets = dataWorksheetHandler.GetDataWorksheets(textBoxUserId.Text);

            UpdateWomboCombo();
            UpdateWeatherRecommendation();
            UpdateCityRecommendation();
        }

        private void UpdateWomboCombo()
        {
            WomboComboGenerator womboComboGenerator = new WomboComboGenerator();
            DataWorksheet rides_trips = dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips);
            DataWorksheet weather = dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.weather_daily);
            WomboCombo womboCombo = womboComboGenerator.GetOptimalCombination(rides_trips.rowDatas, weather);
            if (womboCombo == null) return;

            labelOptimalSuggestion.Text = enumConverter.GetOptimalSuggestion(defaultOptimalString, womboCombo);
        }

        private void UpdateWeatherRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation weatherRecommendation = recommendationGenerator.GetWeatherRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips), dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.weather_daily));

            ConditionValue optimalWeatherCondition = weatherRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelWeatherSuggestion.Text = enumConverter.GetOptimalWeather(defaultWeatherLabelString, optimalWeatherCondition);
        }

        private void UpdateCityRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation cityRecommendation = recommendationGenerator.GetCityRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips));

            ConditionValue optimalCityCondition = cityRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelCitySuggestion.Text = enumConverter.GetOptimalCity(defaultCityLabelString, optimalCityCondition);
        }
    }
}
