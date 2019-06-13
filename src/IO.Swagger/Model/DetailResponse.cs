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
  ///   DetailResponse
  /// </summary>
  [DataContract]
  public class DetailResponse : IEquatable<DetailResponse>, IValidatableObject
  {
    /// <summary>
    ///   Initializes a new instance of the <see cref="DetailResponse" /> class.
    /// </summary>
    /// <param name="Name">Name of the detail.</param>
    /// <param name="Text">The content as raw text.</param>
    /// <param name="Value">The content formatted as value.</param>
    /// <param name="Score">Scored probability. Value between zero and one..</param>
    /// <param name="X">X-Position according to the document resolution.</param>
    /// <param name="Y">Y-Position according to the document resolution.</param>
    /// <param name="Width">Width according to the document resolution.</param>
    /// <param name="Height">Height according to the document resolution.</param>
    public DetailResponse(string Name = default(string), string Text = default(string), string Value = default(string),
      double? Score = default(double?), int? X = default(int?), int? Y = default(int?), int? Width = default(int?),
      int? Height = default(int?))
    {
      this.Name = Name;
      this.Text = Text;
      this.Value = Value;
      this.Score = Score;
      this.X = X;
      this.Y = Y;
      this.Width = Width;
      this.Height = Height;
    }

    /// <summary>
    ///   Name of the detail
    /// </summary>
    /// <value>Name of the detail</value>
    [DataMember(Name = "Name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///   The content as raw text
    /// </summary>
    /// <value>The content as raw text</value>
    [DataMember(Name = "Text", EmitDefaultValue = false)]
    public string Text { get; set; }

    /// <summary>
    ///   The content formatted as value
    /// </summary>
    /// <value>The content formatted as value</value>
    [DataMember(Name = "Value", EmitDefaultValue = false)]
    public string Value { get; set; }

    /// <summary>
    ///   Scored probability. Value between zero and one.
    /// </summary>
    /// <value>Scored probability. Value between zero and one.</value>
    [DataMember(Name = "Score", EmitDefaultValue = false)]
    public double? Score { get; set; }

    /// <summary>
    ///   X-Position according to the document resolution
    /// </summary>
    /// <value>X-Position according to the document resolution</value>
    [DataMember(Name = "X", EmitDefaultValue = false)]
    public int? X { get; set; }

    /// <summary>
    ///   Y-Position according to the document resolution
    /// </summary>
    /// <value>Y-Position according to the document resolution</value>
    [DataMember(Name = "Y", EmitDefaultValue = false)]
    public int? Y { get; set; }

    /// <summary>
    ///   Width according to the document resolution
    /// </summary>
    /// <value>Width according to the document resolution</value>
    [DataMember(Name = "Width", EmitDefaultValue = false)]
    public int? Width { get; set; }

    /// <summary>
    ///   Height according to the document resolution
    /// </summary>
    /// <value>Height according to the document resolution</value>
    [DataMember(Name = "Height", EmitDefaultValue = false)]
    public int? Height { get; set; }

    /// <summary>
    ///   Returns true if DetailResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of DetailResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DetailResponse other)
    {
      // credit: http://stackoverflow.com/a/10454552/677735
      if (other == null)
        return false;

      return
        (
          Name == other.Name ||
          Name != null &&
          Name.Equals(other.Name)
        ) &&
        (
          Text == other.Text ||
          Text != null &&
          Text.Equals(other.Text)
        ) &&
        (
          Value == other.Value ||
          Value != null &&
          Value.Equals(other.Value)
        ) &&
        (
          Score == other.Score ||
          Score != null &&
          Score.Equals(other.Score)
        ) &&
        (
          X == other.X ||
          X != null &&
          X.Equals(other.X)
        ) &&
        (
          Y == other.Y ||
          Y != null &&
          Y.Equals(other.Y)
        ) &&
        (
          Width == other.Width ||
          Width != null &&
          Width.Equals(other.Width)
        ) &&
        (
          Height == other.Height ||
          Height != null &&
          Height.Equals(other.Height)
        );
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
      sb.Append("class DetailResponse {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
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
      return Equals(obj as DetailResponse);
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
        if (Name != null)
          hash = hash * 59 + Name.GetHashCode();
        if (Text != null)
          hash = hash * 59 + Text.GetHashCode();
        if (Value != null)
          hash = hash * 59 + Value.GetHashCode();
        if (Score != null)
          hash = hash * 59 + Score.GetHashCode();
        if (X != null)
          hash = hash * 59 + X.GetHashCode();
        if (Y != null)
          hash = hash * 59 + Y.GetHashCode();
        if (Width != null)
          hash = hash * 59 + Width.GetHashCode();
        if (Height != null)
          hash = hash * 59 + Height.GetHashCode();
        return hash;
      }
    }
  }
}