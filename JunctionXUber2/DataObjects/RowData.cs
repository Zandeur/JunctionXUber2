using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class RowData
    {
        public Dictionary<string, string> data;

        public RowData(Dictionary<string, string> data)
        {
            this.data = data;
        }
    }
}
