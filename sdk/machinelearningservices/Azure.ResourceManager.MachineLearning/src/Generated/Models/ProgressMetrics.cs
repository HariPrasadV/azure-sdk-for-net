// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Progress metrics definition. </summary>
    public partial class ProgressMetrics
    {
        /// <summary> Initializes a new instance of ProgressMetrics. </summary>
        internal ProgressMetrics()
        {
        }

        /// <summary> Initializes a new instance of ProgressMetrics. </summary>
        /// <param name="completedDatapointCount"> The completed datapoint count. </param>
        /// <param name="incrementalDataLastRefreshOn"> The time of last successful incremental data refresh in UTC. </param>
        /// <param name="skippedDatapointCount"> The skipped datapoint count. </param>
        /// <param name="totalDatapointCount"> The total datapoint count. </param>
        internal ProgressMetrics(long? completedDatapointCount, DateTimeOffset? incrementalDataLastRefreshOn, long? skippedDatapointCount, long? totalDatapointCount)
        {
            CompletedDatapointCount = completedDatapointCount;
            IncrementalDataLastRefreshOn = incrementalDataLastRefreshOn;
            SkippedDatapointCount = skippedDatapointCount;
            TotalDatapointCount = totalDatapointCount;
        }

        /// <summary> The completed datapoint count. </summary>
        public long? CompletedDatapointCount { get; }
        /// <summary> The time of last successful incremental data refresh in UTC. </summary>
        public DateTimeOffset? IncrementalDataLastRefreshOn { get; }
        /// <summary> The skipped datapoint count. </summary>
        public long? SkippedDatapointCount { get; }
        /// <summary> The total datapoint count. </summary>
        public long? TotalDatapointCount { get; }
    }
}
