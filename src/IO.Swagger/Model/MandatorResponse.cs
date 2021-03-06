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
    /// MandatorResponse
    /// </summary>
    [DataContract]
    public partial class MandatorResponse :  IEquatable<MandatorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MandatorResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MandatorResponse" /> class.
        /// </summary>
        /// <param name="ApiKey">Api key (required).</param>
        /// <param name="ApiIdentifiers">Api identifiers.</param>
        /// <param name="State">0 &#x3D; Ok, 1 &#x3D; Failed (required).</param>
        /// <param name="Message">Error message in case of an error.</param>
        public MandatorResponse(ApiKey ApiKey = default(ApiKey), List<ApiIdentifier> ApiIdentifiers = default(List<ApiIdentifier>), int? State = default(int?), string Message = default(string))
        {
            // to ensure "ApiKey" is required (not null)
            if (ApiKey == null)
            {
                throw new InvalidDataException("ApiKey is a required property for MandatorResponse and cannot be null");
            }
            else
            {
                this.ApiKey = ApiKey;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for MandatorResponse and cannot be null");
            }
            else
            {
                this.State = State;
            }
            this.ApiIdentifiers = ApiIdentifiers;
            this.Message = Message;
        }
        
        /// <summary>
        /// Api key
        /// </summary>
        /// <value>Api key</value>
        [DataMember(Name="ApiKey", EmitDefaultValue=false)]
        public ApiKey ApiKey { get; set; }

        /// <summary>
        /// Api identifiers
        /// </summary>
        /// <value>Api identifiers</value>
        [DataMember(Name="ApiIdentifiers", EmitDefaultValue=false)]
        public List<ApiIdentifier> ApiIdentifiers { get; set; }

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
            sb.Append("class MandatorResponse {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ApiIdentifiers: ").Append(ApiIdentifiers).Append("\n");
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
            return this.Equals(obj as MandatorResponse);
        }

        /// <summary>
        /// Returns true if MandatorResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of MandatorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MandatorResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.ApiIdentifiers == other.ApiIdentifiers ||
                    this.ApiIdentifiers != null &&
                    this.ApiIdentifiers.SequenceEqual(other.ApiIdentifiers)
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
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                if (this.ApiIdentifiers != null)
                    hash = hash * 59 + this.ApiIdentifiers.GetHashCode();
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
