/* 
 * BludeltaWebServiceAPI Hosted
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Retrieve the OCR result of a single page from a certain InvoiceContainer
    /// </summary>
    [DataContract]
    public partial class OcrResultRequest :  IEquatable<OcrResultRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResultRequest" /> class.
        /// </summary>
        /// <param name="ContainerId">ContainerId.</param>
        /// <param name="PageNo">PageNo.</param>
        public OcrResultRequest(string ContainerId = default(string), int? PageNo = default(int?))
        {
            this.ContainerId = ContainerId;
            this.PageNo = PageNo;
        }
        
        /// <summary>
        /// Gets or Sets ContainerId
        /// </summary>
        [DataMember(Name="ContainerId", EmitDefaultValue=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or Sets PageNo
        /// </summary>
        [DataMember(Name="PageNo", EmitDefaultValue=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcrResultRequest {\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OcrResultRequest);
        }

        /// <summary>
        /// Returns true if OcrResultRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OcrResultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrResultRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContainerId == other.ContainerId ||
                    this.ContainerId != null &&
                    this.ContainerId.Equals(other.ContainerId)
                ) && 
                (
                    this.PageNo == other.PageNo ||
                    this.PageNo != null &&
                    this.PageNo.Equals(other.PageNo)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ContainerId != null)
                    hash = hash * 59 + this.ContainerId.GetHashCode();
                if (this.PageNo != null)
                    hash = hash * 59 + this.PageNo.GetHashCode();
                return hash;
            }
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
