// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace True.Services.HubSpot.Quotes.Models {
    public class PublicObjectSearchRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The after property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? After { get; set; }
#nullable restore
#else
        public string After { get; set; }
#endif
        /// <summary>The filterGroups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilterGroup>? FilterGroups { get; set; }
#nullable restore
#else
        public List<FilterGroup> FilterGroups { get; set; }
#endif
        /// <summary>The limit property</summary>
        public int? Limit { get; set; }
        /// <summary>The properties property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Properties { get; set; }
#nullable restore
#else
        public List<string> Properties { get; set; }
#endif
        /// <summary>The query property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Query { get; set; }
#nullable restore
#else
        public string Query { get; set; }
#endif
        /// <summary>The sorts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Sorts { get; set; }
#nullable restore
#else
        public List<string> Sorts { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PublicObjectSearchRequest and sets the default values.
        /// </summary>
        public PublicObjectSearchRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublicObjectSearchRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicObjectSearchRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"after", n => { After = n.GetStringValue(); } },
                {"filterGroups", n => { FilterGroups = n.GetCollectionOfObjectValues<FilterGroup>(FilterGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"limit", n => { Limit = n.GetIntValue(); } },
                {"properties", n => { Properties = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"query", n => { Query = n.GetStringValue(); } },
                {"sorts", n => { Sorts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("after", After);
            writer.WriteCollectionOfObjectValues<FilterGroup>("filterGroups", FilterGroups);
            writer.WriteIntValue("limit", Limit);
            writer.WriteCollectionOfPrimitiveValues<string>("properties", Properties);
            writer.WriteStringValue("query", Query);
            writer.WriteCollectionOfPrimitiveValues<string>("sorts", Sorts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
