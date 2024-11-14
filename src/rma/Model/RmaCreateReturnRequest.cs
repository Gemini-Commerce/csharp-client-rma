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
    /// RmaCreateReturnRequest
    /// </summary>
    [DataContract(Name = "rmaCreateReturnRequest")]
    public partial class RmaCreateReturnRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PreferredRefundMethod
        /// </summary>
        [DataMember(Name = "preferredRefundMethod", IsRequired = true, EmitDefaultValue = true)]
        public RmaRefundMethod PreferredRefundMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaCreateReturnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RmaCreateReturnRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaCreateReturnRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId (required).</param>
        /// <param name="orderGrn">orderGrn (required).</param>
        /// <param name="products">products (required).</param>
        /// <param name="preferredRefundMethod">preferredRefundMethod (required).</param>
        /// <param name="refundShippingCost">refundShippingCost.</param>
        /// <param name="refundPaymentCost">refundPaymentCost.</param>
        /// <param name="customerInfo">customerInfo.</param>
        /// <param name="returnAddress">returnAddress.</param>
        /// <param name="note">note.</param>
        public RmaCreateReturnRequest(string tenantId = default(string), string orderGrn = default(string), List<CreateReturnRequestProduct> products = default(List<CreateReturnRequestProduct>), RmaRefundMethod preferredRefundMethod = default(RmaRefundMethod), bool refundShippingCost = default(bool), bool refundPaymentCost = default(bool), RmaCustomerInfo customerInfo = default(RmaCustomerInfo), RmaPostalAddress returnAddress = default(RmaPostalAddress), string note = default(string))
        {
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new ArgumentNullException("tenantId is a required property for RmaCreateReturnRequest and cannot be null");
            }
            this.TenantId = tenantId;
            // to ensure "orderGrn" is required (not null)
            if (orderGrn == null)
            {
                throw new ArgumentNullException("orderGrn is a required property for RmaCreateReturnRequest and cannot be null");
            }
            this.OrderGrn = orderGrn;
            // to ensure "products" is required (not null)
            if (products == null)
            {
                throw new ArgumentNullException("products is a required property for RmaCreateReturnRequest and cannot be null");
            }
            this.Products = products;
            this.PreferredRefundMethod = preferredRefundMethod;
            this.RefundShippingCost = refundShippingCost;
            this.RefundPaymentCost = refundPaymentCost;
            this.CustomerInfo = customerInfo;
            this.ReturnAddress = returnAddress;
            this.Note = note;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets OrderGrn
        /// </summary>
        [DataMember(Name = "orderGrn", IsRequired = true, EmitDefaultValue = true)]
        public string OrderGrn { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", IsRequired = true, EmitDefaultValue = true)]
        public List<CreateReturnRequestProduct> Products { get; set; }

        /// <summary>
        /// Gets or Sets RefundShippingCost
        /// </summary>
        [DataMember(Name = "refundShippingCost", EmitDefaultValue = true)]
        public bool RefundShippingCost { get; set; }

        /// <summary>
        /// Gets or Sets RefundPaymentCost
        /// </summary>
        [DataMember(Name = "refundPaymentCost", EmitDefaultValue = true)]
        public bool RefundPaymentCost { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInfo
        /// </summary>
        [DataMember(Name = "customerInfo", EmitDefaultValue = false)]
        public RmaCustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAddress
        /// </summary>
        [DataMember(Name = "returnAddress", EmitDefaultValue = false)]
        public RmaPostalAddress ReturnAddress { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

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
            sb.Append("class RmaCreateReturnRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  OrderGrn: ").Append(OrderGrn).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  PreferredRefundMethod: ").Append(PreferredRefundMethod).Append("\n");
            sb.Append("  RefundShippingCost: ").Append(RefundShippingCost).Append("\n");
            sb.Append("  RefundPaymentCost: ").Append(RefundPaymentCost).Append("\n");
            sb.Append("  CustomerInfo: ").Append(CustomerInfo).Append("\n");
            sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
