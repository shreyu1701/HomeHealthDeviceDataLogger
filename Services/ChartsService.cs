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

        public void UpdateOverallHealthChart(Chart overallHealthChart, List<HealthData> healthData, DateTime fromDate, DateTime toDate)
        {
            // Filter health data by the specified date range for each metric
            var filteredData = healthData
                .Where(h => h.DataDate >= fromDate && h.DataDate <= toDate)
                .OrderBy(h => h.DataDate)
                .ToList();

            // Clear the existing series and reset the chart
            overallHealthChart.Series.Clear();
            overallHealthChart.ChartAreas.Clear();
            overallHealthChart.Legends.Clear();

            // Add a ChartArea
            var chartArea = new ChartArea("ChartArea1")
            {
                AxisX = { Title = "Date", IntervalAutoMode = IntervalAutoMode.VariableCount },
                AxisY = { Title = "Health Metrics" }
            };
            overallHealthChart.ChartAreas.Add(chartArea);

            // Add a Legend
            var legend = new Legend("Legend1")
            {
                Docking = Docking.Top,
                Alignment = System.Drawing.StringAlignment.Center
            };
            overallHealthChart.Legends.Add(legend);

            // Create the series for each health metric (Blood Pressure, Sugar Level, Heart Rate, Oxygen Level)
            var bloodPressureSeries = new Series("Blood Pressure")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Blue,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            var sugarLevelSeries = new Series("Sugar Level")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Green,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Square,
                MarkerSize = 6
            };

            var heartRateSeries = new Series("Heart Rate")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Red,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Diamond,
                MarkerSize = 6
            };

            var oxygenLevelSeries = new Series("Oxygen Level")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Orange,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Triangle,
                MarkerSize = 6
            };

            // Add data points for each series
            foreach (var data in filteredData)
            {
                double xValue = data.DataDate.ToOADate(); // Convert date to OLE Automation Date format for X-axis

                // Add the health metric data to the corresponding series
                if (!string.IsNullOrEmpty(data.BloodPressure))
                {
                    try
                    {
                        string[] bloodPressureValues = data.BloodPressure.Split('/');
                        double systolic = double.Parse(bloodPressureValues[0]);
                        double diastolic = double.Parse(bloodPressureValues[1]);

                        bloodPressureSeries.Points.AddXY(xValue, systolic); // Example: plotting systolic BP
                    }
                    catch (FormatException ex)
                    {
                        // Handle invalid format, log or show message
                        Console.WriteLine($"Error parsing BloodPressure data: {ex.Message}");
                    }
                }

                if (!string.IsNullOrEmpty(data.SugarLevel))
                {
                    try
                    {
                        double sugarLevel = double.Parse(data.SugarLevel);
                        sugarLevelSeries.Points.AddXY(xValue, sugarLevel);
                    }
                    catch (FormatException ex)
                    {
                        // Handle invalid format, log or show message
                        Console.WriteLine($"Error parsing SugarLevel data: {ex.Message}");
                    }
                }

                if (data.HeartRate > 0)
                {
                    heartRateSeries.Points.AddXY(xValue, data.HeartRate);
                }
                else
                {
                    Console.WriteLine($"Invalid HeartRate data for Date: {data.DataDate}");
                }

                if (data.OxygenLevel > 0)
                {
                    oxygenLevelSeries.Points.AddXY(xValue, data.OxygenLevel);
                }
                else
                {
                    Console.WriteLine($"Invalid OxygenLevel data for Date: {data.DataDate}");
                }
            }

            // Add the series to the chart
            overallHealthChart.Series.Add(bloodPressureSeries);
            overallHealthChart.Series.Add(sugarLevelSeries);
            overallHealthChart.Series.Add(heartRateSeries);
            overallHealthChart.Series.Add(oxygenLevelSeries);
        }


        public void UpdateBloodPressureChart(Chart bloodPressureChart, List<HealthData> healthData, DateTime fromDate, DateTime toDate)
        {
            // Filter health data by the specified date range
            var filteredData = healthData
                .Where(h => !string.IsNullOrEmpty(h.BloodPressure) && h.DataDate >= fromDate && h.DataDate <= toDate)
                .ToList();

            // Clear the existing series and reset chart
            bloodPressureChart.Series.Clear();
            bloodPressureChart.ChartAreas.Clear();
            bloodPressureChart.Legends.Clear();

            // Add a ChartArea
            var chartArea = new ChartArea("BloodPressureArea")
            {
                AxisX = { Title = "Date", IntervalAutoMode = IntervalAutoMode.VariableCount },
                AxisY = { Title = "Blood Pressure (mmHg)" }
            };
            bloodPressureChart.ChartAreas.Add(chartArea);

            // Add a Legend
            var legend = new Legend("Default")
            {
                Docking = Docking.Top,
                Alignment = System.Drawing.StringAlignment.Center
            };
            bloodPressureChart.Legends.Add(legend);

            // Create series for Systolic and Diastolic
            var systolicSeries = new Series
            {
                Name = "Systolic",
                ChartType = SeriesChartType.StackedBar,
                Color = System.Drawing.Color.Blue,
                Legend = "Default" // Match the legend name
            };

            var diastolicSeries = new Series
            {
                Name = "Diastolic",
                ChartType = SeriesChartType.StackedBar,
                Color = System.Drawing.Color.Red,
                Legend = "Default" // Match the legend name
            };

            // Add data points
            foreach (var data in filteredData)
            {
                string[] bloodPressureValues = data.BloodPressure.Split('/');
                double systolic = double.Parse(bloodPressureValues[0]);
                double diastolic = double.Parse(bloodPressureValues[1]);

                // Use the data date as the X-axis value
                double xValue = data.DataDate.ToOADate();

                systolicSeries.Points.AddXY(xValue, systolic);
                diastolicSeries.Points.AddXY(xValue, diastolic);
            }

            // Add the series to the chart
            bloodPressureChart.Series.Add(systolicSeries);
            bloodPressureChart.Series.Add(diastolicSeries);

            // Format X-axis as date
            bloodPressureChart.ChartAreas["BloodPressureArea"].AxisX.LabelStyle.Format = "MMM dd";
            bloodPressureChart.ChartAreas["BloodPressureArea"].AxisX.IntervalType = DateTimeIntervalType.Days;
        }

        // Sugar Level
        public void UpdateSugarLevelChart(Chart sugarLevelChart, List<HealthData> healthData, DateTime fromDate, DateTime toDate)
        {
            // Filter data by date range and ensure SugarLevel is not null or empty
            var filteredData = healthData
                .Where(h => h.DataDate >= fromDate && h.DataDate <= toDate && !string.IsNullOrEmpty(h.SugarLevel))
                .OrderBy(h => h.DataDate) // Ensure the data is sorted by date for correct visualization
                .ToList();

            // Clear the existing series in the chart
            sugarLevelChart.Series.Clear();
            sugarLevelChart.Titles.Clear();

            // Add chart title
            sugarLevelChart.Titles.Add("Sugar Level Trends");

            // Configure the series
            var series = new Series
            {
                Name = "SugarLevel",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.Blue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8
            };

            // Add data points to the series
            foreach (var data in filteredData)
            {
                double sugarLevel = double.Parse(data.SugarLevel);

                // Add sugar level data to the chart (using the date as X-value)
                series.Points.AddXY(data.DataDate.ToShortDateString(), sugarLevel);
            }

            // Customize chart area
            sugarLevelChart.ChartAreas.Clear();
            var chartArea = new ChartArea
            {
                Name = "SugarLevelChartArea"
            };

            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Sugar Level (mg/dL)";
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotate X-axis labels for better readability
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            sugarLevelChart.ChartAreas.Add(chartArea);

            // Add the series to the chart
            sugarLevelChart.Series.Add(series);
        }


        // Heart Rate
        public void UpdateHeartRateChart(Chart heartRateChart, List<HealthData> healthData, DateTime fromDate, DateTime toDate)
        {
            // Filter data by date range and ensure heart rate is valid
            var filteredData = healthData
                .Where(h => h.HeartRate > 0 && h.DataDate >= fromDate && h.DataDate <= toDate)
                .OrderBy(h => h.DataDate) // Ensure the data is sorted by date for correct visualization
                .ToList();

            // Clear the existing series in the chart
            heartRateChart.Series.Clear();
            heartRateChart.Titles.Clear();

            // Add chart title
            heartRateChart.Titles.Add("Heart Rate Trends");

            // Create a new series for heart rate data
            var series = new Series
            {
                Name = "HeartRate",
                ChartType = SeriesChartType.Line, // Change to line chart for better trend visualization
                BorderWidth = 2,
                Color = System.Drawing.Color.Red,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6
            };

            // Add data points to the series
            foreach (var data in filteredData)
            {
                // Add heart rate data to the chart (using the date as X-value and heart rate as Y-value)
                series.Points.AddXY(data.DataDate.ToShortDateString(), data.HeartRate);
            }

            // Customize chart area
            heartRateChart.ChartAreas.Clear();
            var chartArea = new ChartArea
            {
                Name = "HeartRateChartArea"
            };

            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Heart Rate (bpm)";
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotate X-axis labels for better readability
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            heartRateChart.ChartAreas.Add(chartArea);

            // Add the series to the chart
            heartRateChart.Series.Add(series);
        }


        // Oxygen Level
        public void UpdateOxygenLevelChart(Chart oxygenLevelChart, List<HealthData> healthData, DateTime fromDate, DateTime toDate)
        {
            // Filter data by date range and ensure oxygen level is valid
            var filteredData = healthData
                .Where(h => h.OxygenLevel > 0 && h.DataDate >= fromDate && h.DataDate <= toDate)
                .OrderBy(h => h.DataDate) // Ensure the data is sorted by date for correct visualization
                .ToList();

            // Clear the existing series in the chart
            oxygenLevelChart.Series.Clear();
            oxygenLevelChart.Titles.Clear();

            // Add chart title
            oxygenLevelChart.Titles.Add("Oxygen Level Trends");

            // Create a new series for oxygen level data
            var series = new Series
            {
                Name = "OxygenLevel",
                ChartType = SeriesChartType.Line, // Change to line chart for better trend visualization
                BorderWidth = 2,
                Color = System.Drawing.Color.Green,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6
            };

            // Add data points to the series
            foreach (var data in filteredData)
            {
                // Add oxygen level data to the chart (using the date as X-value and oxygen level as Y-value)
                series.Points.AddXY(data.DataDate.ToShortDateString(), data.OxygenLevel);
            }

            // Customize chart area
            oxygenLevelChart.ChartAreas.Clear();
            var chartArea = new ChartArea
            {
                Name = "OxygenLevelChartArea"
            };

            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Oxygen Level (%)";
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotate X-axis labels for better readability
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;

            oxygenLevelChart.ChartAreas.Add(chartArea);

            // Add the series to the chart
            oxygenLevelChart.Series.Add(series);
        }




    }
}
