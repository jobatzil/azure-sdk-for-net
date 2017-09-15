// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProductState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProductState
    {
        [EnumMember(Value = "notPublished")]
        NotPublished,
        [EnumMember(Value = "published")]
        Published
    }
    internal static class ProductStateEnumExtension
    {
        internal static string ToSerializedValue(this ProductState? value)  =>
            value == null ? null : ((ProductState)value).ToSerializedValue();

        internal static string ToSerializedValue(this ProductState value)
        {
            switch( value )
            {
                case ProductState.NotPublished:
                    return "notPublished";
                case ProductState.Published:
                    return "published";
            }
            return null;
        }

        internal static ProductState? ParseProductState(this string value)
        {
            switch( value )
            {
                case "notPublished":
                    return ProductState.NotPublished;
                case "published":
                    return ProductState.Published;
            }
            return null;
        }
    }
}