// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about the number of virtual machine instances in each
    /// upgrade state.
    /// </summary>
    public partial class RollingUpgradeProgressInfo
    {
        /// <summary>
        /// Initializes a new instance of the RollingUpgradeProgressInfo class.
        /// </summary>
        public RollingUpgradeProgressInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RollingUpgradeProgressInfo class.
        /// </summary>
        /// <param name="successfulInstanceCount">The number of instances that
        /// have been successfully upgraded.</param>
        /// <param name="failedInstanceCount">The number of instances that have
        /// failed to be upgraded successfully.</param>
        /// <param name="inProgressInstanceCount">The number of instances that
        /// are currently being upgraded.</param>
        /// <param name="pendingInstanceCount">The number of instances that
        /// have not yet begun to be upgraded.</param>
        public RollingUpgradeProgressInfo(int? successfulInstanceCount = default(int?), int? failedInstanceCount = default(int?), int? inProgressInstanceCount = default(int?), int? pendingInstanceCount = default(int?))
        {
            SuccessfulInstanceCount = successfulInstanceCount;
            FailedInstanceCount = failedInstanceCount;
            InProgressInstanceCount = inProgressInstanceCount;
            PendingInstanceCount = pendingInstanceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of instances that have been successfully upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "successfulInstanceCount")]
        public int? SuccessfulInstanceCount { get; private set; }

        /// <summary>
        /// Gets the number of instances that have failed to be upgraded
        /// successfully.
        /// </summary>
        [JsonProperty(PropertyName = "failedInstanceCount")]
        public int? FailedInstanceCount { get; private set; }

        /// <summary>
        /// Gets the number of instances that are currently being upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "inProgressInstanceCount")]
        public int? InProgressInstanceCount { get; private set; }

        /// <summary>
        /// Gets the number of instances that have not yet begun to be
        /// upgraded.
        /// </summary>
        [JsonProperty(PropertyName = "pendingInstanceCount")]
        public int? PendingInstanceCount { get; private set; }

    }
}
