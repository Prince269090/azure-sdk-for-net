// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScriptExecutionHistoryOperations.
    /// </summary>
    public static partial class ScriptExecutionHistoryOperationsExtensions
    {
            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> ListByCluster(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName)
            {
                return operations.ListByClusterAsync(resourceGroupName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RuntimeScriptActionDetail>> ListByClusterAsync(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterWithHttpMessagesAsync(resourceGroupName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Promotes the specified ad-hoc script execution to a persisted script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            public static void Promote(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId)
            {
                operations.PromoteAsync(resourceGroupName, clusterName, scriptExecutionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Promotes the specified ad-hoc script execution to a persisted script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the cluster.
            /// </param>
            /// <param name='scriptExecutionId'>
            /// The script execution Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PromoteAsync(this IScriptExecutionHistoryOperations operations, string resourceGroupName, string clusterName, string scriptExecutionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PromoteWithHttpMessagesAsync(resourceGroupName, clusterName, scriptExecutionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RuntimeScriptActionDetail> ListByClusterNext(this IScriptExecutionHistoryOperations operations, string nextPageLink)
            {
                return operations.ListByClusterNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all scripts' execution history for the specified cluster.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RuntimeScriptActionDetail>> ListByClusterNextAsync(this IScriptExecutionHistoryOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByClusterNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}