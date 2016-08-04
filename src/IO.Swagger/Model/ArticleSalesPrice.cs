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
    /// ArticleSalesPrice
    /// </summary>
    [DataContract]
    public partial class ArticleSalesPrice :  IEquatable<ArticleSalesPrice>
    {
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
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
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 2,
            
            /// <summary>
            /// Enum NUMBER_3 for 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 3,
            
            /// <summary>
            /// Enum NUMBER_4 for 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 4,
            
            /// <summary>
            /// Enum NUMBER_5 for 5
            /// </summary>
            [EnumMember(Value = "5")]
            NUMBER_5 = 5,
            
            /// <summary>
            /// Enum NUMBER_6 for 6
            /// </summary>
            [EnumMember(Value = "6")]
            NUMBER_6 = 6,
            
            /// <summary>
            /// Enum NUMBER_7 for 7
            /// </summary>
            [EnumMember(Value = "7")]
            NUMBER_7 = 7,
            
            /// <summary>
            /// Enum NUMBER_8 for 8
            /// </summary>
            [EnumMember(Value = "8")]
            NUMBER_8 = 8,
            
            /// <summary>
            /// Enum NUMBER_9 for 9
            /// </summary>
            [EnumMember(Value = "9")]
            NUMBER_9 = 9,
            
            /// <summary>
            /// Enum NUMBER_10 for 10
            /// </summary>
            [EnumMember(Value = "10")]
            NUMBER_10 = 10,
            
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 11,
            
            /// <summary>
            /// Enum NUMBER_12 for 12
            /// </summary>
            [EnumMember(Value = "12")]
            NUMBER_12 = 12,
            
            /// <summary>
            /// Enum NUMBER_13 for 13
            /// </summary>
            [EnumMember(Value = "13")]
            NUMBER_13 = 13,
            
            /// <summary>
            /// Enum NUMBER_14 for 14
            /// </summary>
            [EnumMember(Value = "14")]
            NUMBER_14 = 14,
            
            /// <summary>
            /// Enum NUMBER_15 for 15
            /// </summary>
            [EnumMember(Value = "15")]
            NUMBER_15 = 15,
            
            /// <summary>
            /// Enum NUMBER_16 for 16
            /// </summary>
            [EnumMember(Value = "16")]
            NUMBER_16 = 16,
            
            /// <summary>
            /// Enum NUMBER_17 for 17
            /// </summary>
            [EnumMember(Value = "17")]
            NUMBER_17 = 17,
            
            /// <summary>
            /// Enum NUMBER_18 for 18
            /// </summary>
            [EnumMember(Value = "18")]
            NUMBER_18 = 18,
            
            /// <summary>
            /// Enum NUMBER_19 for 19
            /// </summary>
            [EnumMember(Value = "19")]
            NUMBER_19 = 19,
            
            /// <summary>
            /// Enum NUMBER_20 for 20
            /// </summary>
            [EnumMember(Value = "20")]
            NUMBER_20 = 20,
            
            /// <summary>
            /// Enum NUMBER_21 for 21
            /// </summary>
            [EnumMember(Value = "21")]
            NUMBER_21 = 21,
            
            /// <summary>
            /// Enum NUMBER_22 for 22
            /// </summary>
            [EnumMember(Value = "22")]
            NUMBER_22 = 22,
            
            /// <summary>
            /// Enum NUMBER_23 for 23
            /// </summary>
            [EnumMember(Value = "23")]
            NUMBER_23 = 23,
            
            /// <summary>
            /// Enum NUMBER_24 for 24
            /// </summary>
            [EnumMember(Value = "24")]
            NUMBER_24 = 24,
            
            /// <summary>
            /// Enum NUMBER_25 for 25
            /// </summary>
            [EnumMember(Value = "25")]
            NUMBER_25 = 25,
            
            /// <summary>
            /// Enum NUMBER_26 for 26
            /// </summary>
            [EnumMember(Value = "26")]
            NUMBER_26 = 26,
            
            /// <summary>
            /// Enum NUMBER_27 for 27
            /// </summary>
            [EnumMember(Value = "27")]
            NUMBER_27 = 27,
            
            /// <summary>
            /// Enum NUMBER_28 for 28
            /// </summary>
            [EnumMember(Value = "28")]
            NUMBER_28 = 28,
            
            /// <summary>
            /// Enum NUMBER_29 for 29
            /// </summary>
            [EnumMember(Value = "29")]
            NUMBER_29 = 29,
            
            /// <summary>
            /// Enum NUMBER_30 for 30
            /// </summary>
            [EnumMember(Value = "30")]
            NUMBER_30 = 30,
            
            /// <summary>
            /// Enum NUMBER_31 for 31
            /// </summary>
            [EnumMember(Value = "31")]
            NUMBER_31 = 31,
            
            /// <summary>
            /// Enum NUMBER_32 for 32
            /// </summary>
            [EnumMember(Value = "32")]
            NUMBER_32 = 32
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="Currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleSalesPrice" /> class.
        /// </summary>
        /// <param name="Price">Price.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="TaxRate">TaxRate.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Unit">Unit.</param>
        /// <param name="ArticleId">ArticleId.</param>
        /// <param name="ArticleDiscounts">ArticleDiscounts.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public ArticleSalesPrice(double? Price = null, CurrencyEnum? Currency = null, double? TaxRate = null, double? Amount = null, string Unit = null, int? ArticleId = null, List<ArticleDiscount> ArticleDiscounts = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.Price = Price;
            this.Currency = Currency;
            this.TaxRate = TaxRate;
            this.Amount = Amount;
            this.Unit = Unit;
            this.ArticleId = ArticleId;
            this.ArticleDiscounts = ArticleDiscounts;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }
        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="TaxRate", EmitDefaultValue=false)]
        public double? TaxRate { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }
        /// <summary>
        /// Gets or Sets ArticleId
        /// </summary>
        [DataMember(Name="ArticleId", EmitDefaultValue=false)]
        public int? ArticleId { get; set; }
        /// <summary>
        /// Gets or Sets ArticleDiscounts
        /// </summary>
        [DataMember(Name="ArticleDiscounts", EmitDefaultValue=false)]
        public List<ArticleDiscount> ArticleDiscounts { get; set; }
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
            sb.Append("class ArticleSalesPrice {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
            sb.Append("  ArticleDiscounts: ").Append(ArticleDiscounts).Append("\n");
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
            return this.Equals(obj as ArticleSalesPrice);
        }

        /// <summary>
        /// Returns true if ArticleSalesPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of ArticleSalesPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleSalesPrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.TaxRate == other.TaxRate ||
                    this.TaxRate != null &&
                    this.TaxRate.Equals(other.TaxRate)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
                ) && 
                (
                    this.ArticleId == other.ArticleId ||
                    this.ArticleId != null &&
                    this.ArticleId.Equals(other.ArticleId)
                ) && 
                (
                    this.ArticleDiscounts == other.ArticleDiscounts ||
                    this.ArticleDiscounts != null &&
                    this.ArticleDiscounts.SequenceEqual(other.ArticleDiscounts)
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
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.TaxRate != null)
                    hash = hash * 59 + this.TaxRate.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();
                if (this.ArticleId != null)
                    hash = hash * 59 + this.ArticleId.GetHashCode();
                if (this.ArticleDiscounts != null)
                    hash = hash * 59 + this.ArticleDiscounts.GetHashCode();
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