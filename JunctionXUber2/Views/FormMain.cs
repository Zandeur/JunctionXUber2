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

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Cyan300, Accent.LightBlue200,
                TextShade.WHITE
            );

            defaultOptimalString = labelOptimalSuggestion.Text;
            defaultWeatherLabelString = labelWeatherSuggestion.Text;
            defaultCityLabelString = labelCitySuggestion.Text;
            defaultDistanceString = labelDistanceSuggestion.Text;

            AddComboBoxFilters();
        }



        private void AddComboBoxFilters()
        {
            materialComboBoxWeather.Items.Add("-");
            foreach (ConditionValue.WeatherType weather in Enum.GetValues(typeof(ConditionValue.WeatherType)))
            {
                materialComboBoxWeather.Items.Add(enumConverter.ConvertWeahter(weather));
            }
            materialComboBoxWeather.SelectedIndex = 0;

            materialComboBoxDistance.Items.Add("-");
            foreach (ConditionValue.DistanceType distance in Enum.GetValues(typeof(ConditionValue.DistanceType)))
            {
                materialComboBoxDistance.Items.Add(enumConverter.ConvertDistance(distance));
            }
            materialComboBoxDistance.SelectedIndex = 0;

            materialComboBoxCity.Items.Add("-");
            foreach (ConditionValue.CityType city in Enum.GetValues(typeof(ConditionValue.CityType)))
            {
                materialComboBoxCity.Items.Add(enumConverter.ConvertCity(city));
            }
            materialComboBoxCity.SelectedIndex = 0;
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

            ConditionValue.WeatherType? selectedWeather = enumConverter.ConvertWeahterString(materialComboBoxWeather.SelectedItem?.ToString());
            ConditionValue.DistanceType? selectedDistance = enumConverter.ConvertDistanceString(materialComboBoxDistance.SelectedItem?.ToString());
            ConditionValue.CityType? selectedCity = enumConverter.ConvertCityString(materialComboBoxCity.SelectedItem?.ToString());

            WomboCombo womboCombo = womboComboGenerator.GetOptimalCombination(rides_trips.rowDatas, weather, selectedWeather, selectedCity, selectedDistance);
            if (womboCombo == null)
            {
                optimalchart.Series.First().Points.Clear();

                labelOptimalSuggestion.Text = "You have no previous trips for this combination";
                graphConverter.SetOptimalDataPoints(optimalchart.Series.First(), rides_trips, weather, womboCombo);
                return;
            }

            graphConverter.SetOptimalDataPoints(optimalchart.Series.First(), rides_trips, weather, womboCombo);

            Color lightBlue200 = Color.FromArgb(64, 196, 255);
            var series = optimalchart.Series.First();
            series.Color = lightBlue200;
            foreach (var point in series.Points)
            {
                point.Color = lightBlue200;
                point.MarkerColor = lightBlue200;
                point.BorderColor = lightBlue200;
            }


            labelOptimalSuggestion.Text = enumConverter.GetOptimalSuggestion(defaultOptimalString, womboCombo);
        }

        private void UpdateWeatherRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation weatherRecommendation = recommendationGenerator.GetWeatherRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips), dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.weather_daily));

            ConditionValue optimalWeatherCondition = weatherRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelWeatherSuggestion.Text = enumConverter.GetOptimalWeather(defaultWeatherLabelString, optimalWeatherCondition);

            graphConverter.SetWeatherDataPoints(chartWeather.Series.First(), weatherRecommendation.sortedConditionValues);

            Color lightBlue200 = Color.FromArgb(64, 196, 255);
            var series = chartWeather.Series.First();
            series.Color = lightBlue200;
            foreach (var point in series.Points)
            {
                point.Color = lightBlue200;
                point.MarkerColor = lightBlue200;
                point.BorderColor = lightBlue200;
            }
        }

        private void UpdateCityRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation cityRecommendation = recommendationGenerator.GetCityRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips));

            ConditionValue optimalCityCondition = cityRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelCitySuggestion.Text = enumConverter.GetOptimalCity(defaultCityLabelString, optimalCityCondition);

            graphConverter.SetCityDataPoints(chartCity.Series.First(), cityRecommendation.sortedConditionValues);

            Color lightBlue200 = Color.FromArgb(64, 196, 255);
            var series = chartCity.Series.First();
            series.Color = lightBlue200;
            foreach (var point in series.Points)
            {
                point.Color = lightBlue200;
                point.MarkerColor = lightBlue200;
                point.BorderColor = lightBlue200;
            }
        }

        private void UpdateDistanceRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation distanceRecommendation = recommendationGenerator.GetDistanceRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips));

            ConditionValue optimalDistanceCondition = distanceRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            labelDistanceSuggestion.Text = enumConverter.GetOptimalDistance(defaultDistanceString, optimalDistanceCondition);

            graphConverter.SetDistanceDataPoints(chartDistance.Series.First(), distanceRecommendation.sortedConditionValues);

            Color lightBlue200 = Color.FromArgb(64, 196, 255);
            var series = chartDistance.Series.First();
            series.Color = lightBlue200;
            foreach (var point in series.Points)
            {
                point.Color = lightBlue200;
                point.MarkerColor = lightBlue200;
                point.BorderColor = lightBlue200;
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            tabSelectorMain.Size = new Size(this.Width, tabSelectorMain.Height);
        }

        private void materialComboBoxWeather_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void materialComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void materialComboBoxDistance_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI();
        }
    }
}
