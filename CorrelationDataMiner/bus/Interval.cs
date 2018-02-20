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
        double averageCorrelation;

        public Interval()
        {
            this.firstPosition = 0;
            this.lastPosition = 0;
            this.intervalLength = 0;
            this.averageCorrelation = 0.0d;
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

        // Calculate Average Correlation
        public void CalculateAverageCorrelation(List<Frame> framesList)
        {
            // Find the average correlation from the interval range
            this.averageCorrelation = framesList.GetRange(this.firstPosition, this.intervalLength).Average(x => x.CorrSignal);
        }

        /*--------------------------------------------------------------------------------------------*/

        public int FirstPosition { get => firstPosition; set => firstPosition = value; }
        public int LastPosition { get => lastPosition; set => lastPosition = value; }
        public int IntervalLength { get => intervalLength; set => intervalLength = value; }
    }

}
