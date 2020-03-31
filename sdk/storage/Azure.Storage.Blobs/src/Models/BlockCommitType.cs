// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Specifies the type of block to be committed.
    ///
    /// For more information, see  <see href="https://docs.microsoft.com/en-us/rest/api/storageservices/put-block-list"/>.
    /// </summary>
    public enum BlockCommitType
    {
        /// <summary>
        /// The block to be committed is in the committed block list.
        /// </summary>
        Committed,

        /// <summary>
        /// The block to be committed is in the Uncommitted block list.
        /// </summary>
        Uncommitted,

        /// <summary>
        /// First search for the specified block in the uncommitted list, and if not present there
        /// then search in the committed list.
        /// </summary>
        Latest,
    }
}
