// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace True.Services.HubSpot.Pipelines.Models {
    public class PublicAuditInfo : IAdditionalDataHolder, IParsable {
        /// <summary>The action property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Action { get; set; }
#nullable restore
#else
        public string Action { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The fromUserId property</summary>
        public int? FromUserId { get; set; }
        /// <summary>The identifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The portalId property</summary>
        public int? PortalId { get; set; }
        /// <summary>The rawObject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicAuditInfo_rawObject? RawObject { get; set; }
#nullable restore
#else
        public PublicAuditInfo_rawObject RawObject { get; set; }
#endif
        /// <summary>The timestamp property</summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>
        /// Instantiates a new PublicAuditInfo and sets the default values.
        /// </summary>
        public PublicAuditInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicAuditInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicAuditInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetStringValue(); } },
                {"fromUserId", n => { FromUserId = n.GetIntValue(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"portalId", n => { PortalId = n.GetIntValue(); } },
                {"rawObject", n => { RawObject = n.GetObjectValue<PublicAuditInfo_rawObject>(PublicAuditInfo_rawObject.CreateFromDiscriminatorValue); } },
                {"timestamp", n => { Timestamp = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("action", Action);
            writer.WriteIntValue("fromUserId", FromUserId);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("message", Message);
            writer.WriteIntValue("portalId", PortalId);
            writer.WriteObjectValue<PublicAuditInfo_rawObject>("rawObject", RawObject);
            writer.WriteDateTimeOffsetValue("timestamp", Timestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
