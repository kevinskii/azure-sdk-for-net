// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> Standard Apache Lucene analyzer; Composed of the standard tokenizer, lowercase filter and stop filter. </summary>
    public partial class StandardAnalyzer : Analyzer
    {
        /// <summary> Initializes a new instance of StandardAnalyzer. </summary>
        public StandardAnalyzer()
        {
            ODataType = "#Microsoft.Azure.Search.StandardAnalyzer";
        }

        /// <summary> Initializes a new instance of StandardAnalyzer. </summary>
        /// <param name="maxTokenLength"> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </param>
        /// <param name="stopwords"> A list of stopwords. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal StandardAnalyzer(int? maxTokenLength, IList<string> stopwords, string oDataType, string name) : base(oDataType, name)
        {
            MaxTokenLength = maxTokenLength;
            Stopwords = stopwords;
            ODataType = "#Microsoft.Azure.Search.StandardAnalyzer";
        }

        /// <summary> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </summary>
        public int? MaxTokenLength { get; set; }
        /// <summary> A list of stopwords. </summary>
        public IList<string> Stopwords { get; set; }
    }
}
