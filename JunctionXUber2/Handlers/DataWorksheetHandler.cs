using JunctionXUber2.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class DataWorksheetHandler
    {
        private Dataworksheets allDataWorksheets;

        public DataWorksheetHandler()
        {
            ExcelReader excelReader = new ExcelReader();
            allDataWorksheets = excelReader.GetWorksheets();
        }

        public Dataworksheets GetDataWorksheets(string userId)
        {
            List<DataWorksheet> filteredWorksheets = new List<DataWorksheet>();

            foreach (var dataWorksheet in allDataWorksheets.dataworksheets)
            {
                filteredWorksheets.Add(new DataWorksheet(dataWorksheet.name, dataWorksheet.rowDatas.Where(rowData =>
                {
                    if (rowData.data.ContainsKey("driver_id"))
                    {
                        return rowData.data["driver_id"].Equals(userId);
                    }
                    return true;
                }).ToList()));
            };

            return new Dataworksheets(filteredWorksheets);
        }
    }
}
