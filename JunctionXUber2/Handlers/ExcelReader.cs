using JunctionXUber2.DataObjects;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JunctionXUber2.Handlers
{
    internal class ExcelReader
    {
        private readonly string filePath = $"{Application.StartupPath}\\Resources\\uber_hackathon_v2_mock_data.xlsx";

        public Dataworksheets GetWorksheets(string userId)
        {
            Dataworksheets dataWorksheet = new Dataworksheets();

            dataWorksheet.rides_trips = GetDataworskheet("rides_trips", userId);
            dataWorksheet.earnings_daily = GetDataworskheet("earnings_daily", userId);
            dataWorksheet.surge_by_hour = GetDataworskheet("surge_by_hour", userId);
            dataWorksheet.cancellation_rate = GetDataworskheet("cancellation_rates", userId);
            dataWorksheet.heatmap = GetDataworskheet("heatmap", userId);
            dataWorksheet.weather_daily = GetDataworskheet("weather_daily", userId);

            return dataWorksheet;
        }

        private DataWorksheet GetDataworskheet(string worksheetName, string userId)
        {
            DataTable dt = LoadExcelToDataTable(filePath, worksheetName);
            List<Dictionary<string, string>> data = DataTableHandler.ConvertDataTableToDictionary(dt);
            data = data.Where(row =>
            {
                if (row.ContainsKey("user_id"))
                {
                    return row["driver_id"].Equals(userId);
                }
                return true;
            }).ToList();

            List<RowData> rowDatas = data.Select(row => new RowData(row)).ToList();
            return new DataWorksheet(worksheetName, rowDatas);
        }

        private DataTable LoadExcelToDataTable(string filePath, string sheetName)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetName];

                DataTable dataTable = new DataTable();

                // Add columns
                foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dataTable.Columns.Add(cell.Text);
                }

                // Add rows
                for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    ExcelRange cellRnage = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    DataRow row = dataTable.NewRow();
                    foreach (var cell in cellRnage)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }
        }
    }
}
