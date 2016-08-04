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
    /// DocumentCondition
    /// </summary>
    [DataContract]
    public partial class DocumentCondition :  IEquatable<DocumentCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentCondition" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Text">Text.</param>
        /// <param name="TimeInDays">TimeInDays.</param>
        /// <param name="WarningDays">WarningDays.</param>
        /// <param name="ReminderDays">ReminderDays.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public DocumentCondition(string Name = null, string Text = null, int? TimeInDays = null, int? WarningDays = null, int? ReminderDays = null, string Language = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.Name = Name;
            this.Text = Text;
            this.TimeInDays = TimeInDays;
            this.WarningDays = WarningDays;
            this.ReminderDays = ReminderDays;
            this.Language = Language;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets TimeInDays
        /// </summary>
        [DataMember(Name="TimeInDays", EmitDefaultValue=false)]
        public int? TimeInDays { get; set; }
        /// <summary>
        /// Gets or Sets WarningDays
        /// </summary>
        [DataMember(Name="WarningDays", EmitDefaultValue=false)]
        public int? WarningDays { get; set; }
        /// <summary>
        /// Gets or Sets ReminderDays
        /// </summary>
        [DataMember(Name="ReminderDays", EmitDefaultValue=false)]
        public int? ReminderDays { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }
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
            sb.Append("class DocumentCondition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TimeInDays: ").Append(TimeInDays).Append("\n");
            sb.Append("  WarningDays: ").Append(WarningDays).Append("\n");
            sb.Append("  ReminderDays: ").Append(ReminderDays).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(obj as DocumentCondition);
        }

        /// <summary>
        /// Returns true if DocumentCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.TimeInDays == other.TimeInDays ||
                    this.TimeInDays != null &&
                    this.TimeInDays.Equals(other.TimeInDays)
                ) && 
                (
                    this.WarningDays == other.WarningDays ||
                    this.WarningDays != null &&
                    this.WarningDays.Equals(other.WarningDays)
                ) && 
                (
                    this.ReminderDays == other.ReminderDays ||
                    this.ReminderDays != null &&
                    this.ReminderDays.Equals(other.ReminderDays)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.TimeInDays != null)
                    hash = hash * 59 + this.TimeInDays.GetHashCode();
                if (this.WarningDays != null)
                    hash = hash * 59 + this.WarningDays.GetHashCode();
                if (this.ReminderDays != null)
                    hash = hash * 59 + this.ReminderDays.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
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
