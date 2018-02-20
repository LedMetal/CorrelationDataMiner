using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrelationDataMiner.bus
{
    public class Interval
    {
        int firstPosition, lastPosition, intervalLength;

        public Interval()
        {
            this.firstPosition = 0;
            this.lastPosition = 0;
            this.intervalLength = 0;
        }

        public Interval(int firstIndex, int lastIndex)
        {
            this.firstPosition = firstIndex + 1;
            this.lastPosition = lastIndex + 1;
            CalculateIntervalLength();
        }

        // Calculates the length of the interval
        public void CalculateIntervalLength()
        {
            this.intervalLength = (this.lastPosition + 1) - this.firstPosition;
        }

        /*--------------------------------------------------------------------------------------------*/

        public int FirstPosition { get => firstPosition; set => firstPosition = value; }
        public int LastPosition { get => lastPosition; set => lastPosition = value; }
        public int IntervalLength { get => intervalLength; set => intervalLength = value; }
    }

}
