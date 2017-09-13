// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ApplicationOperations operations.
    /// </summary>
    public partial interface IApplicationOperations
    {
        /// <summary>
        /// Lists all of the applications available in the specified account.
        /// </summary>
        /// <remarks>
        /// This operation returns only applications and versions that are
        /// available for use on compute nodes; that is, that can be used in an
        /// application package reference. For administrator information about
        /// applications and versions that are not yet available to compute
        /// nodes, use the Azure portal or the Azure Resource Manager API.
        /// </remarks>
        /// <param name='applicationListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ApplicationSummary>,ApplicationListHeaders>> ListWithHttpMessagesAsync(ApplicationListOptions applicationListOptions = default(ApplicationListOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets information about the specified application.
        /// </summary>
        /// <remarks>
        /// This operation returns only applications and versions that are
        /// available for use on compute nodes; that is, that can be used in an
        /// application package reference. For administrator information about
        /// applications and versions that are not yet available to compute
        /// nodes, use the Azure portal or the Azure Resource Manager API.
        /// </remarks>
        /// <param name='applicationId'>
        /// The ID of the application.
        /// </param>
        /// <param name='applicationGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ApplicationSummary,ApplicationGetHeaders>> GetWithHttpMessagesAsync(string applicationId, ApplicationGetOptions applicationGetOptions = default(ApplicationGetOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the applications available in the specified account.
        /// </summary>
        /// <remarks>
        /// This operation returns only applications and versions that are
        /// available for use on compute nodes; that is, that can be used in an
        /// application package reference. For administrator information about
        /// applications and versions that are not yet available to compute
        /// nodes, use the Azure portal or the Azure Resource Manager API.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='applicationListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ApplicationSummary>,ApplicationListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, ApplicationListNextOptions applicationListNextOptions = default(ApplicationListNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}