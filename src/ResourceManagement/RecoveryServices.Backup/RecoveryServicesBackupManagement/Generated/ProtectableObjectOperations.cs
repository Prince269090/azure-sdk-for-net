// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// The Resource Manager API includes operations for managing the
    /// protectable objects registered to your Recovery Services Vault.
    /// </summary>
    internal partial class ProtectableObjectOperations : IServiceOperations<RecoveryServicesBackupManagementClient>, IProtectableObjectOperations
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableObjectOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ProtectableObjectOperations(RecoveryServicesBackupManagementClient client)
        {
            this._client = client;
        }
        
        private RecoveryServicesBackupManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.RecoveryServicesBackupManagementClient.
        /// </summary>
        public RecoveryServicesBackupManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Lists all the protectable objects within your subscription
        /// according to the query filter and the pagination parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='queryFilter'>
        /// Optional.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional. Pagination parameters for controlling the response.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of protectable object resonses as returned by the list
        /// protectable objects API.
        /// </returns>
        public async Task<ProtectableObjectListResponse> ListAsync(string resourceGroupName, string resourceName, ProtectableObjectListQueryParameters queryFilter, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("resourceName", resourceName);
                tracingParameters.Add("queryFilter", queryFilter);
                tracingParameters.Add("paginationParams", paginationParams);
                tracingParameters.Add("customRequestHeaders", customRequestHeaders);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/Subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId.ToString());
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            if (this.Client.ResourceNamespace != null)
            {
                url = url + Uri.EscapeDataString(this.Client.ResourceNamespace);
            }
            url = url + "/";
            url = url + "vaults";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceName);
            url = url + "/backupProtectableItems";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2016-05-01");
            List<string> odataFilter = new List<string>();
            if (queryFilter != null && queryFilter.BackupManagementType != null)
            {
                odataFilter.Add("backupManagementType eq '" + Uri.EscapeDataString(queryFilter.BackupManagementType) + "'");
            }
            if (queryFilter != null && queryFilter.Status != null)
            {
                odataFilter.Add("status eq '" + Uri.EscapeDataString(queryFilter.Status) + "'");
            }
            if (queryFilter != null && queryFilter.FriendlyName != null)
            {
                odataFilter.Add("friendlyName eq '" + Uri.EscapeDataString(queryFilter.FriendlyName) + "'");
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(" and ", odataFilter));
            }
            if (paginationParams != null && paginationParams.SkipToken != null)
            {
                queryParameters.Add("$skiptoken=" + Uri.EscapeDataString(paginationParams.SkipToken));
            }
            if (paginationParams != null && paginationParams.Top != null)
            {
                queryParameters.Add("$top=" + Uri.EscapeDataString(paginationParams.Top));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept-Language", customRequestHeaders.Culture);
                httpRequest.Headers.Add("x-ms-client-request-id", customRequestHeaders.ClientRequestId);
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ProtectableObjectListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ProtectableObjectListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            ProtectableObjectResourceList itemListInstance = new ProtectableObjectResourceList();
                            result.ItemList = itemListInstance;
                            
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    ProtectableObjectResource protectableObjectResourceInstance = new ProtectableObjectResource();
                                    itemListInstance.ProtectableObjects.Add(protectableObjectResourceInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        string typeName = ((string)propertiesValue["protectableItemType"]);
                                        if (typeName == "ProtectableItem")
                                        {
                                            ProtectableItem protectableItemInstance = new ProtectableItem();
                                            
                                            JToken friendlyNameValue = propertiesValue["friendlyName"];
                                            if (friendlyNameValue != null && friendlyNameValue.Type != JTokenType.Null)
                                            {
                                                string friendlyNameInstance = ((string)friendlyNameValue);
                                                protectableItemInstance.FriendlyName = friendlyNameInstance;
                                            }
                                            
                                            JToken protectionStateValue = propertiesValue["protectionState"];
                                            if (protectionStateValue != null && protectionStateValue.Type != JTokenType.Null)
                                            {
                                                string protectionStateInstance = ((string)protectionStateValue);
                                                protectableItemInstance.ProtectionState = protectionStateInstance;
                                            }
                                            
                                            JToken protectableItemTypeValue = propertiesValue["protectableItemType"];
                                            if (protectableItemTypeValue != null && protectableItemTypeValue.Type != JTokenType.Null)
                                            {
                                                string protectableItemTypeInstance = ((string)protectableItemTypeValue);
                                                protectableItemInstance.ProtectableItemType = protectableItemTypeInstance;
                                            }
                                            
                                            JToken backupManagementTypeValue = propertiesValue["backupManagementType"];
                                            if (backupManagementTypeValue != null && backupManagementTypeValue.Type != JTokenType.Null)
                                            {
                                                string backupManagementTypeInstance = ((string)backupManagementTypeValue);
                                                protectableItemInstance.BackupManagementType = backupManagementTypeInstance;
                                            }
                                            protectableObjectResourceInstance.Properties = protectableItemInstance;
                                        }
                                        if (typeName == "IaaSVMProtectableItem")
                                        {
                                            AzureIaaSVMProtectableItem azureIaaSVMProtectableItemInstance = new AzureIaaSVMProtectableItem();
                                            
                                            JToken virtualMachineIdValue = propertiesValue["virtualMachineId"];
                                            if (virtualMachineIdValue != null && virtualMachineIdValue.Type != JTokenType.Null)
                                            {
                                                string virtualMachineIdInstance = ((string)virtualMachineIdValue);
                                                azureIaaSVMProtectableItemInstance.VirtualMachineId = virtualMachineIdInstance;
                                            }
                                            
                                            JToken friendlyNameValue2 = propertiesValue["friendlyName"];
                                            if (friendlyNameValue2 != null && friendlyNameValue2.Type != JTokenType.Null)
                                            {
                                                string friendlyNameInstance2 = ((string)friendlyNameValue2);
                                                azureIaaSVMProtectableItemInstance.FriendlyName = friendlyNameInstance2;
                                            }
                                            
                                            JToken protectionStateValue2 = propertiesValue["protectionState"];
                                            if (protectionStateValue2 != null && protectionStateValue2.Type != JTokenType.Null)
                                            {
                                                string protectionStateInstance2 = ((string)protectionStateValue2);
                                                azureIaaSVMProtectableItemInstance.ProtectionState = protectionStateInstance2;
                                            }
                                            
                                            JToken protectableItemTypeValue2 = propertiesValue["protectableItemType"];
                                            if (protectableItemTypeValue2 != null && protectableItemTypeValue2.Type != JTokenType.Null)
                                            {
                                                string protectableItemTypeInstance2 = ((string)protectableItemTypeValue2);
                                                azureIaaSVMProtectableItemInstance.ProtectableItemType = protectableItemTypeInstance2;
                                            }
                                            
                                            JToken backupManagementTypeValue2 = propertiesValue["backupManagementType"];
                                            if (backupManagementTypeValue2 != null && backupManagementTypeValue2.Type != JTokenType.Null)
                                            {
                                                string backupManagementTypeInstance2 = ((string)backupManagementTypeValue2);
                                                azureIaaSVMProtectableItemInstance.BackupManagementType = backupManagementTypeInstance2;
                                            }
                                            protectableObjectResourceInstance.Properties = azureIaaSVMProtectableItemInstance;
                                        }
                                        if (typeName == "Microsoft.ClassicCompute/virtualMachines")
                                        {
                                            AzureIaaSClassicComputeVMProtectableItem azureIaaSClassicComputeVMProtectableItemInstance = new AzureIaaSClassicComputeVMProtectableItem();
                                            
                                            JToken virtualMachineIdValue2 = propertiesValue["virtualMachineId"];
                                            if (virtualMachineIdValue2 != null && virtualMachineIdValue2.Type != JTokenType.Null)
                                            {
                                                string virtualMachineIdInstance2 = ((string)virtualMachineIdValue2);
                                                azureIaaSClassicComputeVMProtectableItemInstance.VirtualMachineId = virtualMachineIdInstance2;
                                            }
                                            
                                            JToken friendlyNameValue3 = propertiesValue["friendlyName"];
                                            if (friendlyNameValue3 != null && friendlyNameValue3.Type != JTokenType.Null)
                                            {
                                                string friendlyNameInstance3 = ((string)friendlyNameValue3);
                                                azureIaaSClassicComputeVMProtectableItemInstance.FriendlyName = friendlyNameInstance3;
                                            }
                                            
                                            JToken protectionStateValue3 = propertiesValue["protectionState"];
                                            if (protectionStateValue3 != null && protectionStateValue3.Type != JTokenType.Null)
                                            {
                                                string protectionStateInstance3 = ((string)protectionStateValue3);
                                                azureIaaSClassicComputeVMProtectableItemInstance.ProtectionState = protectionStateInstance3;
                                            }
                                            
                                            JToken protectableItemTypeValue3 = propertiesValue["protectableItemType"];
                                            if (protectableItemTypeValue3 != null && protectableItemTypeValue3.Type != JTokenType.Null)
                                            {
                                                string protectableItemTypeInstance3 = ((string)protectableItemTypeValue3);
                                                azureIaaSClassicComputeVMProtectableItemInstance.ProtectableItemType = protectableItemTypeInstance3;
                                            }
                                            
                                            JToken backupManagementTypeValue3 = propertiesValue["backupManagementType"];
                                            if (backupManagementTypeValue3 != null && backupManagementTypeValue3.Type != JTokenType.Null)
                                            {
                                                string backupManagementTypeInstance3 = ((string)backupManagementTypeValue3);
                                                azureIaaSClassicComputeVMProtectableItemInstance.BackupManagementType = backupManagementTypeInstance3;
                                            }
                                            protectableObjectResourceInstance.Properties = azureIaaSClassicComputeVMProtectableItemInstance;
                                        }
                                        if (typeName == "Microsoft.Compute/virtualMachines")
                                        {
                                            AzureIaaSComputeVMProtectableItem azureIaaSComputeVMProtectableItemInstance = new AzureIaaSComputeVMProtectableItem();
                                            
                                            JToken virtualMachineIdValue3 = propertiesValue["virtualMachineId"];
                                            if (virtualMachineIdValue3 != null && virtualMachineIdValue3.Type != JTokenType.Null)
                                            {
                                                string virtualMachineIdInstance3 = ((string)virtualMachineIdValue3);
                                                azureIaaSComputeVMProtectableItemInstance.VirtualMachineId = virtualMachineIdInstance3;
                                            }
                                            
                                            JToken friendlyNameValue4 = propertiesValue["friendlyName"];
                                            if (friendlyNameValue4 != null && friendlyNameValue4.Type != JTokenType.Null)
                                            {
                                                string friendlyNameInstance4 = ((string)friendlyNameValue4);
                                                azureIaaSComputeVMProtectableItemInstance.FriendlyName = friendlyNameInstance4;
                                            }
                                            
                                            JToken protectionStateValue4 = propertiesValue["protectionState"];
                                            if (protectionStateValue4 != null && protectionStateValue4.Type != JTokenType.Null)
                                            {
                                                string protectionStateInstance4 = ((string)protectionStateValue4);
                                                azureIaaSComputeVMProtectableItemInstance.ProtectionState = protectionStateInstance4;
                                            }
                                            
                                            JToken protectableItemTypeValue4 = propertiesValue["protectableItemType"];
                                            if (protectableItemTypeValue4 != null && protectableItemTypeValue4.Type != JTokenType.Null)
                                            {
                                                string protectableItemTypeInstance4 = ((string)protectableItemTypeValue4);
                                                azureIaaSComputeVMProtectableItemInstance.ProtectableItemType = protectableItemTypeInstance4;
                                            }
                                            
                                            JToken backupManagementTypeValue4 = propertiesValue["backupManagementType"];
                                            if (backupManagementTypeValue4 != null && backupManagementTypeValue4.Type != JTokenType.Null)
                                            {
                                                string backupManagementTypeInstance4 = ((string)backupManagementTypeValue4);
                                                azureIaaSComputeVMProtectableItemInstance.BackupManagementType = backupManagementTypeInstance4;
                                            }
                                            protectableObjectResourceInstance.Properties = azureIaaSComputeVMProtectableItemInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        protectableObjectResourceInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        protectableObjectResourceInstance.Name = nameInstance;
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        protectableObjectResourceInstance.Type = typeInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        protectableObjectResourceInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            protectableObjectResourceInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                    
                                    JToken eTagValue = valueValue["eTag"];
                                    if (eTagValue != null && eTagValue.Type != JTokenType.Null)
                                    {
                                        string eTagInstance = ((string)eTagValue);
                                        protectableObjectResourceInstance.ETag = eTagInstance;
                                    }
                                }
                            }
                            
                            JToken nextLinkValue = responseDoc["nextLink"];
                            if (nextLinkValue != null && nextLinkValue.Type != JTokenType.Null)
                            {
                                string nextLinkInstance = ((string)nextLinkValue);
                                itemListInstance.NextLink = nextLinkInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
