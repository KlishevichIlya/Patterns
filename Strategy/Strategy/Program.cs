﻿using Strategy.Entities;
using System;

namespace Strategy
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            var context = new Context();
            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new StrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new StrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadKey();
        }
    }
    
}
