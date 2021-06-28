using Strategy.Interfaces;
using System.Collections.Generic;

namespace Strategy.Entities
{
    public class StrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
