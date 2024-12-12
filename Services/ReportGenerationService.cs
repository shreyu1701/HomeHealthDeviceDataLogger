using Forge.OpenAI.Models.Files;
using Forge.OpenAI.Models.Messages;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Services
{
    internal class ReportGenerationService
    {
        // Export report based on selected format (PDF or Excel)
        internal static void ExportReport(DataTable data, bool isPdfReport, string patientName, string userId)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (isPdfReport)
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
            }
            else
            {
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.AddExtension = true;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    if (isPdfReport)
                    {
                        ExportToPdf(data, fileName, patientName, userId); 
                    }
                    else
                    {
                        ExportToExcel(data, fileName, patientName, userId);
                    }

                    MessageBox.Show("Report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Export to Excel
        private static void ExportToExcel(DataTable data, string fileName, string patientName, string userId)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Health Data");

                worksheet.Cells[1, 1].Value = "User ID:";
                worksheet.Cells[1, 2].Value = userId;
                worksheet.Cells[2, 1].Value = "Patient Name:";
                worksheet.Cells[2, 2].Value = patientName;
               

                worksheet.Cells[3, 1].Value = "";

                int colIndex = 1;
                foreach (DataColumn column in data.Columns)
                {
                    if (column.ColumnName != "DataID")
                    {
                        worksheet.Cells[4, colIndex++].Value = column.ColumnName;
                    }
                }

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    colIndex = 1;
                    foreach (DataColumn column in data.Columns)
                    {
                        if (column.ColumnName != "DataID") 
                        {
                            var value = data.Rows[i][column.ColumnName];

                            if (value is DateTime dateValue)
                            {
                                worksheet.Cells[i + 5, colIndex].Value = dateValue.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                worksheet.Cells[i + 5, colIndex].Value = value?.ToString() ?? string.Empty;
                            }

                            colIndex++;
                        }
                    }
                }

                FileInfo fileInfo = new FileInfo(fileName);
                package.SaveAs(fileInfo);
            }
        }

        // Export to PDF
        private static void ExportToPdf(DataTable data, string fileName, string patientName, string userId)
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            FileStream fs = new FileStream(fileName, FileMode.Create);
            PdfWriter.GetInstance(doc, fs);

            doc.Open();

            // Add Patient Info to PDF
            doc.Add(new Paragraph($"User ID: {userId}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
            doc.Add(new Paragraph($"Patient Name: {patientName}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
            doc.Add(new Paragraph($"Report Date: {DateTime.Now.ToString("yyyy-MM-dd")}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
            doc.Add(new Paragraph("")); // Add space between patient info and table

            // Create the table with 2 columns: one for the field name, one for the value
            PdfPTable table = new PdfPTable(2);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2f, 4f }); // Adjust column widths to fit the names and values

            // Define the specific fields to include in the report
            var fields = new Dictionary<string, string>
    {
        { "DataDate", string.Empty },
        { "BloodPressure", string.Empty },
        { "SugarLevel", string.Empty },
        { "HeartRate", string.Empty },
        { "OxygenLevel", string.Empty }
    };

            // Add headers for the table
            table.AddCell(new PdfPCell(new Phrase("Field", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Value", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) { HorizontalAlignment = Element.ALIGN_CENTER });

            // Loop through all rows in the DataTable to add data
            foreach (DataRow row in data.Rows)
            {
                // For each row, add the field name and corresponding value
                foreach (var field in fields)
                {
                    table.AddCell(new PdfPCell(new Phrase(field.Key, FontFactory.GetFont(FontFactory.HELVETICA, 10))) { HorizontalAlignment = Element.ALIGN_LEFT });

                    // Retrieve the corresponding value from the DataRow
                    string fieldValue = string.Empty;
                    if (row[field.Key] != DBNull.Value)
                    {
                        fieldValue = row[field.Key].ToString();
                    }

                    table.AddCell(new PdfPCell(new Phrase(fieldValue, FontFactory.GetFont(FontFactory.HELVETICA, 10))) { HorizontalAlignment = Element.ALIGN_LEFT });
                }
            }

            // Add the table to the document
            doc.Add(table);

            doc.Close(); // Close the document
            fs.Close(); // Close the file stream
        }



    }
}
