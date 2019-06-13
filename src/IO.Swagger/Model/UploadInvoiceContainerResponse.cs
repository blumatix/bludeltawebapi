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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{
  /// <summary>
  ///   UploadInvoiceContainerResponse
  /// </summary>
  [DataContract]
  public class UploadInvoiceContainerResponse : IEquatable<UploadInvoiceContainerResponse>, IValidatableObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="UploadInvoiceContainerResponse" /> class.
    /// </summary>
    /// <param name="State">State.</param>
    public UploadInvoiceContainerResponse(int? State = default(int?))
    {
      this.State = State;
    }

    /// <summary>
    ///   Gets or Sets State
    /// </summary>
    [DataMember(Name = "State", EmitDefaultValue = false)]
    public int? State { get; set; }

    /// <summary>
    ///   Returns true if UploadInvoiceContainerResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UploadInvoiceContainerResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UploadInvoiceContainerResponse other)
    {
      // credit: http://stackoverflow.com/a/10454552/677735
      if (other == null)
        return false;

      return
        State == other.State ||
        State != null &&
        State.Equals(other.State);
    }

    /// <summary>
    ///   To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
      yield break;
    }

    /// <summary>
    ///   Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
      var sb = new StringBuilder();
      sb.Append("class UploadInvoiceContainerResponse {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    ///   Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    ///   Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
      // credit: http://stackoverflow.com/a/10454552/677735
      return Equals(obj as UploadInvoiceContainerResponse);
    }

    /// <summary>
    ///   Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
      // credit: http://stackoverflow.com/a/263416/677735
      unchecked // Overflow is fine, just wrap
      {
        var hash = 41;
        // Suitable nullity checks etc, of course :)
        if (State != null)
          hash = hash * 59 + State.GetHashCode();
        return hash;
      }
    }
  }
}