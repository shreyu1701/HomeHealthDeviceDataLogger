using Home_Health_Device_Data_Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Home_Health_Device_Data_Logger.Services
{
    internal class ChartsService
    {
        //BloodPressure
        public void UpdateBloodPressureChart(Chart bloodPressureChart, List<HealthData> healthData)
        {
            var filteredData = healthData.Where(h => !string.IsNullOrEmpty(h.BloodPressure)).ToList();

            // Clear the existing series in the chart
            bloodPressureChart.Series.Clear();

            var series = new Series
            {
                Name = "BloodPressure",
                ChartType = SeriesChartType.Line
            };

            // Add data points to the chart
            foreach (var data in filteredData)
            {
                // Extract systolic and diastolic values
                string[] bloodPressureValues = data.BloodPressure.Split('/');
                double systolic = double.Parse(bloodPressureValues[0]);
                double diastolic = double.Parse(bloodPressureValues[1]);

                // Add systolic blood pressure to the chart (using the date as X-value)
                series.Points.Add(new DataPoint((int)data.DataDate.Ticks, systolic));
            }

            // Add the series to the chart
            bloodPressureChart.Series.Add(series);
        }

        //SugarLevel
        public void UpdateSugarLevelChart(Chart sugarLevelChart, List<HealthData> healthData)
        {
            var filteredData = healthData.Where(h => !string.IsNullOrEmpty(h.SugarLevel)).ToList();

            // Clear the existing series in the chart
            sugarLevelChart.Series.Clear();

            var series = new Series
            {
                Name = "SugarLevel",
                ChartType = SeriesChartType.Line
            };

            // Add data points to the chart
            foreach (var data in filteredData)
            {
                double sugarLevel = double.Parse(data.SugarLevel);

                // Add sugar level data to the chart (using the date as X-value)
                series.Points.Add(new DataPoint((int)data.DataDate.Ticks, sugarLevel));
            }

            // Add the series to the chart
            sugarLevelChart.Series.Add(series);
        }

        //HeartRate
        public void UpdateHeartRateChart(Chart heartRateChart, List<HealthData> healthData)
        {
            // Filter out entries with null or missing heart rate
            var filteredData = healthData.Where(h => h.HeartRate > 0).ToList(); // Ensures we have valid heart rate data

            // Clear the existing series in the chart
            heartRateChart.Series.Clear();

            // Create a new series for heart rate data
            var series = new Series
            {
                Name = "HeartRate",
                ChartType = SeriesChartType.Line
            };

            // Add data points to the chart
            foreach (var data in filteredData)
            {
                // Add heart rate data to the chart (using the date as X-value and heart rate as Y-value)
                series.Points.Add(new DataPoint((int)data.DataDate.Ticks, data.HeartRate));
            }

            // Add the series to the chart
            heartRateChart.Series.Add(series);
        }


        //OxygenLevel
        public void UpdateOxygenLevelChart(Chart oxygenLevelChart, List<HealthData> healthData)
        {
            // Filter out entries with missing or invalid oxygen level (assuming valid oxygen level > 0)
            var filteredData = healthData.Where(h => h.OxygenLevel > 0).ToList();

            // Clear the existing series in the chart
            oxygenLevelChart.Series.Clear();

            // Create a new series for oxygen level data
            var series = new Series
            {
                Name = "OxygenLevel",
                ChartType = SeriesChartType.Line
            };

            // Add data points to the chart
            foreach (var data in filteredData)
            {
                // Add oxygen level data to the chart (using the date as X-value and oxygen level as Y-value)
                series.Points.Add(new DataPoint((int)data.DataDate.Ticks, data.OxygenLevel));
            }

            // Add the series to the chart
            oxygenLevelChart.Series.Add(series);
        }


    }
}
