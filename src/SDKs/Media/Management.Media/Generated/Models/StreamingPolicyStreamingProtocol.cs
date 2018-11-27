// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StreamingPolicyStreamingProtocol.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StreamingPolicyStreamingProtocol
    {
        /// <summary>
        /// HLS protocol
        /// </summary>
        [EnumMember(Value = "Hls")]
        Hls,
        /// <summary>
        /// DASH protocol
        /// </summary>
        [EnumMember(Value = "Dash")]
        Dash,
        /// <summary>
        /// SmoothStreaming protocol
        /// </summary>
        [EnumMember(Value = "SmoothStreaming")]
        SmoothStreaming,
        /// <summary>
        /// Download protocol
        /// </summary>
        [EnumMember(Value = "Download")]
        Download
    }
    internal static class StreamingPolicyStreamingProtocolEnumExtension
    {
        internal static string ToSerializedValue(this StreamingPolicyStreamingProtocol? value)
        {
            return value == null ? null : ((StreamingPolicyStreamingProtocol)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StreamingPolicyStreamingProtocol value)
        {
            switch( value )
            {
                case StreamingPolicyStreamingProtocol.Hls:
                    return "Hls";
                case StreamingPolicyStreamingProtocol.Dash:
                    return "Dash";
                case StreamingPolicyStreamingProtocol.SmoothStreaming:
                    return "SmoothStreaming";
                case StreamingPolicyStreamingProtocol.Download:
                    return "Download";
            }
            return null;
        }

        internal static StreamingPolicyStreamingProtocol? ParseStreamingPolicyStreamingProtocol(this string value)
        {
            switch( value )
            {
                case "Hls":
                    return StreamingPolicyStreamingProtocol.Hls;
                case "Dash":
                    return StreamingPolicyStreamingProtocol.Dash;
                case "SmoothStreaming":
                    return StreamingPolicyStreamingProtocol.SmoothStreaming;
                case "Download":
                    return StreamingPolicyStreamingProtocol.Download;
            }
            return null;
        }
    }
}