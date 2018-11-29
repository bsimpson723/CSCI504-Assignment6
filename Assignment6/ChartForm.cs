using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace Assignment6
{
    public partial class ChartForm : Form
    {
        private Form m_mainForm;
        public ChartForm(string chartName, Form mainForm)
        {
            InitializeComponent();
            LoadChart(chartName);
            m_mainForm = mainForm;
        }

        private void LoadChart(string chartName)
        {
            switch (chartName)
            {
                case "Batting_Button":
                    CreateHittingStatsLineGraph();
                    break;
                case "Attendance_Button":
                    CreateAttendanceBarGraph();
                    break;
                case "SocialMedia_Button":
                    CreateSocialMediaPieChart();
                    break;
                case "Icecream_Button":
                    CreateIceCreamScatterPlot();
                    break;
                default:
                    return;
            }

        }

        private void CreateAttendanceBarGraph()
        {
            Text = "Attendance Rates";
            ChartTite_Label.Text = "MLB Attendance Rate: Current Vs. Previous Season by Team";
            var attendanceRates = LoadAttendanceRates();
            ChartControl.Series.RemoveAt(0);
            var teamNames = new List<string>();
            var currentAttendance = new List<int>();
            var previousAttendance = new List<int>();
            foreach (var rate in attendanceRates)
            {
                teamNames.Add(rate.TeamName);
                currentAttendance.Add(rate.CurrentAttendance);
                previousAttendance.Add(rate.PreviousAttendance);
            }

            var currentYear = new Series("2018");
            currentYear.Points.DataBindXY(teamNames, currentAttendance);
            var previousYear = new Series("2017");
            previousYear.Points.DataBindXY(teamNames, previousAttendance);
            ChartControl.Series.Add(previousYear);
            ChartControl.Series.Add(currentYear);
            ChartControl.ChartAreas[0].AxisX.Interval = 1;
            ChartControl.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

            ChartControl.ChartAreas[0].AxisX.Title = "Team Name";
            ChartControl.ChartAreas[0].AxisY.Title = "Attendance";
        }

        private void CreateHittingStatsLineGraph()
        {
            Text = "Hitting Statistics";
            var hittingStats = LoadHittingStats();
            ChartTite_Label.Text = "MLB Hitting Statistics: 1990 - Present";

            var battingAverage = new Series("Batting Average");
            battingAverage.ChartType = SeriesChartType.Line;
            battingAverage.BorderWidth = 2;
            battingAverage.MarkerStyle = MarkerStyle.Circle;

            var onBasePercentage = new Series("On Base %");
            onBasePercentage.ChartType = SeriesChartType.Line;
            onBasePercentage.BorderWidth = 2;
            onBasePercentage.MarkerStyle = MarkerStyle.Circle;

            var sluggingPercentage = new Series("Slug %");
            sluggingPercentage.ChartType = SeriesChartType.Line;
            sluggingPercentage.BorderWidth = 2;
            sluggingPercentage.MarkerStyle = MarkerStyle.Circle;

            var onBasePlusSlug = new Series("OPS");
            onBasePlusSlug.ChartType = SeriesChartType.Line;
            onBasePlusSlug.BorderWidth = 2;
            onBasePlusSlug.MarkerStyle = MarkerStyle.Circle;

            var years = new List<int>();
            var average = new List<float>();
            var obp = new List<float>();
            var slugging = new List<float>();
            var ops = new List<float>();
            foreach (var stat in hittingStats)
            {
                years.Add(stat.Year);
                average.Add(stat.BattingAverage);
                obp.Add(stat.OnBasePercentage);
                slugging.Add(stat.SluggingPercentage);
                ops.Add(stat.OnBasePlusSlugging);
            }
            battingAverage.Points.DataBindXY(years, average);
            onBasePercentage.Points.DataBindXY(years, obp);
            sluggingPercentage.Points.DataBindXY(years, slugging);
            onBasePlusSlug.Points.DataBindXY(years, ops);
            ChartControl.Series.RemoveAt(0);
            ChartControl.Series.Add(battingAverage);
            ChartControl.Series.Add(onBasePlusSlug);
            ChartControl.Series.Add(onBasePercentage);
            ChartControl.Series.Add(sluggingPercentage);
            ChartControl.ChartAreas[0].AxisX.Title = "Year";
            ChartControl.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            ChartControl.ChartAreas[0].AxisY.Title = "Percentage";
            ChartControl.ChartAreas[0].AxisX.Interval = 1;
            ChartControl.ChartAreas[0].AxisY.Interval = .050;
        }

        private void CreateSocialMediaPieChart()
        {
            Text = "Social Media Market Share";
            var socialMediaStats = LoadSocialMediaStats();
            ChartTite_Label.Text = "Social Media Market Share (July 2018)";

            var marketShare = new Series("Market Share");
            marketShare.ChartType = SeriesChartType.Pie;
            marketShare["PieLabelStyle"] = "Disabled";
            foreach (var stat in socialMediaStats)
            {
                marketShare.Points.AddXY(stat.Name, stat.MarketShare);
            }
            
            ChartControl.Series.RemoveAt(0);
            ChartControl.Series.Add(marketShare);
        }

        private void CreateIceCreamScatterPlot()
        {
            Text = "Icecream Sales";
            var iceCreamSales = LoadIceCreamSales();
            ChartTite_Label.Text = "Icecream sales related to temperature (C)";

            var iceCreamSeries = new Series("Icecream Sales");
            iceCreamSeries.ChartType = SeriesChartType.Point;

            foreach (var stat in iceCreamSales)
            {
                iceCreamSeries.Points.AddXY(stat.Temp, stat.Sales);
            }

            ChartControl.ChartAreas[0].AxisX.Title = "Temperature (C)";
            ChartControl.ChartAreas[0].AxisY.Title = "Icecream Sales ($)";
            ChartControl.Series.RemoveAt(0);
            ChartControl.Series.Add(iceCreamSeries);
        }

        private List<IceCreamSales> LoadIceCreamSales()
        {
            var fileName = "TempAndIcecream.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Unable to load " + fileName);
                return null;
            }
            var lines = File.ReadAllLines(fileName);
            var statObjects = new List<IceCreamSales>();
            foreach (var line in lines)
            {
                var statFields = line.Split('\t');
                var iceCreamSales = new IceCreamSales();
                iceCreamSales.Temp = float.Parse(statFields[0]);
                iceCreamSales.Sales = Convert.ToInt32(statFields[1]);
                statObjects.Add(iceCreamSales);
            }

            return statObjects;
        }

        private List<SocialMediaStat> LoadSocialMediaStats()
        {
            var fileName = "SocialMedia.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Unable to load " + fileName);
                return null;
            }
            var lines = File.ReadAllLines(fileName);
            var statObjects = new List<SocialMediaStat>();
            foreach (var line in lines)
            {
                var statFields = line.Split('\t');
                var socialMediaStat = new SocialMediaStat();
                socialMediaStat.Name = statFields[0];
                socialMediaStat.MarketShare = decimal.Parse(statFields[1]);
                statObjects.Add(socialMediaStat);
            }

            return statObjects;
        }

        private List<HittingStats> LoadHittingStats()
        {
            var fileName = "HittingStats.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Unable to load " + fileName);
                return null;
            }
            var lines = File.ReadAllLines(fileName);
            var statObjects = new List<HittingStats>();
            foreach (var line in lines)
            {
                var statFields = line.Split('\t');
                var hittingStats = new HittingStats();
                hittingStats.Year = Convert.ToInt32(statFields[0]);
                hittingStats.BattingAverage = float.Parse(statFields[1]);
                hittingStats.OnBasePercentage = float.Parse(statFields[2]);
                hittingStats.SluggingPercentage = float.Parse(statFields[3]);
                hittingStats.OnBasePlusSlugging = float.Parse(statFields[4]);
                statObjects.Add(hittingStats);
            }

            return statObjects;
        }

        private List<AttendanceRate> LoadAttendanceRates()
        {
            var fileName = "AttendanceRate.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Unable to load " + fileName);
                return null;
            }
            var lines = File.ReadAllLines(fileName);
            var attendanceObjects = new List<AttendanceRate>();
            foreach (var line in lines)
            {
                var attendanceFields = line.Split('\t');
                var attendanceRate = new AttendanceRate();
                attendanceRate.TeamName = attendanceFields[0];
                attendanceRate.CurrentAttendance = Convert.ToInt32(attendanceFields[1]);
                attendanceRate.PreviousAttendance = Convert.ToInt32(attendanceFields[2]);
                attendanceObjects.Add(attendanceRate);
            }

            return attendanceObjects;
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            Close();
        }

        private void ChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_mainForm.Show();
        }
    }
}
