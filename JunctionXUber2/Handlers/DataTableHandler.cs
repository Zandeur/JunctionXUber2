using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

        public static DataTable ConvertEnumerable<T>(IEnumerable<T> data)
        {
            Type itemType = GetItemType(data);

            DataTable dt = new DataTable();
            PropertyInfo[] propInfo = itemType.GetProperties();

            foreach (PropertyInfo prop in propInfo)
            {
                Type propertyType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                dt.Columns.Add(prop.Name, propertyType);
            }

            if (data == null) return dt;

            foreach (object item in data)
            {
                object[] values = propInfo.Select(p => p.GetValue(item)).ToArray();
                dt.Rows.Add(values);
            }

            return dt;
        }

        private static Type GetItemType<T>(T data)
        {
            Type itemType = null;

            if (typeof(T).IsGenericType)
            {
                itemType = typeof(T).GetGenericArguments()[0];
            }
            else
            {
                Type enumerableType = data.GetType().GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>));

                if (enumerableType != null)
                {
                    itemType = enumerableType.GetGenericArguments()[0];
                }
            }

            if (itemType == null) throw new InvalidOperationException("DataType cannot be determined");
            return itemType;
        }
    }
}
