using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyDesignPatternExample2.Model;

namespace StrategyDesignPatternExample2.Strategy
{
    class JuniorDevSalaryCalculator : ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports) =>
            reports
                .Where(r => r.Level == DeveloperLevel.Junior)
                .Select(r => r.CalculateTotalSalary())
                .Sum();
    }
}
