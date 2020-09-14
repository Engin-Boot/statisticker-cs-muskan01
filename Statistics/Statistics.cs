using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<Double> numbers)
        {
            Stats ComputedStats = new Stats();
            if (numbers.Count == 0)
            {
                ComputedStats.average = Double.NaN;
                ComputedStats.min = Double.NaN;
                ComputedStats.max = Double.NaN;
            }

            else
            {
                ComputedStats.average = ComputedStats.CalculateAverage(numbers);
                ComputedStats.min = ComputedStats.CalculateMin(numbers);
                ComputedStats.max = ComputedStats.CalculateMax(numbers);
            }
            
        return ComputedStats;
        }
    }
}
