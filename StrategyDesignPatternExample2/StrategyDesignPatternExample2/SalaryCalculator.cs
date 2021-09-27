using StrategyDesignPatternExample2.Model;
using StrategyDesignPatternExample2.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPatternExample2
{
    class SalaryCalculator
    {
        private ISalaryCalculator _calculator;

        public SalaryCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        public double Calculate(IEnumerable<DeveloperReport> reports)
        {
            return _calculator.CalculateTotalSalary(reports);
        }
    }
}
