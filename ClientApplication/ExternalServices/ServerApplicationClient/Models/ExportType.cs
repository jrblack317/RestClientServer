﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClientApplication.ExternalServices.ServerApplicationClient.Models
{
    /// <summary>
    /// Defines values for ExportType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExportType
    {
        [EnumMember(Value = "fannie")]
        Fannie,
        [EnumMember(Value = "freddie")]
        Freddie
    }
}
