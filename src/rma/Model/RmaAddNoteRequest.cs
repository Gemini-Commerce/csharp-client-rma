/*
 * RMA Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = rma.Client.OpenAPIDateConverter;

namespace rma.Model
{
    /// <summary>
    /// RmaAddNoteRequest
    /// </summary>
    [DataContract(Name = "rmaAddNoteRequest")]
    public partial class RmaAddNoteRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaAddNoteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RmaAddNoteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaAddNoteRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="returnId">returnId (required).</param>
        /// <param name="author">author (required).</param>
        /// <param name="note">note (required).</param>
        public RmaAddNoteRequest(string tenantId = default(string), string returnId = default(string), string author = default(string), string note = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for RmaAddNoteRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "returnId" is required (not null)
            if (returnId == null)
            {
                throw new ArgumentNullException("returnId is a required property for RmaAddNoteRequest and cannot be null");
            }
            this.ReturnId = returnId;
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for RmaAddNoteRequest and cannot be null");
            }
            this.Author = author;
            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new ArgumentNullException("note is a required property for RmaAddNoteRequest and cannot be null");
            }
            this.Note = note;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ReturnId
        /// </summary>
        [DataMember(Name = "returnId", IsRequired = true, EmitDefaultValue = true)]
        public string ReturnId { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", IsRequired = true, EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RmaAddNoteRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ReturnId: ").Append(ReturnId).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
