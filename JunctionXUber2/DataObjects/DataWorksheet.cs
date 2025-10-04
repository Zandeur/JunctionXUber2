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
        public List<Dictionary<string, string>> data;

        public DataWorksheet(string name, List<Dictionary<string, string>> data)
        {
            this.name = name;
            this.data = data;
        }
    }
}
