using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyDesignPatternExample2.Model;

namespace StrategyDesignPatternExample2.Strategy
{
    class SeniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Senior)
                .Select(r => r.CalculateTotalSalary() * 1.2)
                .Sum();
    }
}
