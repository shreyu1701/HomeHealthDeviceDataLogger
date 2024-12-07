using Forge.OpenAI.Models.Files;
using Forge.OpenAI.Models.Messages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Services
{
    internal class ReportGenerationService
    {
        internal static void ExportToCsv(DataTable data, string fileName)
        {
            StringBuilder csv = new StringBuilder();

            // Add headers
            string[] columnNames = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            csv.AppendLine(string.Join(",", columnNames));

            // Add rows
            foreach (DataRow row in data.Rows)
            {
                string[] fields = row.ItemArray.Select(field =>
                    "\"" + field.ToString().Replace("\"", "\"\"") + "\"").ToArray();
                csv.AppendLine(string.Join(",", fields));
            }

            // Write to file
            File.WriteAllText(fileName, csv.ToString());
        }

    }
}
