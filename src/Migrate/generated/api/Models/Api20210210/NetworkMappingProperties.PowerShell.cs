// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Network Mapping Properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkMappingPropertiesTypeConverter))]
    public partial class NetworkMappingProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NetworkMappingProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NetworkMappingProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NetworkMappingProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NetworkMappingProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NetworkMappingProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FabricSpecificSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSetting = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingFabricSpecificSettings) content.GetValueForProperty("FabricSpecificSetting",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSetting, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingFabricSpecificSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryNetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkFriendlyName = (string) content.GetValueForProperty("PrimaryNetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkId = (string) content.GetValueForProperty("PrimaryNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryFabricFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryFabricFriendlyName = (string) content.GetValueForProperty("PrimaryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryFabricFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryNetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkFriendlyName = (string) content.GetValueForProperty("RecoveryNetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkId = (string) content.GetValueForProperty("RecoveryNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricArmId = (string) content.GetValueForProperty("RecoveryFabricArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricArmId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricFriendlyName = (string) content.GetValueForProperty("RecoveryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricSpecificSettingInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSettingInstanceType = (string) content.GetValueForProperty("FabricSpecificSettingInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSettingInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NetworkMappingProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("FabricSpecificSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSetting = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingFabricSpecificSettings) content.GetValueForProperty("FabricSpecificSetting",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSetting, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.NetworkMappingFabricSpecificSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryNetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkFriendlyName = (string) content.GetValueForProperty("PrimaryNetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkId = (string) content.GetValueForProperty("PrimaryNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryFabricFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryFabricFriendlyName = (string) content.GetValueForProperty("PrimaryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).PrimaryFabricFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryNetworkFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkFriendlyName = (string) content.GetValueForProperty("RecoveryNetworkFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkId = (string) content.GetValueForProperty("RecoveryNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricArmId = (string) content.GetValueForProperty("RecoveryFabricArmId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricArmId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricFriendlyName = (string) content.GetValueForProperty("RecoveryFabricFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).RecoveryFabricFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricSpecificSettingInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSettingInstanceType = (string) content.GetValueForProperty("FabricSpecificSettingInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.INetworkMappingPropertiesInternal)this).FabricSpecificSettingInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Network Mapping Properties.
    [System.ComponentModel.TypeConverter(typeof(NetworkMappingPropertiesTypeConverter))]
    public partial interface INetworkMappingProperties

    {

    }
}