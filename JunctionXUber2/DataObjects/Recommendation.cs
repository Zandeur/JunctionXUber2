using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.DataObjects
{
    internal class Recommendation
    {
        public double cancellationChance;
        public double euroPerHour;
        public double expectedWaitingTime;

        public ConditionValue conditionValue;
    }
}
