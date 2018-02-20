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
        double averageCorrelation, averageSignalOne, averageSignalTwo;

        public Interval()
        {
            this.firstPosition = 0;
            this.lastPosition = 0;
            this.intervalLength = 0;
            this.averageCorrelation = 0.0d;
            this.averageSignalOne = 0.0d;
            this.averageSignalTwo = 0.0d;
        }

        public Interval(int firstIndex, int lastIndex)
        {
            this.firstPosition = firstIndex + 1;
            this.lastPosition = lastIndex + 1;
            CalculateIntervalLength();
            this.averageCorrelation = 0.0d;
            this.averageSignalOne = 0.0d;
            this.averageSignalTwo = 0.0d;
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

        // Calculate Average Signal One
        public void CalculateAverageSignalOne(List<Frame> framesList)
        {
            // Find the average signal one from the interval range
            this.averageSignalOne = framesList.GetRange(this.firstPosition, this.intervalLength).Average(x => x.SigOne);
        }

        /*--------------------------------------------------------------------------------------------*/

        public int FirstPosition { get => firstPosition; set => firstPosition = value; }
        public int LastPosition { get => lastPosition; set => lastPosition = value; }
        public int IntervalLength { get => intervalLength; set => intervalLength = value; }
    }

}
