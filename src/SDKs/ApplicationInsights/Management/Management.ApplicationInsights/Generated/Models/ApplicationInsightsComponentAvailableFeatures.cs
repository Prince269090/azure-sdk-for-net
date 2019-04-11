// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Application Insights component available features.
    /// </summary>
    public partial class ApplicationInsightsComponentAvailableFeatures
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentAvailableFeatures class.
        /// </summary>
        public ApplicationInsightsComponentAvailableFeatures()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentAvailableFeatures class.
        /// </summary>
        /// <param name="result">A list of Application Insights component
        /// feature.</param>
        public ApplicationInsightsComponentAvailableFeatures(IList<ApplicationInsightsComponentFeature> result = default(IList<ApplicationInsightsComponentFeature>))
        {
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a list of Application Insights component feature.
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public IList<ApplicationInsightsComponentFeature> Result { get; private set; }

    }
}