using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    class Stats<T>
    {

        public T average;
        public T min;
        public T max;

       private T Add(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }

        private T Divide(T a, int b)
        {
            dynamic a1 = a;
           
            return a1 / b;
        }

        public T CalculateAverage(List<T> numbers)
        {
            dynamic sum = numbers[0];
            int n = numbers.Count;
            for (int i=1; i < n ; i++)
            {
                sum = Add(sum,numbers[i]);
            }
          return Divide(sum,n);
         }

        public T CalculateMin(List<T> numbers)
        {
            dynamic minimum = numbers[0];
            int n = numbers.Count;
            for (int i = 0; i < n; i++)
            {
                dynamic a = numbers[i];
                if ( a < minimum)
                {
                    minimum = a;
                }
            }
            return minimum;
        }

        public T CalculateMax(List<T> numbers)
        {
            dynamic maximum = numbers[0];
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
