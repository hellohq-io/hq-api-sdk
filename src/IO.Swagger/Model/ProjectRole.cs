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
    /// ProjectRole
    /// </summary>
    [DataContract]
    public partial class ProjectRole :  IEquatable<ProjectRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRole" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="RightLevel">RightLevel.</param>
        /// <param name="ProjectTemplateId">ProjectTemplateId.</param>
        /// <param name="IsRequired">IsRequired.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public ProjectRole(string Name = null, int? RightLevel = null, int? ProjectTemplateId = null, bool? IsRequired = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.Name = Name;
            this.RightLevel = RightLevel;
            this.ProjectTemplateId = ProjectTemplateId;
            this.IsRequired = IsRequired;
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
        /// Gets or Sets RightLevel
        /// </summary>
        [DataMember(Name="RightLevel", EmitDefaultValue=false)]
        public int? RightLevel { get; set; }
        /// <summary>
        /// Gets or Sets ProjectTemplateId
        /// </summary>
        [DataMember(Name="ProjectTemplateId", EmitDefaultValue=false)]
        public int? ProjectTemplateId { get; set; }
        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="IsRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }
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
            sb.Append("class ProjectRole {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RightLevel: ").Append(RightLevel).Append("\n");
            sb.Append("  ProjectTemplateId: ").Append(ProjectTemplateId).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
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
            return this.Equals(obj as ProjectRole);
        }

        /// <summary>
        /// Returns true if ProjectRole instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectRole other)
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
                    this.RightLevel == other.RightLevel ||
                    this.RightLevel != null &&
                    this.RightLevel.Equals(other.RightLevel)
                ) && 
                (
                    this.ProjectTemplateId == other.ProjectTemplateId ||
                    this.ProjectTemplateId != null &&
                    this.ProjectTemplateId.Equals(other.ProjectTemplateId)
                ) && 
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
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
                if (this.RightLevel != null)
                    hash = hash * 59 + this.RightLevel.GetHashCode();
                if (this.ProjectTemplateId != null)
                    hash = hash * 59 + this.ProjectTemplateId.GetHashCode();
                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();
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