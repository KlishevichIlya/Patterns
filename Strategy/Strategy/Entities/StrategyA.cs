using Strategy.Interfaces;
using System.Collections.Generic;

namespace Strategy.Entities
{
    public class StrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
