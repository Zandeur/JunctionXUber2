using JunctionXUber2.DataObjects;
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
        private readonly DataWorksheetHandler dataWorksheetHandler = new DataWorksheetHandler();
        private Dataworksheets dataworksheets;

        private readonly string weatherLabelString;

        public Form1()
        {
            InitializeComponent();

            weatherLabelString = labelWeatherSuggestion.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSelectUserId_Click(object sender, EventArgs e)
        {
            dataworksheets = dataWorksheetHandler.GetDataWorksheets(textBoxUserId.Text);

            UpdateWeatherRecommendation();
        }

        private void UpdateWeatherRecommendation()
        {
            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            Recommendation weatherRecommendation = recommendationGenerator.GetWeatherRecommendations(dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.rides_trips), dataworksheets.GetDataWorksheetWithName(Dataworksheets.WorksheetName.weather_daily));

            ConditionValue optimalCondition = weatherRecommendation.sortedConditionValues.OrderByDescending(recommendation => recommendation.euroPerHour).FirstOrDefault();
            
            string newLabelText = weatherLabelString.Replace("[money]", optimalCondition.euroPerHour.ToString("F2"));
            newLabelText = newLabelText.Replace("[weather]", optimalCondition.type.ToString());

            labelWeatherSuggestion.Text = newLabelText;
        }
    }
}
