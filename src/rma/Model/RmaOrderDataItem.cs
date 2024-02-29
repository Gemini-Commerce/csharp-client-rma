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
    /// RmaOrderDataItem
    /// </summary>
    [DataContract(Name = "rmaOrderDataItem")]
    public partial class RmaOrderDataItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaOrderDataItem" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="productGrn">productGrn.</param>
        /// <param name="qtyOrdered">qtyOrdered.</param>
        /// <param name="qtyCommitted">qtyCommitted.</param>
        /// <param name="qtyShipped">qtyShipped.</param>
        /// <param name="unitSalePrice">unitSalePrice.</param>
        /// <param name="unitListPrice">unitListPrice.</param>
        /// <param name="unitVatAmount">unitVatAmount.</param>
        /// <param name="rowSalePrice">rowSalePrice.</param>
        /// <param name="rowListPrice">rowListPrice.</param>
        /// <param name="rowVatAmount">rowVatAmount.</param>
        /// <param name="vatPercentage">vatPercentage.</param>
        /// <param name="vatInaccurate">vatInaccurate.</param>
        /// <param name="vatCalculated">vatCalculated.</param>
        /// <param name="productName">productName.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="productSku">productSku.</param>
        /// <param name="productOptions">productOptions.</param>
        /// <param name="productImg">productImg.</param>
        /// <param name="productData">productData.</param>
        /// <param name="shipmentInfoReference">shipmentInfoReference.</param>
        /// <param name="promotionGrn">promotionGrn.</param>
        /// <param name="productIsVirtual">productIsVirtual.</param>
        public RmaOrderDataItem(string id = default(string), string productGrn = default(string), long qtyOrdered = default(long), long qtyCommitted = default(long), long qtyShipped = default(long), RmaMoney unitSalePrice = default(RmaMoney), RmaMoney unitListPrice = default(RmaMoney), RmaMoney unitVatAmount = default(RmaMoney), RmaMoney rowSalePrice = default(RmaMoney), RmaMoney rowListPrice = default(RmaMoney), RmaMoney rowVatAmount = default(RmaMoney), float vatPercentage = default(float), bool vatInaccurate = default(bool), bool vatCalculated = default(bool), string productName = default(string), string productCode = default(string), string productSku = default(string), string productOptions = default(string), string productImg = default(string), string productData = default(string), string shipmentInfoReference = default(string), List<string> promotionGrn = default(List<string>), bool productIsVirtual = default(bool))
        {
            this.Id = id;
            this.ProductGrn = productGrn;
            this.QtyOrdered = qtyOrdered;
            this.QtyCommitted = qtyCommitted;
            this.QtyShipped = qtyShipped;
            this.UnitSalePrice = unitSalePrice;
            this.UnitListPrice = unitListPrice;
            this.UnitVatAmount = unitVatAmount;
            this.RowSalePrice = rowSalePrice;
            this.RowListPrice = rowListPrice;
            this.RowVatAmount = rowVatAmount;
            this.VatPercentage = vatPercentage;
            this.VatInaccurate = vatInaccurate;
            this.VatCalculated = vatCalculated;
            this.ProductName = productName;
            this.ProductCode = productCode;
            this.ProductSku = productSku;
            this.ProductOptions = productOptions;
            this.ProductImg = productImg;
            this.ProductData = productData;
            this.ShipmentInfoReference = shipmentInfoReference;
            this.PromotionGrn = promotionGrn;
            this.ProductIsVirtual = productIsVirtual;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ProductGrn
        /// </summary>
        [DataMember(Name = "productGrn", EmitDefaultValue = false)]
        public string ProductGrn { get; set; }

        /// <summary>
        /// Gets or Sets QtyOrdered
        /// </summary>
        [DataMember(Name = "qtyOrdered", EmitDefaultValue = false)]
        public long QtyOrdered { get; set; }

        /// <summary>
        /// Gets or Sets QtyCommitted
        /// </summary>
        [DataMember(Name = "qtyCommitted", EmitDefaultValue = false)]
        public long QtyCommitted { get; set; }

        /// <summary>
        /// Gets or Sets QtyShipped
        /// </summary>
        [DataMember(Name = "qtyShipped", EmitDefaultValue = false)]
        public long QtyShipped { get; set; }

        /// <summary>
        /// Gets or Sets UnitSalePrice
        /// </summary>
        [DataMember(Name = "unitSalePrice", EmitDefaultValue = false)]
        public RmaMoney UnitSalePrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitListPrice
        /// </summary>
        [DataMember(Name = "unitListPrice", EmitDefaultValue = false)]
        public RmaMoney UnitListPrice { get; set; }

        /// <summary>
        /// Gets or Sets UnitVatAmount
        /// </summary>
        [DataMember(Name = "unitVatAmount", EmitDefaultValue = false)]
        public RmaMoney UnitVatAmount { get; set; }

        /// <summary>
        /// Gets or Sets RowSalePrice
        /// </summary>
        [DataMember(Name = "rowSalePrice", EmitDefaultValue = false)]
        public RmaMoney RowSalePrice { get; set; }

        /// <summary>
        /// Gets or Sets RowListPrice
        /// </summary>
        [DataMember(Name = "rowListPrice", EmitDefaultValue = false)]
        public RmaMoney RowListPrice { get; set; }

        /// <summary>
        /// Gets or Sets RowVatAmount
        /// </summary>
        [DataMember(Name = "rowVatAmount", EmitDefaultValue = false)]
        public RmaMoney RowVatAmount { get; set; }

        /// <summary>
        /// Gets or Sets VatPercentage
        /// </summary>
        [DataMember(Name = "vatPercentage", EmitDefaultValue = false)]
        public float VatPercentage { get; set; }

        /// <summary>
        /// Gets or Sets VatInaccurate
        /// </summary>
        [DataMember(Name = "vatInaccurate", EmitDefaultValue = true)]
        public bool VatInaccurate { get; set; }

        /// <summary>
        /// Gets or Sets VatCalculated
        /// </summary>
        [DataMember(Name = "vatCalculated", EmitDefaultValue = true)]
        public bool VatCalculated { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name = "productName", EmitDefaultValue = false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name = "productCode", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductSku
        /// </summary>
        [DataMember(Name = "productSku", EmitDefaultValue = false)]
        public string ProductSku { get; set; }

        /// <summary>
        /// Gets or Sets ProductOptions
        /// </summary>
        [DataMember(Name = "productOptions", EmitDefaultValue = false)]
        public string ProductOptions { get; set; }

        /// <summary>
        /// Gets or Sets ProductImg
        /// </summary>
        [DataMember(Name = "productImg", EmitDefaultValue = false)]
        public string ProductImg { get; set; }

        /// <summary>
        /// Gets or Sets ProductData
        /// </summary>
        [DataMember(Name = "productData", EmitDefaultValue = false)]
        public string ProductData { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentInfoReference
        /// </summary>
        [DataMember(Name = "shipmentInfoReference", EmitDefaultValue = false)]
        public string ShipmentInfoReference { get; set; }

        /// <summary>
        /// Gets or Sets PromotionGrn
        /// </summary>
        [DataMember(Name = "promotionGrn", EmitDefaultValue = false)]
        public List<string> PromotionGrn { get; set; }

        /// <summary>
        /// Gets or Sets ProductIsVirtual
        /// </summary>
        [DataMember(Name = "productIsVirtual", EmitDefaultValue = true)]
        public bool ProductIsVirtual { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RmaOrderDataItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductGrn: ").Append(ProductGrn).Append("\n");
            sb.Append("  QtyOrdered: ").Append(QtyOrdered).Append("\n");
            sb.Append("  QtyCommitted: ").Append(QtyCommitted).Append("\n");
            sb.Append("  QtyShipped: ").Append(QtyShipped).Append("\n");
            sb.Append("  UnitSalePrice: ").Append(UnitSalePrice).Append("\n");
            sb.Append("  UnitListPrice: ").Append(UnitListPrice).Append("\n");
            sb.Append("  UnitVatAmount: ").Append(UnitVatAmount).Append("\n");
            sb.Append("  RowSalePrice: ").Append(RowSalePrice).Append("\n");
            sb.Append("  RowListPrice: ").Append(RowListPrice).Append("\n");
            sb.Append("  RowVatAmount: ").Append(RowVatAmount).Append("\n");
            sb.Append("  VatPercentage: ").Append(VatPercentage).Append("\n");
            sb.Append("  VatInaccurate: ").Append(VatInaccurate).Append("\n");
            sb.Append("  VatCalculated: ").Append(VatCalculated).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
            sb.Append("  ProductOptions: ").Append(ProductOptions).Append("\n");
            sb.Append("  ProductImg: ").Append(ProductImg).Append("\n");
            sb.Append("  ProductData: ").Append(ProductData).Append("\n");
            sb.Append("  ShipmentInfoReference: ").Append(ShipmentInfoReference).Append("\n");
            sb.Append("  PromotionGrn: ").Append(PromotionGrn).Append("\n");
            sb.Append("  ProductIsVirtual: ").Append(ProductIsVirtual).Append("\n");
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