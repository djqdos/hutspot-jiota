// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace True.Services.HubSpot.Quotes.Models {
    public class AssociationSpec : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The associationCategory property</summary>
        public AssociationSpec_associationCategory? AssociationCategory { get; set; }
        /// <summary>The associationTypeId property</summary>
        public int? AssociationTypeId { get; set; }
        /// <summary>
        /// Instantiates a new AssociationSpec and sets the default values.
        /// </summary>
        public AssociationSpec() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssociationSpec CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociationSpec();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"associationCategory", n => { AssociationCategory = n.GetEnumValue<AssociationSpec_associationCategory>(); } },
                {"associationTypeId", n => { AssociationTypeId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AssociationSpec_associationCategory>("associationCategory", AssociationCategory);
            writer.WriteIntValue("associationTypeId", AssociationTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
