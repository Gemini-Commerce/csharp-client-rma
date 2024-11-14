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
    /// Represents a postal address, e.g. for postal delivery or payments addresses. Given a postal address, a postal service can deliver items to a premise, P.O. Box or similar. It is not intended to model geographical locations (roads, towns, mountains).  In typical usage an address would be created via user input or from importing existing data, depending on the type of process.  Advice on address input / editing:  - Use an i18n-ready address widget such as    https://github.com/google/libaddressinput) - Users should not be presented with UI elements for input or editing of   fields outside countries where that field is used.  For more guidance on how to use this schema, please see: https://support.google.com/business/answer/6397478
    /// </summary>
    [DataContract(Name = "rmaPostalAddress")]
    public partial class RmaPostalAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RmaPostalAddress" /> class.
        /// </summary>
        /// <param name="revision">The schema revision of the &#x60;PostalAddress&#x60;. This must be set to 0, which is the latest revision.  All new revisions **must** be backward compatible with old revisions..</param>
        /// <param name="regionCode">Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to ensure the value is correct. See http://cldr.unicode.org/ and http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: \&quot;CH\&quot; for Switzerland..</param>
        /// <param name="languageCode">Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of the input form or is expected to match one of the languages used in the address&#39; country/region, or their transliterated equivalents. This can affect formatting in certain countries, but is not critical to the correctness of the data and will never affect any validation or other non-formatting related operations.  If this value is not known, it should be omitted (rather than specifying a possibly incorrect default).  Examples: \&quot;zh-Hant\&quot;, \&quot;ja\&quot;, \&quot;ja-Latn\&quot;, \&quot;en\&quot;..</param>
        /// <param name="postalCode">Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where they are used, they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.)..</param>
        /// <param name="sortingCode">Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used, the value is either a string like \&quot;CEDEX\&quot;, optionally followed by a number (e.g. \&quot;CEDEX 7\&quot;), or just a number alone, representing the \&quot;sector code\&quot; (Jamaica), \&quot;delivery area indicator\&quot; (Malawi) or \&quot;post office indicator\&quot; (e.g. Côte d&#39;Ivoire)..</param>
        /// <param name="administrativeArea">Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community (e.g. \&quot;Barcelona\&quot; and not \&quot;Catalonia\&quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated..</param>
        /// <param name="locality">Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world where localities are not well defined or do not fit into this structure well, leave locality empty and use address_lines..</param>
        /// <param name="sublocality">Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts..</param>
        /// <param name="addressLines">Unstructured address lines describing the lower levels of an address.  Because values in address_lines do not have type information and may sometimes contain multiple values in a single field (e.g. \&quot;Austin, TX\&quot;), it is important that the line order is clear. The order of address lines should be \&quot;envelope order\&quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make it explicit (e.g. \&quot;ja\&quot; for large-to-small ordering and \&quot;ja-Latn\&quot; or \&quot;en\&quot; for small-to-large). This way, the most specific line of an address can be selected based on the language.  The minimum permitted structural representation of an address consists of a region_code with all remaining information placed in the address_lines. It would be possible to format such an address very approximately without geocoding, but no semantic reasoning could be made about any of the address components until it was at least partially resolved.  Creating an address only containing a region_code and address_lines, and then geocoding is the recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the address should be localities or administrative areas)..</param>
        /// <param name="recipients">Optional. The recipient at the address. This field may, under certain circumstances, contain multiline information. For example, it might contain \&quot;care of\&quot; information..</param>
        /// <param name="organization">Optional. The name of the organization at the address..</param>
        /// <param name="phoneNumber">Optional..</param>
        /// <param name="additionalInfo">Optional..</param>
        public RmaPostalAddress(int revision = default(int), string regionCode = default(string), string languageCode = default(string), string postalCode = default(string), string sortingCode = default(string), string administrativeArea = default(string), string locality = default(string), string sublocality = default(string), List<string> addressLines = default(List<string>), List<string> recipients = default(List<string>), string organization = default(string), string phoneNumber = default(string), Object additionalInfo = default(Object))
        {
            this.Revision = revision;
            this.RegionCode = regionCode;
            this.LanguageCode = languageCode;
            this.PostalCode = postalCode;
            this.SortingCode = sortingCode;
            this.AdministrativeArea = administrativeArea;
            this.Locality = locality;
            this.Sublocality = sublocality;
            this.AddressLines = addressLines;
            this.Recipients = recipients;
            this.Organization = organization;
            this.PhoneNumber = phoneNumber;
            this.AdditionalInfo = additionalInfo;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The schema revision of the &#x60;PostalAddress&#x60;. This must be set to 0, which is the latest revision.  All new revisions **must** be backward compatible with old revisions.
        /// </summary>
        /// <value>The schema revision of the &#x60;PostalAddress&#x60;. This must be set to 0, which is the latest revision.  All new revisions **must** be backward compatible with old revisions.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        public int Revision { get; set; }

        /// <summary>
        /// Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to ensure the value is correct. See http://cldr.unicode.org/ and http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: \&quot;CH\&quot; for Switzerland.
        /// </summary>
        /// <value>Required. CLDR region code of the country/region of the address. This is never inferred and it is up to the user to ensure the value is correct. See http://cldr.unicode.org/ and http://www.unicode.org/cldr/charts/30/supplemental/territory_information.html for details. Example: \&quot;CH\&quot; for Switzerland.</value>
        [DataMember(Name = "regionCode", EmitDefaultValue = false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of the input form or is expected to match one of the languages used in the address&#39; country/region, or their transliterated equivalents. This can affect formatting in certain countries, but is not critical to the correctness of the data and will never affect any validation or other non-formatting related operations.  If this value is not known, it should be omitted (rather than specifying a possibly incorrect default).  Examples: \&quot;zh-Hant\&quot;, \&quot;ja\&quot;, \&quot;ja-Latn\&quot;, \&quot;en\&quot;.
        /// </summary>
        /// <value>Optional. BCP-47 language code of the contents of this address (if known). This is often the UI language of the input form or is expected to match one of the languages used in the address&#39; country/region, or their transliterated equivalents. This can affect formatting in certain countries, but is not critical to the correctness of the data and will never affect any validation or other non-formatting related operations.  If this value is not known, it should be omitted (rather than specifying a possibly incorrect default).  Examples: \&quot;zh-Hant\&quot;, \&quot;ja\&quot;, \&quot;ja-Latn\&quot;, \&quot;en\&quot;.</value>
        [DataMember(Name = "languageCode", EmitDefaultValue = false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where they are used, they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.).
        /// </summary>
        /// <value>Optional. Postal code of the address. Not all countries use or require postal codes to be present, but where they are used, they may trigger additional validation with other parts of the address (e.g. state/zip validation in the U.S.A.).</value>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used, the value is either a string like \&quot;CEDEX\&quot;, optionally followed by a number (e.g. \&quot;CEDEX 7\&quot;), or just a number alone, representing the \&quot;sector code\&quot; (Jamaica), \&quot;delivery area indicator\&quot; (Malawi) or \&quot;post office indicator\&quot; (e.g. Côte d&#39;Ivoire).
        /// </summary>
        /// <value>Optional. Additional, country-specific, sorting code. This is not used in most regions. Where it is used, the value is either a string like \&quot;CEDEX\&quot;, optionally followed by a number (e.g. \&quot;CEDEX 7\&quot;), or just a number alone, representing the \&quot;sector code\&quot; (Jamaica), \&quot;delivery area indicator\&quot; (Malawi) or \&quot;post office indicator\&quot; (e.g. Côte d&#39;Ivoire).</value>
        [DataMember(Name = "sortingCode", EmitDefaultValue = false)]
        public string SortingCode { get; set; }

        /// <summary>
        /// Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community (e.g. \&quot;Barcelona\&quot; and not \&quot;Catalonia\&quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.
        /// </summary>
        /// <value>Optional. Highest administrative subdivision which is used for postal addresses of a country or region. For example, this can be a state, a province, an oblast, or a prefecture. Specifically, for Spain this is the province and not the autonomous community (e.g. \&quot;Barcelona\&quot; and not \&quot;Catalonia\&quot;). Many countries don&#39;t use an administrative area in postal addresses. E.g. in Switzerland this should be left unpopulated.</value>
        [DataMember(Name = "administrativeArea", EmitDefaultValue = false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world where localities are not well defined or do not fit into this structure well, leave locality empty and use address_lines.
        /// </summary>
        /// <value>Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune, UK post town. In regions of the world where localities are not well defined or do not fit into this structure well, leave locality empty and use address_lines.</value>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.
        /// </summary>
        /// <value>Optional. Sublocality of the address. For example, this can be neighborhoods, boroughs, districts.</value>
        [DataMember(Name = "sublocality", EmitDefaultValue = false)]
        public string Sublocality { get; set; }

        /// <summary>
        /// Unstructured address lines describing the lower levels of an address.  Because values in address_lines do not have type information and may sometimes contain multiple values in a single field (e.g. \&quot;Austin, TX\&quot;), it is important that the line order is clear. The order of address lines should be \&quot;envelope order\&quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make it explicit (e.g. \&quot;ja\&quot; for large-to-small ordering and \&quot;ja-Latn\&quot; or \&quot;en\&quot; for small-to-large). This way, the most specific line of an address can be selected based on the language.  The minimum permitted structural representation of an address consists of a region_code with all remaining information placed in the address_lines. It would be possible to format such an address very approximately without geocoding, but no semantic reasoning could be made about any of the address components until it was at least partially resolved.  Creating an address only containing a region_code and address_lines, and then geocoding is the recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the address should be localities or administrative areas).
        /// </summary>
        /// <value>Unstructured address lines describing the lower levels of an address.  Because values in address_lines do not have type information and may sometimes contain multiple values in a single field (e.g. \&quot;Austin, TX\&quot;), it is important that the line order is clear. The order of address lines should be \&quot;envelope order\&quot; for the country/region of the address. In places where this can vary (e.g. Japan), address_language is used to make it explicit (e.g. \&quot;ja\&quot; for large-to-small ordering and \&quot;ja-Latn\&quot; or \&quot;en\&quot; for small-to-large). This way, the most specific line of an address can be selected based on the language.  The minimum permitted structural representation of an address consists of a region_code with all remaining information placed in the address_lines. It would be possible to format such an address very approximately without geocoding, but no semantic reasoning could be made about any of the address components until it was at least partially resolved.  Creating an address only containing a region_code and address_lines, and then geocoding is the recommended way to handle completely unstructured addresses (as opposed to guessing which parts of the address should be localities or administrative areas).</value>
        [DataMember(Name = "addressLines", EmitDefaultValue = false)]
        public List<string> AddressLines { get; set; }

        /// <summary>
        /// Optional. The recipient at the address. This field may, under certain circumstances, contain multiline information. For example, it might contain \&quot;care of\&quot; information.
        /// </summary>
        /// <value>Optional. The recipient at the address. This field may, under certain circumstances, contain multiline information. For example, it might contain \&quot;care of\&quot; information.</value>
        [DataMember(Name = "recipients", EmitDefaultValue = false)]
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Optional. The name of the organization at the address.
        /// </summary>
        /// <value>Optional. The name of the organization at the address.</value>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        /// <value>Optional.</value>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Optional.
        /// </summary>
        /// <value>Optional.</value>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public Object AdditionalInfo { get; set; }

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
            sb.Append("class RmaPostalAddress {\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  SortingCode: ").Append(SortingCode).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Sublocality: ").Append(Sublocality).Append("\n");
            sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
