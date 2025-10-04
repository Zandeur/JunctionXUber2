using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class Recommendation
    {
        public List<ConditionValue> sortedConditionValues;

        public Recommendation(List<ConditionValue> sortedConditionValues)
        {
            this.sortedConditionValues = sortedConditionValues;
        }
    }
}
