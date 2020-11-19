using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemporaryField.Better
{
    internal class DurationStatistics
    {
        private readonly IReadOnlyCollection<TimeSpan> durations;
        private readonly Lazy<TimeSpan> average;
        private readonly Lazy<TimeSpan> standardDeviation;

        public DurationStatistics(IReadOnlyCollection<TimeSpan> durations)
        {
            if (durations == null)
                throw new ArgumentNullException(nameof(durations));
            if (durations.Count == 0)
                throw new ArgumentException(
                    "Empty collection not allowed.",
                    nameof(durations));

            this.durations = durations;
            this.average = new Lazy<TimeSpan>(this.CalculateAverage);
            this.standardDeviation =
                new Lazy<TimeSpan>(this.CalculateStandardDeviation);
        }

        public TimeSpan Average
        {
            get { return this.average.Value; }
        }

        public TimeSpan StandardDeviation
        {
            get { return this.standardDeviation.Value; }
        }

        private TimeSpan CalculateAverage()
        {
            return TimeSpan.FromTicks(
                (long)this.durations.Average(ts => ts.Ticks));
        }
        private TimeSpan CalculateStandardDeviation()
        {
            var variance =
                this.durations.Average(ts =>
                    Math.Pow(
                        (ts - this.average.Value).Ticks,
                        2));
            return TimeSpan.FromTicks((long)Math.Sqrt(variance));
        }
    }
}
