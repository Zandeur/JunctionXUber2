using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class ConditionValue
    {
        public enum Type
        {
            weather,
            city,
            distance,
            timeOfDay,
        }

        public Type type;
        public double value;
    }
}
