using StrategyDesignPatternExample2.Model;
using StrategyDesignPatternExample2.Strategy;
using System;
using System.Collections.Generic;

namespace StrategyDesignPatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var reports = new List<DeveloperReport>
            {
                new DeveloperReport {Id = 1, Name = "Dev1", Level = DeveloperLevel.Junior, HourlyRate = 22.5, WorkingHours = 120},
                new DeveloperReport {Id = 1, Name = "Dev2", Level = DeveloperLevel.Senior, HourlyRate = 32.5, WorkingHours = 160},
                new DeveloperReport {Id = 1, Name = "Dev3", Level = DeveloperLevel.Senior, HourlyRate = 40.5, WorkingHours = 180},
                new DeveloperReport {Id = 1, Name = "Dev4", Level = DeveloperLevel.Junior, HourlyRate = 25.5, WorkingHours = 140}
            };

            var calculatorContext = new SalaryCalculator(new JuniorDevSalaryCalculator());
            var juniorTotal = calculatorContext.Calculate(reports);

            calculatorContext.SetCalculator(new SeniorDevSalaryCalculator());

            var seniorTotal = calculatorContext.Calculate(reports);


            Console.WriteLine($"Total amount for junior salaries is: {juniorTotal}");
            Console.WriteLine($"Total amout for senior salaries is {seniorTotal} ");
            Console.WriteLine($"Total cost for all the salaries is: {juniorTotal + seniorTotal}");
        }
    }
}
