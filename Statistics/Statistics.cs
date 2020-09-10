using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        //public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
        //}
        public Stats<T> CalculateStatistics<T>(List<T> numbers)
        {
            Stats<T> ComputedStats = new Stats<T>();
            if (numbers.Count == 0)
            {
                ComputedStats.average = (dynamic)Double.NaN;
                ComputedStats.min = (dynamic)Double.NaN;
                ComputedStats.max = (dynamic)Double.NaN;
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
