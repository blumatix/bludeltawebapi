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
    /// LineItemGroupResponse
    /// </summary>
    [DataContract]
    public partial class LineItemGroupResponse :  IEquatable<LineItemGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemGroupResponse" /> class.
        /// </summary>
        /// <param name="Description">Description text of the line item.</param>
        /// <param name="Quantity">Quantity (number of single units) of the line item.</param>
        /// <param name="UnitPrice">Single unit price of the line item.</param>
        /// <param name="LineItemAmount">Total amount of the line item.</param>
        /// <param name="Score">Scored probability. Value between zero and one..</param>
        /// <param name="X">X-Position according to the document resolution.</param>
        /// <param name="Y">Y-Position according to the document resolution.</param>
        /// <param name="Width">Width according to the document resolution.</param>
        /// <param name="Height">Height according to the document resolution.</param>
        public LineItemGroupResponse(DetailResponse Description = default(DetailResponse), DetailResponse Quantity = default(DetailResponse), DetailResponse UnitPrice = default(DetailResponse), DetailResponse LineItemAmount = default(DetailResponse), double? Score = default(double?), int? X = default(int?), int? Y = default(int?), int? Width = default(int?), int? Height = default(int?))
        {
            this.Description = Description;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.LineItemAmount = LineItemAmount;
            this.Score = Score;
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }
        
        /// <summary>
        /// Description text of the line item
        /// </summary>
        /// <value>Description text of the line item</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public DetailResponse Description { get; set; }

        /// <summary>
        /// Quantity (number of single units) of the line item
        /// </summary>
        /// <value>Quantity (number of single units) of the line item</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public DetailResponse Quantity { get; set; }

        /// <summary>
        /// Single unit price of the line item
        /// </summary>
        /// <value>Single unit price of the line item</value>
        [DataMember(Name="UnitPrice", EmitDefaultValue=false)]
        public DetailResponse UnitPrice { get; set; }

        /// <summary>
        /// Total amount of the line item
        /// </summary>
        /// <value>Total amount of the line item</value>
        [DataMember(Name="LineItemAmount", EmitDefaultValue=false)]
        public DetailResponse LineItemAmount { get; set; }

        /// <summary>
        /// Scored probability. Value between zero and one.
        /// </summary>
        /// <value>Scored probability. Value between zero and one.</value>
        [DataMember(Name="Score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// X-Position according to the document resolution
        /// </summary>
        /// <value>X-Position according to the document resolution</value>
        [DataMember(Name="X", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Y-Position according to the document resolution
        /// </summary>
        /// <value>Y-Position according to the document resolution</value>
        [DataMember(Name="Y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Width according to the document resolution
        /// </summary>
        /// <value>Width according to the document resolution</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Height according to the document resolution
        /// </summary>
        /// <value>Height according to the document resolution</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemGroupResponse {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  LineItemAmount: ").Append(LineItemAmount).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(obj as LineItemGroupResponse);
        }

        /// <summary>
        /// Returns true if LineItemGroupResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LineItemGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemGroupResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.LineItemAmount == other.LineItemAmount ||
                    this.LineItemAmount != null &&
                    this.LineItemAmount.Equals(other.LineItemAmount)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.X == other.X ||
                    this.X != null &&
                    this.X.Equals(other.X)
                ) && 
                (
                    this.Y == other.Y ||
                    this.Y != null &&
                    this.Y.Equals(other.Y)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.LineItemAmount != null)
                    hash = hash * 59 + this.LineItemAmount.GetHashCode();
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                if (this.X != null)
                    hash = hash * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hash = hash * 59 + this.Y.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
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
