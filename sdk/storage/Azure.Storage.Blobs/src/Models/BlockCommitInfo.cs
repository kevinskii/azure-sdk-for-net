// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Storage.Blobs.Models
{
    /// <summary>
    /// Describes block to be committed as part of a block list.
    /// </summary>
    public class BlockCommitInfo
    {
        /// <summary>
        /// The base-64 encoded block ID.
        /// </summary>
        public string Base64ID { get; set; }

        /// <summary>
        /// <see cref="BlockCommitType"/>
        /// </summary>
        public BlockCommitType CommitType { get; set; }
    }
}
