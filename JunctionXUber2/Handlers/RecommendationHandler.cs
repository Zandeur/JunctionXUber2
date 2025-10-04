using JunctionXUber2.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunctionXUber2.Handlers
{
    internal class RecommendationHandler
    {

        public Recommendation recommendation;
        public List<ConditionValue> conditions;

        public RecommendationHandler(Recommendation recommendation)
        {
            this.recommendation = recommendation;
            this.conditions = new List<ConditionValue>();
        }

        public void SortRecommendations()
        {
            conditions = recommendation.sortedConditionValues.OrderByDescending(c => c.euroPerHour).Take(3).ToList();
        }

    }
}
