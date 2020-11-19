using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemporaryField.Better
{
    public class Estimator
    {
        private readonly TimeSpan defaultEstimate;

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

            var stats = new DurationStatistics(durations);
            var margin = TimeSpan.FromTicks(stats.StandardDeviation.Ticks * 3);
            return stats.Average + margin;
        }
    }
}
