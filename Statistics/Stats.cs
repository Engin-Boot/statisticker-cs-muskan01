using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Stats
    {   public Double average;
        public Double min;
        public Double max;

        public Double CalculateAverage(List<Double> numbers)
        {
            
            Double sum = numbers[0];
            int n = numbers.Count;
            for (int i=1; i < n ; i++)
            {
                sum += numbers[i];
            }

          return sum/n;
            
        }

        public Double CalculateMin(List<Double> numbers)
        {
           
            Double minimum = numbers[0];
            int n = numbers.Count;
            for (int i = 0; i < n; i++)
            {
                Double a = numbers[i];
                if ( a < minimum)
                {
                    minimum = a;
                }
            }
            return minimum;
        }

        public Double CalculateMax(List<Double> numbers)
        {
            Double maximum = numbers[0];
            int n = numbers.Count;
            for (int i = 0; i < n; i++)
            {
                dynamic a = numbers[i];
                if (a > maximum)
                {
                    maximum = a;
                }
            }
            return maximum;     
       }
    }
}
