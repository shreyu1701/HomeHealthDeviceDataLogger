using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger.Data
{
    public class DataValidation
    {
        // Validates range for numeric health metrics
        public static bool ValidateMetricRange(string metricName, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                MessageBox.Show($"{metricName} must be between {min} and {max}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Validates that required fields are not empty
        public static bool ValidateRequiredField(string metricName, string value, bool isMetricEnabled)
        {
            if (isMetricEnabled && string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"{metricName} is required and cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Validates and parses numeric input
        public static bool TryParseMetric(string metricName, string input, out int result, bool isMetricEnabled)
        {
            result = 0;
            if (isMetricEnabled && !int.TryParse(input, out result))
            {
                MessageBox.Show($"Invalid {metricName}. Please enter a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
