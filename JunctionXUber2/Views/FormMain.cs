using JunctionXUber2.DataObjects;
using JunctionXUber2.DataObjects.Conditions;
using JunctionXUber2.Handlers;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunctionXUber2.Views
{
    public partial class FormMain : MaterialForm
    {
        private readonly CustomerEnumConverter enumConverter = new CustomerEnumConverter();
        private readonly GraphConverter graphConverter = new GraphConverter();

        private readonly DataWorksheetHandler dataWorksheetHandler = new DataWorksheetHandler();

        private Dataworksheets dataworksheets;

        private readonly string defaultOptimalString;
        private readonly string defaultWeatherLabelString;
        private readonly string defaultCityLabelString;
        private readonly string defaultDistanceString;

        public FormMain()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Choose a color scheme (primary, dark primary, light primary, accent, text)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Cyan300, Accent.LightBlue200,
                TextShade.WHITE
            );

            defaultOptimalString = labelOptimalSuggestion.Text;
            defaultWeatherLabelString = labelWeatherSuggestion.Text;
            defaultCityLabelString = labelCitySuggestion.Text;
            defaultDistanceString = labelDistanceSuggestion.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserId_TextChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void buttonSelectUserId_Click(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            dataworksheets = dataWorksheetHandler.GetDataWorksheets($"E{textBoxUserId.Text}");

            UpdateWomboCombo();
            UpdateWeatherRecommendation();
            UpdateCityRecommendation();
            UpdateDistanceRecommendation();
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

            graphConverter.SetWeatherDataPoints(chartWeather.Series.First(), weatherRecommendation.sortedConditionValues);
        }

        private void UpdateCityRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation cityRecommendation = recommendationGenerator.GetCityRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips));

            ConditionValue optimalCityCondition = cityRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelCitySuggestion.Text = enumConverter.GetOptimalCity(defaultCityLabelString, optimalCityCondition);
        }

        private void UpdateDistanceRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation distanceRecommendation = recommendationGenerator.GetDistanceRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips));

            ConditionValue optimalDistanceCondition = distanceRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelDistanceSuggestion.Text = enumConverter.GetOptimalDistance(defaultDistanceString, optimalDistanceCondition);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            tabSelectorMain.Size = new Size(this.Width, tabSelectorMain.Height);
        }
    }
}
