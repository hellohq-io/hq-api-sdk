/* 
 * HQ API Entities
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HQ.API.SDK.Model
{
    /// <summary>
    /// ArticleDiscount
    /// </summary>
    [DataContract]
    public partial class ArticleDiscount :  IEquatable<ArticleDiscount>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for 0
            /// </summary>
            [EnumMember(Value = "0")]
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleDiscount" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Threshold">Threshold.</param>
        /// <param name="Type">Type.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="ArticleSalesPriceId">ArticleSalesPriceId.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public ArticleDiscount(double? Value = null, double? Threshold = null, TypeEnum? Type = null, int? CompanyId = null, int? ArticleSalesPriceId = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.Value = Value;
            this.Threshold = Threshold;
            this.Type = Type;
            this.CompanyId = CompanyId;
            this.ArticleSalesPriceId = ArticleSalesPriceId;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public double? Value { get; set; }
        /// <summary>
        /// Gets or Sets Threshold
        /// </summary>
        [DataMember(Name="Threshold", EmitDefaultValue=false)]
        public double? Threshold { get; set; }
        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="CompanyId", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }
        /// <summary>
        /// Gets or Sets ArticleSalesPriceId
        /// </summary>
        [DataMember(Name="ArticleSalesPriceId", EmitDefaultValue=false)]
        public int? ArticleSalesPriceId { get; set; }
        /// <summary>
        /// The unique identifier of this entity
        /// </summary>
        /// <value>The unique identifier of this entity</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// The id of the user who created this entity
        /// </summary>
        /// <value>The id of the user who created this entity</value>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public int? CreatedBy { get; set; }
        /// <summary>
        /// The id of the last user who modified this entity
        /// </summary>
        /// <value>The id of the last user who modified this entity</value>
        [DataMember(Name="UpdatedBy", EmitDefaultValue=false)]
        public int? UpdatedBy { get; set; }
        /// <summary>
        /// The date and time this entity was created, in UTC
        /// </summary>
        /// <value>The date and time this entity was created, in UTC</value>
        [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last date and time this entity was updated, in UTC
        /// </summary>
        /// <value>The last date and time this entity was updated, in UTC</value>
        [DataMember(Name="UpdatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArticleDiscount {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Threshold: ").Append(Threshold).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ArticleSalesPriceId: ").Append(ArticleSalesPriceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
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
            return this.Equals(obj as ArticleDiscount);
        }

        /// <summary>
        /// Returns true if ArticleDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of ArticleDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Threshold == other.Threshold ||
                    this.Threshold != null &&
                    this.Threshold.Equals(other.Threshold)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.ArticleSalesPriceId == other.ArticleSalesPriceId ||
                    this.ArticleSalesPriceId != null &&
                    this.ArticleSalesPriceId.Equals(other.ArticleSalesPriceId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.UpdatedBy == other.UpdatedBy ||
                    this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(other.UpdatedBy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Threshold != null)
                    hash = hash * 59 + this.Threshold.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.ArticleSalesPriceId != null)
                    hash = hash * 59 + this.ArticleSalesPriceId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.UpdatedBy != null)
                    hash = hash * 59 + this.UpdatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
                return hash;
            }
        }
    }

}
