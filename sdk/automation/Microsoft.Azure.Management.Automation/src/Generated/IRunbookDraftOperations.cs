// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RunbookDraftOperations operations.
    /// </summary>
    public partial interface IRunbookDraftOperations
    {
        /// <summary>
        /// Retrieve the content of runbook draft identified by runbook name.
        /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream>> GetContentWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Replaces the runbook draft content.
        /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='runbookContent'>
        /// The runbook draft content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream,RunbookDraftReplaceContentHeaders>> ReplaceContentWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, Stream runbookContent, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve the runbook draft identified by runbook name.
        /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RunbookDraft>> GetWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Undo draft edit to last known published state identified by runbook
        /// name.
        /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RunbookDraftUndoEditResult>> UndoEditWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Replaces the runbook draft content.
        /// <see href="http://aka.ms/azureautomationsdk/runbookdraftoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='runbookName'>
        /// The runbook name.
        /// </param>
        /// <param name='runbookContent'>
        /// The runbook draft content.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Stream,RunbookDraftReplaceContentHeaders>> BeginReplaceContentWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string runbookName, Stream runbookContent, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}