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
    /// ListReturnsRequestFilter
    /// </summary>
    [DataContract(Name = "ListReturnsRequestFilter")]
    public partial class ListReturnsRequestFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListReturnsRequestFilter" /> class.
        /// </summary>
        /// <param name="searchTerms">searchTerms.</param>
        /// <param name="returnIds">returnIds.</param>
        /// <param name="returnStatus">returnStatus.</param>
        /// <param name="orderGrns">orderGrns.</param>
        /// <param name="orderNumbers">orderNumbers.</param>
        /// <param name="orderItemGrns">orderItemGrns.</param>
        /// <param name="orderItemSkus">orderItemSkus.</param>
        /// <param name="customerGrns">customerGrns.</param>
        /// <param name="customerEmails">customerEmails.</param>
        /// <param name="createdAtStart">createdAtStart.</param>
        /// <param name="createdAtEnd">createdAtEnd.</param>
        public ListReturnsRequestFilter(List<string> searchTerms = default(List<string>), List<string> returnIds = default(List<string>), List<string> returnStatus = default(List<string>), List<string> orderGrns = default(List<string>), List<string> orderNumbers = default(List<string>), List<string> orderItemGrns = default(List<string>), List<string> orderItemSkus = default(List<string>), List<string> customerGrns = default(List<string>), List<string> customerEmails = default(List<string>), DateTime createdAtStart = default(DateTime), DateTime createdAtEnd = default(DateTime))
        {
            this.SearchTerms = searchTerms;
            this.ReturnIds = returnIds;
            this.ReturnStatus = returnStatus;
            this.OrderGrns = orderGrns;
            this.OrderNumbers = orderNumbers;
            this.OrderItemGrns = orderItemGrns;
            this.OrderItemSkus = orderItemSkus;
            this.CustomerGrns = customerGrns;
            this.CustomerEmails = customerEmails;
            this.CreatedAtStart = createdAtStart;
            this.CreatedAtEnd = createdAtEnd;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets SearchTerms
        /// </summary>
        [DataMember(Name = "searchTerms", EmitDefaultValue = false)]
        public List<string> SearchTerms { get; set; }

        /// <summary>
        /// Gets or Sets ReturnIds
        /// </summary>
        [DataMember(Name = "returnIds", EmitDefaultValue = false)]
        public List<string> ReturnIds { get; set; }

        /// <summary>
        /// Gets or Sets ReturnStatus
        /// </summary>
        [DataMember(Name = "returnStatus", EmitDefaultValue = false)]
        public List<string> ReturnStatus { get; set; }

        /// <summary>
        /// Gets or Sets OrderGrns
        /// </summary>
        [DataMember(Name = "orderGrns", EmitDefaultValue = false)]
        public List<string> OrderGrns { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumbers
        /// </summary>
        [DataMember(Name = "orderNumbers", EmitDefaultValue = false)]
        public List<string> OrderNumbers { get; set; }

        /// <summary>
        /// Gets or Sets OrderItemGrns
        /// </summary>
        [DataMember(Name = "orderItemGrns", EmitDefaultValue = false)]
        public List<string> OrderItemGrns { get; set; }

        /// <summary>
        /// Gets or Sets OrderItemSkus
        /// </summary>
        [DataMember(Name = "orderItemSkus", EmitDefaultValue = false)]
        public List<string> OrderItemSkus { get; set; }

        /// <summary>
        /// Gets or Sets CustomerGrns
        /// </summary>
        [DataMember(Name = "customerGrns", EmitDefaultValue = false)]
        public List<string> CustomerGrns { get; set; }

        /// <summary>
        /// Gets or Sets CustomerEmails
        /// </summary>
        [DataMember(Name = "customerEmails", EmitDefaultValue = false)]
        public List<string> CustomerEmails { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAtStart
        /// </summary>
        [DataMember(Name = "createdAtStart", EmitDefaultValue = false)]
        public DateTime CreatedAtStart { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAtEnd
        /// </summary>
        [DataMember(Name = "createdAtEnd", EmitDefaultValue = false)]
        public DateTime CreatedAtEnd { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListReturnsRequestFilter {\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  ReturnIds: ").Append(ReturnIds).Append("\n");
            sb.Append("  ReturnStatus: ").Append(ReturnStatus).Append("\n");
            sb.Append("  OrderGrns: ").Append(OrderGrns).Append("\n");
            sb.Append("  OrderNumbers: ").Append(OrderNumbers).Append("\n");
            sb.Append("  OrderItemGrns: ").Append(OrderItemGrns).Append("\n");
            sb.Append("  OrderItemSkus: ").Append(OrderItemSkus).Append("\n");
            sb.Append("  CustomerGrns: ").Append(CustomerGrns).Append("\n");
            sb.Append("  CustomerEmails: ").Append(CustomerEmails).Append("\n");
            sb.Append("  CreatedAtStart: ").Append(CreatedAtStart).Append("\n");
            sb.Append("  CreatedAtEnd: ").Append(CreatedAtEnd).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
