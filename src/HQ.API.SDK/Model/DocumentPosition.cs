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

namespace HQSB.API.SDK.Model
{
    /// <summary>
    /// DocumentPosition
    /// </summary>
    [DataContract]
    public partial class DocumentPosition :  IEquatable<DocumentPosition>
    {
        /// <summary>
        /// The type of this position
        /// </summary>
        /// <value>The type of this position</value>
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
            NUMBER_10 = 10
        }

        /// <summary>
        /// The type of this position
        /// </summary>
        /// <value>The type of this position</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPosition" /> class.
        /// </summary>
        /// <param name="IsOptional">Whether this position is optional. Only valid in quotations..</param>
        /// <param name="Text">The position text, as HTML.</param>
        /// <param name="Unit">The position unit.</param>
        /// <param name="Tax">The position tax rate, for example 19%.</param>
        /// <param name="Price">The position price, in the currency of the document.</param>
        /// <param name="Discount">The percentage discount that should be applied to this position sum.</param>
        /// <param name="Margin">The margin thaqt should be applied to this position sum.</param>
        /// <param name="Type">The type of this position.</param>
        /// <param name="Order">The order of this position in the document.</param>
        /// <param name="ArticleId">The Id of the article that is associted with this position.</param>
        /// <param name="Article">Article.</param>
        /// <param name="Amount">The amount of this position in this document.</param>
        /// <param name="BookingAccount">The booking account this position is associated with.</param>
        /// <param name="CostCenter1">The cost center 1 this position is associated with.</param>
        /// <param name="CostCenter2">The cost center 2 this position is associated with.</param>
        /// <param name="ExcludeFromEarlyPayment">Whether this position should be excluded from early payment calculations.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public DocumentPosition(bool? IsOptional = null, string Text = null, string Unit = null, double? Tax = null, decimal? Price = null, double? Discount = null, double? Margin = null, TypeEnum? Type = null, int? Order = null, int? ArticleId = null, Article Article = null, double? Amount = null, string BookingAccount = null, string CostCenter1 = null, string CostCenter2 = null, bool? ExcludeFromEarlyPayment = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.IsOptional = IsOptional;
            this.Text = Text;
            this.Unit = Unit;
            this.Tax = Tax;
            this.Price = Price;
            this.Discount = Discount;
            this.Margin = Margin;
            this.Type = Type;
            this.Order = Order;
            this.ArticleId = ArticleId;
            this.Article = Article;
            this.Amount = Amount;
            this.BookingAccount = BookingAccount;
            this.CostCenter1 = CostCenter1;
            this.CostCenter2 = CostCenter2;
            this.ExcludeFromEarlyPayment = ExcludeFromEarlyPayment;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// Whether this position is optional. Only valid in quotations.
        /// </summary>
        /// <value>Whether this position is optional. Only valid in quotations.</value>
        [DataMember(Name="IsOptional", EmitDefaultValue=false)]
        public bool? IsOptional { get; set; }
        /// <summary>
        /// The position text, as HTML
        /// </summary>
        /// <value>The position text, as HTML</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// The position unit
        /// </summary>
        /// <value>The position unit</value>
        [DataMember(Name="Unit", EmitDefaultValue=false)]
        public string Unit { get; set; }
        /// <summary>
        /// The position tax rate, for example 19%
        /// </summary>
        /// <value>The position tax rate, for example 19%</value>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public double? Tax { get; set; }
        /// <summary>
        /// The position price, in the currency of the document
        /// </summary>
        /// <value>The position price, in the currency of the document</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }
        /// <summary>
        /// The percentage discount that should be applied to this position sum
        /// </summary>
        /// <value>The percentage discount that should be applied to this position sum</value>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }
        /// <summary>
        /// The margin thaqt should be applied to this position sum
        /// </summary>
        /// <value>The margin thaqt should be applied to this position sum</value>
        [DataMember(Name="Margin", EmitDefaultValue=false)]
        public double? Margin { get; set; }
        /// <summary>
        /// The order of this position in the document
        /// </summary>
        /// <value>The order of this position in the document</value>
        [DataMember(Name="Order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        /// <summary>
        /// The Id of the article that is associted with this position
        /// </summary>
        /// <value>The Id of the article that is associted with this position</value>
        [DataMember(Name="ArticleId", EmitDefaultValue=false)]
        public int? ArticleId { get; set; }
        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name="Article", EmitDefaultValue=false)]
        public Article Article { get; set; }
        /// <summary>
        /// The amount of this position in this document
        /// </summary>
        /// <value>The amount of this position in this document</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// The booking account this position is associated with
        /// </summary>
        /// <value>The booking account this position is associated with</value>
        [DataMember(Name="BookingAccount", EmitDefaultValue=false)]
        public string BookingAccount { get; set; }
        /// <summary>
        /// The cost center 1 this position is associated with
        /// </summary>
        /// <value>The cost center 1 this position is associated with</value>
        [DataMember(Name="CostCenter1", EmitDefaultValue=false)]
        public string CostCenter1 { get; set; }
        /// <summary>
        /// The cost center 2 this position is associated with
        /// </summary>
        /// <value>The cost center 2 this position is associated with</value>
        [DataMember(Name="CostCenter2", EmitDefaultValue=false)]
        public string CostCenter2 { get; set; }
        /// <summary>
        /// Whether this position should be excluded from early payment calculations
        /// </summary>
        /// <value>Whether this position should be excluded from early payment calculations</value>
        [DataMember(Name="ExcludeFromEarlyPayment", EmitDefaultValue=false)]
        public bool? ExcludeFromEarlyPayment { get; set; }
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
            sb.Append("class DocumentPosition {\n");
            sb.Append("  IsOptional: ").Append(IsOptional).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Margin: ").Append(Margin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BookingAccount: ").Append(BookingAccount).Append("\n");
            sb.Append("  CostCenter1: ").Append(CostCenter1).Append("\n");
            sb.Append("  CostCenter2: ").Append(CostCenter2).Append("\n");
            sb.Append("  ExcludeFromEarlyPayment: ").Append(ExcludeFromEarlyPayment).Append("\n");
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
            return this.Equals(obj as DocumentPosition);
        }

        /// <summary>
        /// Returns true if DocumentPosition instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentPosition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsOptional == other.IsOptional ||
                    this.IsOptional != null &&
                    this.IsOptional.Equals(other.IsOptional)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.Unit == other.Unit ||
                    this.Unit != null &&
                    this.Unit.Equals(other.Unit)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Margin == other.Margin ||
                    this.Margin != null &&
                    this.Margin.Equals(other.Margin)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.ArticleId == other.ArticleId ||
                    this.ArticleId != null &&
                    this.ArticleId.Equals(other.ArticleId)
                ) && 
                (
                    this.Article == other.Article ||
                    this.Article != null &&
                    this.Article.Equals(other.Article)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.BookingAccount == other.BookingAccount ||
                    this.BookingAccount != null &&
                    this.BookingAccount.Equals(other.BookingAccount)
                ) && 
                (
                    this.CostCenter1 == other.CostCenter1 ||
                    this.CostCenter1 != null &&
                    this.CostCenter1.Equals(other.CostCenter1)
                ) && 
                (
                    this.CostCenter2 == other.CostCenter2 ||
                    this.CostCenter2 != null &&
                    this.CostCenter2.Equals(other.CostCenter2)
                ) && 
                (
                    this.ExcludeFromEarlyPayment == other.ExcludeFromEarlyPayment ||
                    this.ExcludeFromEarlyPayment != null &&
                    this.ExcludeFromEarlyPayment.Equals(other.ExcludeFromEarlyPayment)
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
                if (this.IsOptional != null)
                    hash = hash * 59 + this.IsOptional.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Unit != null)
                    hash = hash * 59 + this.Unit.GetHashCode();
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Margin != null)
                    hash = hash * 59 + this.Margin.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.ArticleId != null)
                    hash = hash * 59 + this.ArticleId.GetHashCode();
                if (this.Article != null)
                    hash = hash * 59 + this.Article.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.BookingAccount != null)
                    hash = hash * 59 + this.BookingAccount.GetHashCode();
                if (this.CostCenter1 != null)
                    hash = hash * 59 + this.CostCenter1.GetHashCode();
                if (this.CostCenter2 != null)
                    hash = hash * 59 + this.CostCenter2.GetHashCode();
                if (this.ExcludeFromEarlyPayment != null)
                    hash = hash * 59 + this.ExcludeFromEarlyPayment.GetHashCode();
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
