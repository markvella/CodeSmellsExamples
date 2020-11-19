using System;
using System.Collections.Generic;
using System.Linq;
namespace TemporaryField.Bad{
    public class Estimator
    {
        private readonly TimeSpan defaultEstimate;
        private IReadOnlyCollection<TimeSpan> durations;
        private TimeSpan average;
        private TimeSpan standardDeviation;

        public Estimator(TimeSpan defaultEstimate)
        {
            this.defaultEstimate = defaultEstimate;
        }

        public TimeSpan CalculateEstimate(
            IReadOnlyCollection<TimeSpan> durations)
        {
            if (durations == null)
                throw new ArgumentNullException(nameof(durations));

            if (durations.Count == 0)
                return this.defaultEstimate;

            this.durations = durations;
            this.CalculateAverage();
            this.CalculateStandardDeviation();

            var margin = TimeSpan.FromTicks(this.standardDeviation.Ticks * 3);
            return this.average + margin;
        }

        private void CalculateAverage()
        {
            this.average =
                TimeSpan.FromTicks(
                    (long)this.durations.Average(ts => ts.Ticks));
        }

        private void CalculateStandardDeviation()
        {
            var variance =
                this.durations.Average(ts =>
                    Math.Pow(
                        (ts - this.average).Ticks,
                        2));
            this.standardDeviation =
                TimeSpan.FromTicks((long)Math.Sqrt(variance));
        }
    }
}