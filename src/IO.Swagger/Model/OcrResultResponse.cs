/* 
 * BludeltaWebServiceAPI Selfhosted
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
    /// OcrResultResponse
    /// </summary>
    [DataContract]
    public partial class OcrResultResponse :  IEquatable<OcrResultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResultResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OcrResultResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResultResponse" /> class.
        /// </summary>
        /// <param name="OcrResult">OcrResult. It contains either the requested page or all pages.</param>
        /// <param name="State">0 &#x3D; Ok, 1 &#x3D; Failed (required).</param>
        /// <param name="Message">Error message in case of an error.</param>
        public OcrResultResponse(Object OcrResult = default(Object), int? State = default(int?), string Message = default(string))
        {
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for OcrResultResponse and cannot be null");
            }
            else
            {
                this.State = State;
            }
            this.OcrResult = OcrResult;
            this.Message = Message;
        }
        
        /// <summary>
        /// OcrResult. It contains either the requested page or all pages
        /// </summary>
        /// <value>OcrResult. It contains either the requested page or all pages</value>
        [DataMember(Name="OcrResult", EmitDefaultValue=false)]
        public Object OcrResult { get; set; }

        /// <summary>
        /// 0 &#x3D; Ok, 1 &#x3D; Failed
        /// </summary>
        /// <value>0 &#x3D; Ok, 1 &#x3D; Failed</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// Error message in case of an error
        /// </summary>
        /// <value>Error message in case of an error</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OcrResultResponse {\n");
            sb.Append("  OcrResult: ").Append(OcrResult).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as OcrResultResponse);
        }

        /// <summary>
        /// Returns true if OcrResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OcrResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrResultResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OcrResult == other.OcrResult ||
                    this.OcrResult != null &&
                    this.OcrResult.Equals(other.OcrResult)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.OcrResult != null)
                    hash = hash * 59 + this.OcrResult.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
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
