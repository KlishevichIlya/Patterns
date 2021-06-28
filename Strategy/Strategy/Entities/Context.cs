using System;
using System.Collections.Generic;
using Strategy.Interfaces;

namespace Strategy.Entities
{
    public class Context
    {
        //Link to one Strategy object. Context desn't know about about specific Strategy object.
        private IStrategy _strategy;

        public Context()
        {

        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }       

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            string resultStr = string.Empty;
            foreach(var elem in result as List<string>)
            {
                resultStr += elem + ",";
            }
            Console.WriteLine(resultStr);
        }
    }
}
