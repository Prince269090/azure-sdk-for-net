// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Management policy action for base blob.
    /// </summary>
    public partial class ManagementPolicyBaseBlob
    {
        /// <summary>
        /// Initializes a new instance of the ManagementPolicyBaseBlob class.
        /// </summary>
        public ManagementPolicyBaseBlob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementPolicyBaseBlob class.
        /// </summary>
        /// <param name="tierToCool">The function to tier blobs to cool
        /// storage. Support blobs currently at Hot tier</param>
        /// <param name="tierToArchive">The function to tier blobs to archive
        /// storage. Support blobs currently at Hot or Cool tier</param>
        /// <param name="delete">The function to delete the blob</param>
        public ManagementPolicyBaseBlob(DateAfterModification tierToCool = default(DateAfterModification), DateAfterModification tierToArchive = default(DateAfterModification), DateAfterModification delete = default(DateAfterModification))
        {
            TierToCool = tierToCool;
            TierToArchive = tierToArchive;
            Delete = delete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the function to tier blobs to cool storage. Support
        /// blobs currently at Hot tier
        /// </summary>
        [JsonProperty(PropertyName = "tierToCool")]
        public DateAfterModification TierToCool { get; set; }

        /// <summary>
        /// Gets or sets the function to tier blobs to archive storage. Support
        /// blobs currently at Hot or Cool tier
        /// </summary>
        [JsonProperty(PropertyName = "tierToArchive")]
        public DateAfterModification TierToArchive { get; set; }

        /// <summary>
        /// Gets or sets the function to delete the blob
        /// </summary>
        [JsonProperty(PropertyName = "delete")]
        public DateAfterModification Delete { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TierToCool != null)
            {
                TierToCool.Validate();
            }
            if (TierToArchive != null)
            {
                TierToArchive.Validate();
            }
            if (Delete != null)
            {
                Delete.Validate();
            }
        }
    }
}