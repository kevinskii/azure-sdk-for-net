// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The health data for an endpoint
    /// </summary>
    public partial class EndpointHealthData
    {
        /// <summary>
        /// Initializes a new instance of the EndpointHealthData class.
        /// </summary>
        public EndpointHealthData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointHealthData class.
        /// </summary>
        /// <param name="endpointId">Id of the endpoint</param>
        /// <param name="healthStatus">Health status. Possible values include:
        /// 'unknown', 'healthy', 'unhealthy', 'dead'</param>
        public EndpointHealthData(string endpointId = default(string), string healthStatus = default(string))
        {
            EndpointId = endpointId;
            HealthStatus = healthStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the endpoint
        /// </summary>
        [JsonProperty(PropertyName = "endpointId")]
        public string EndpointId { get; set; }

        /// <summary>
        /// Gets or sets health status. Possible values include: 'unknown',
        /// 'healthy', 'unhealthy', 'dead'
        /// </summary>
        [JsonProperty(PropertyName = "healthStatus")]
        public string HealthStatus { get; set; }

    }
}