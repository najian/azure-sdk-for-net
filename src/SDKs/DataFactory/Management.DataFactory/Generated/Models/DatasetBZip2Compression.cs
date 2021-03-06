// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The BZip2 compression method used on a dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("BZip2")]
    public partial class DatasetBZip2Compression : DatasetCompression
    {
        /// <summary>
        /// Initializes a new instance of the DatasetBZip2Compression class.
        /// </summary>
        public DatasetBZip2Compression()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetBZip2Compression class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public DatasetBZip2Compression(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>))
            : base(additionalProperties)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
