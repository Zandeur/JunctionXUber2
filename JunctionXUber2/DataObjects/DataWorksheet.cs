using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class DataWorksheet
    {
        public string name;
        public List<RowData> rowDatas;

        public DataWorksheet(string name, List<RowData> rowDatas)
        {
            this.name = name;
            this.rowDatas = rowDatas;
        }
    }
}
