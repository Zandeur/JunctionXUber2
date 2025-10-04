using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class DataWorksheet
    {
        public Dataworksheets.WorksheetName name;
        public List<RowData> rowDatas;

        public DataWorksheet(Dataworksheets.WorksheetName name, List<RowData> rowDatas)
        {
            this.name = name;
            this.rowDatas = rowDatas;
        }
    }
}
