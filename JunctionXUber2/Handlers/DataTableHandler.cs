using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class DataTableHandler
    {
        public static List<Dictionary<string, string>> ConvertDataTableToDictionary(DataTable dt)
        {
            List<Dictionary<string, string>> dictionary = new List<Dictionary<string, string>>();

            List<string> headers = new List<string>();
            foreach (DataColumn dataColumn in dt.Columns)
            {
                headers.Add(dataColumn.ColumnName);
            }

            foreach (DataRow dataRow in dt.Rows)
            {
                Dictionary<string, string> rowData = new Dictionary<string, string>();

                for (int i = 0; i < headers.Count; i++)
                {
                    object value = dataRow[headers[i]];
                    rowData.Add(headers[i], value == null ? string.Empty : (string)value);
                }

                dictionary.Add(rowData);
            }

            return dictionary;
        }
    }
}
