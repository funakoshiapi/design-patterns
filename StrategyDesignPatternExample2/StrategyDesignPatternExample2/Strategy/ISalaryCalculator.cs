using StrategyDesignPatternExample2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPatternExample2.Strategy
{
    public interface ISalaryCalculator
    {
        double CalculateTotalSalary(IEnumerable<DeveloperReport> reports);
    }
}
