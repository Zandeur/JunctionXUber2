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
        private Dataworksheets dataworksheets;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelReader excelReader = new ExcelReader();
            dataworksheets = excelReader.GetWorksheets();

            RecommendationGenerator recommendationGenerator = new RecommendationGenerator();
            recommendationGenerator.GetWeatherRecommendation(dataworksheets.rides_trips, dataworksheets.weather_daily);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
