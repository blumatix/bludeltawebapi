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
    /// ConfirmationResponse
    /// </summary>
    [DataContract]
    public partial class ConfirmationResponse :  IEquatable<ConfirmationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfirmationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmationResponse" /> class.
        /// </summary>
        /// <param name="State">0 &#x3D; Ok, 1 &#x3D; Failed (required).</param>
        /// <param name="Message">Error message in case of an error.</param>
        public ConfirmationResponse(int? State = default(int?), string Message = default(string))
        {
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for ConfirmationResponse and cannot be null");
            }
            else
            {
                this.State = State;
            }
            this.Message = Message;
        }
        
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
            sb.Append("class ConfirmationResponse {\n");
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
            return this.Equals(obj as ConfirmationResponse);
        }

        /// <summary>
        /// Returns true if ConfirmationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfirmationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfirmationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
