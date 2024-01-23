// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace True.Services.HubSpot.Properties.Models {
    public class Property : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether or not the property is archived.</summary>
        public bool? Archived { get; set; }
        /// <summary>When the property was archived.</summary>
        public DateTimeOffset? ArchivedAt { get; set; }
        /// <summary>For default properties, true indicates that the property is calculated by a HubSpot process. It has no effect for custom properties.</summary>
        public bool? Calculated { get; set; }
        /// <summary>Represents a formula that is used to compute a calculated property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalculationFormula { get; set; }
#nullable restore
#else
        public string CalculationFormula { get; set; }
#endif
        /// <summary>The createdAt property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The internal user ID of the user who created the property in HubSpot. This field may not exist if the property was created outside of HubSpot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedUserId { get; set; }
#nullable restore
#else
        public string CreatedUserId { get; set; }
#endif
        /// <summary>A description of the property that will be shown as help text in HubSpot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Properties are shown in order, starting with the lowest positive integer value.</summary>
        public int? DisplayOrder { get; set; }
        /// <summary>For default properties, true indicates that the options are stored externally to the property settings.</summary>
        public bool? ExternalOptions { get; set; }
        /// <summary>Controls how the property appears in HubSpot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FieldType { get; set; }
#nullable restore
#else
        public string FieldType { get; set; }
#endif
        /// <summary>Whether or not the property can be used in a HubSpot form.</summary>
        public bool? FormField { get; set; }
        /// <summary>The name of the property group the property belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupName { get; set; }
#nullable restore
#else
        public string GroupName { get; set; }
#endif
        /// <summary>Whether or not the property&apos;s value must be unique. Once set, this can&apos;t be changed.</summary>
        public bool? HasUniqueValue { get; set; }
        /// <summary>Whether or not the property will be hidden from the HubSpot UI. It&apos;s recommended this be set to false for custom properties.</summary>
        public bool? Hidden { get; set; }
        /// <summary>This will be true for default object properties built into HubSpot.</summary>
        public bool? HubspotDefined { get; set; }
        /// <summary>A human-readable property label that will be shown in HubSpot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The modificationMetadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PropertyModificationMetadata? ModificationMetadata { get; set; }
#nullable restore
#else
        public PropertyModificationMetadata ModificationMetadata { get; set; }
#endif
        /// <summary>The internal property name, which must be used when referencing the property via the API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>A list of valid options for the property. This field is required for enumerated properties, but will be empty for other property types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Option>? Options { get; set; }
#nullable restore
#else
        public List<Option> Options { get; set; }
#endif
        /// <summary>If this property is related to other object(s), they&apos;ll be listed here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReferencedObjectType { get; set; }
#nullable restore
#else
        public string ReferencedObjectType { get; set; }
#endif
        /// <summary>Whether or not the property will display the currency symbol set in the account settings.</summary>
        public bool? ShowCurrencySymbol { get; set; }
        /// <summary>The property data type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The updatedAt property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The internal user ID of the user who updated the property in HubSpot. This field may not exist if the property was updated outside of HubSpot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedUserId { get; set; }
#nullable restore
#else
        public string UpdatedUserId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Property and sets the default values.
        /// </summary>
        public Property() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Property CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Property();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archived", n => { Archived = n.GetBoolValue(); } },
                {"archivedAt", n => { ArchivedAt = n.GetDateTimeOffsetValue(); } },
                {"calculated", n => { Calculated = n.GetBoolValue(); } },
                {"calculationFormula", n => { CalculationFormula = n.GetStringValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"createdUserId", n => { CreatedUserId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayOrder", n => { DisplayOrder = n.GetIntValue(); } },
                {"externalOptions", n => { ExternalOptions = n.GetBoolValue(); } },
                {"fieldType", n => { FieldType = n.GetStringValue(); } },
                {"formField", n => { FormField = n.GetBoolValue(); } },
                {"groupName", n => { GroupName = n.GetStringValue(); } },
                {"hasUniqueValue", n => { HasUniqueValue = n.GetBoolValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"hubspotDefined", n => { HubspotDefined = n.GetBoolValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"modificationMetadata", n => { ModificationMetadata = n.GetObjectValue<PropertyModificationMetadata>(PropertyModificationMetadata.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"options", n => { Options = n.GetCollectionOfObjectValues<Option>(Option.CreateFromDiscriminatorValue)?.ToList(); } },
                {"referencedObjectType", n => { ReferencedObjectType = n.GetStringValue(); } },
                {"showCurrencySymbol", n => { ShowCurrencySymbol = n.GetBoolValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"updatedUserId", n => { UpdatedUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("archived", Archived);
            writer.WriteDateTimeOffsetValue("archivedAt", ArchivedAt);
            writer.WriteBoolValue("calculated", Calculated);
            writer.WriteStringValue("calculationFormula", CalculationFormula);
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteStringValue("createdUserId", CreatedUserId);
            writer.WriteStringValue("description", Description);
            writer.WriteIntValue("displayOrder", DisplayOrder);
            writer.WriteBoolValue("externalOptions", ExternalOptions);
            writer.WriteStringValue("fieldType", FieldType);
            writer.WriteBoolValue("formField", FormField);
            writer.WriteStringValue("groupName", GroupName);
            writer.WriteBoolValue("hasUniqueValue", HasUniqueValue);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteBoolValue("hubspotDefined", HubspotDefined);
            writer.WriteStringValue("label", Label);
            writer.WriteObjectValue<PropertyModificationMetadata>("modificationMetadata", ModificationMetadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<Option>("options", Options);
            writer.WriteStringValue("referencedObjectType", ReferencedObjectType);
            writer.WriteBoolValue("showCurrencySymbol", ShowCurrencySymbol);
            writer.WriteStringValue("type", Type);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteStringValue("updatedUserId", UpdatedUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
