// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Filters to list protection intent.
    /// </summary>
    public partial class ProtectionIntentQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the ProtectionIntentQueryObject
        /// class.
        /// </summary>
        public ProtectionIntentQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectionIntentQueryObject
        /// class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for the
        /// backed up item. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="itemType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'SQLInstance',
        /// 'SQLAvailabilityGroupContainer'</param>
        /// <param name="parentName">Parent name of the intent</param>
        /// <param name="itemName">Item name of the intent</param>
        public ProtectionIntentQueryObject(string backupManagementType = default(string), string itemType = default(string), string parentName = default(string), string itemName = default(string))
        {
            BackupManagementType = backupManagementType;
            ItemType = itemType;
            ParentName = parentName;
            ItemName = itemName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup management type for the backed up item.
        /// Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql', 'AzureStorage', 'AzureWorkload',
        /// 'DefaultBackup'
        /// </summary>
        [JsonProperty(PropertyName = "backupManagementType")]
        public string BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets type of workload this item represents. Possible values
        /// include: 'Invalid', 'SQLInstance', 'SQLAvailabilityGroupContainer'
        /// </summary>
        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or sets parent name of the intent
        /// </summary>
        [JsonProperty(PropertyName = "parentName")]
        public string ParentName { get; set; }

        /// <summary>
        /// Gets or sets item name of the intent
        /// </summary>
        [JsonProperty(PropertyName = "itemName")]
        public string ItemName { get; set; }

    }
}
