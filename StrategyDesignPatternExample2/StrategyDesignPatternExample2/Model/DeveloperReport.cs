using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPatternExample2.Model
{
    public enum DeveloperLevel
    {
        Senior,
        Junior
    }

    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DeveloperLevel Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }

        public double CalculateTotalSalary() => WorkingHours * HourlyRate;
    }
}
