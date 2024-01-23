// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace True.Services.HubSpot.Pipelines.Models {
    /// <summary>
    /// A pipeline definition.
    /// </summary>
    public class Pipeline : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the pipeline is archived.</summary>
        public bool? Archived { get; set; }
        /// <summary>The date the pipeline was archived. `archivedAt` will only be present if the pipeline is archived.</summary>
        public DateTimeOffset? ArchivedAt { get; set; }
        /// <summary>The date the pipeline was created. The default pipelines will have createdAt = 0.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The order for displaying this pipeline. If two pipelines have a matching `displayOrder`, they will be sorted alphabetically by label.</summary>
        public int? DisplayOrder { get; set; }
        /// <summary>A unique identifier generated by HubSpot that can be used to retrieve and update the pipeline.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>A unique label used to organize pipelines in HubSpot&apos;s UI</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The stages associated with the pipeline. They can be retrieved and updated via the pipeline stages endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PipelineStage>? Stages { get; set; }
#nullable restore
#else
        public List<PipelineStage> Stages { get; set; }
#endif
        /// <summary>The date the pipeline was last updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new Pipeline and sets the default values.
        /// </summary>
        public Pipeline() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Pipeline CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Pipeline();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archived", n => { Archived = n.GetBoolValue(); } },
                {"archivedAt", n => { ArchivedAt = n.GetDateTimeOffsetValue(); } },
                {"createdAt", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"displayOrder", n => { DisplayOrder = n.GetIntValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"stages", n => { Stages = n.GetCollectionOfObjectValues<PipelineStage>(PipelineStage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updatedAt", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdAt", CreatedAt);
            writer.WriteIntValue("displayOrder", DisplayOrder);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("label", Label);
            writer.WriteCollectionOfObjectValues<PipelineStage>("stages", Stages);
            writer.WriteDateTimeOffsetValue("updatedAt", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
