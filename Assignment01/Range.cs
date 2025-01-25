using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class Range<T> where T : struct, IComparable<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T min, T max)
        {
            // Ensure Min is always less than or equal to Max
            if (min.CompareTo(max) > 0)
            {
                Min = max;
                Max = min;
            }
            else
            {
                Min = min;
                Max = max;
            }
        }

        // Method to check if a value is within the range
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        // Method to calculate the length of the range
        public double Length()
        {
            // Convert Min and Max to double for calculation
            double minValue = Convert.ToDouble(Min);
            double maxValue = Convert.ToDouble(Max);
            return maxValue - minValue;
        }
    }
}
