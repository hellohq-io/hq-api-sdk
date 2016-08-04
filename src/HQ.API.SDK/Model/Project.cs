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
    /// Project
    /// </summary>
    [DataContract]
    public partial class Project :  IEquatable<Project>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="Number">The number of the project.</param>
        /// <param name="Name">The name of the project.</param>
        /// <param name="PlannedStartDate">The planned start date of the project.</param>
        /// <param name="PlannedEndDate">The planned end date of the project.</param>
        /// <param name="Subsystems">The subsystems this project is associated with.</param>
        /// <param name="ProjectTemplateId">The id of the project template.</param>
        /// <param name="ProjectTemplate">The template of this project.</param>
        /// <param name="ProjectStatusId">The id of the project status.</param>
        /// <param name="ProjectStatus">The status of the project.</param>
        /// <param name="CompanyId">The id of the company.</param>
        /// <param name="Company">The company this project is associated with.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public Project(string Number = null, string Name = null, DateTime? PlannedStartDate = null, DateTime? PlannedEndDate = null, List<Subsystem> Subsystems = null, int? ProjectTemplateId = null, ProjectTemplate ProjectTemplate = null, int? ProjectStatusId = null, ProjectStatus ProjectStatus = null, int? CompanyId = null, Company Company = null, List<CustomField> CustomFields = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.Number = Number;
            this.Name = Name;
            this.PlannedStartDate = PlannedStartDate;
            this.PlannedEndDate = PlannedEndDate;
            this.Subsystems = Subsystems;
            this.ProjectTemplateId = ProjectTemplateId;
            this.ProjectTemplate = ProjectTemplate;
            this.ProjectStatusId = ProjectStatusId;
            this.ProjectStatus = ProjectStatus;
            this.CompanyId = CompanyId;
            this.Company = Company;
            this.CustomFields = CustomFields;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// The number of the project
        /// </summary>
        /// <value>The number of the project</value>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public string Number { get; set; }
        /// <summary>
        /// The name of the project
        /// </summary>
        /// <value>The name of the project</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The planned start date of the project
        /// </summary>
        /// <value>The planned start date of the project</value>
        [DataMember(Name="PlannedStartDate", EmitDefaultValue=false)]
        public DateTime? PlannedStartDate { get; set; }
        /// <summary>
        /// The planned end date of the project
        /// </summary>
        /// <value>The planned end date of the project</value>
        [DataMember(Name="PlannedEndDate", EmitDefaultValue=false)]
        public DateTime? PlannedEndDate { get; set; }
        /// <summary>
        /// The subsystems this project is associated with
        /// </summary>
        /// <value>The subsystems this project is associated with</value>
        [DataMember(Name="Subsystems", EmitDefaultValue=false)]
        public List<Subsystem> Subsystems { get; set; }
        /// <summary>
        /// The id of the project template
        /// </summary>
        /// <value>The id of the project template</value>
        [DataMember(Name="ProjectTemplateId", EmitDefaultValue=false)]
        public int? ProjectTemplateId { get; set; }
        /// <summary>
        /// The template of this project
        /// </summary>
        /// <value>The template of this project</value>
        [DataMember(Name="ProjectTemplate", EmitDefaultValue=false)]
        public ProjectTemplate ProjectTemplate { get; set; }
        /// <summary>
        /// The id of the project status
        /// </summary>
        /// <value>The id of the project status</value>
        [DataMember(Name="ProjectStatusId", EmitDefaultValue=false)]
        public int? ProjectStatusId { get; set; }
        /// <summary>
        /// The status of the project
        /// </summary>
        /// <value>The status of the project</value>
        [DataMember(Name="ProjectStatus", EmitDefaultValue=false)]
        public ProjectStatus ProjectStatus { get; set; }
        /// <summary>
        /// The id of the company
        /// </summary>
        /// <value>The id of the company</value>
        [DataMember(Name="CompanyId", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }
        /// <summary>
        /// The company this project is associated with
        /// </summary>
        /// <value>The company this project is associated with</value>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public Company Company { get; set; }
        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="CustomFields", EmitDefaultValue=false)]
        public List<CustomField> CustomFields { get; set; }
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
            sb.Append("class Project {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedStartDate: ").Append(PlannedStartDate).Append("\n");
            sb.Append("  PlannedEndDate: ").Append(PlannedEndDate).Append("\n");
            sb.Append("  Subsystems: ").Append(Subsystems).Append("\n");
            sb.Append("  ProjectTemplateId: ").Append(ProjectTemplateId).Append("\n");
            sb.Append("  ProjectTemplate: ").Append(ProjectTemplate).Append("\n");
            sb.Append("  ProjectStatusId: ").Append(ProjectStatusId).Append("\n");
            sb.Append("  ProjectStatus: ").Append(ProjectStatus).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(obj as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="other">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlannedStartDate == other.PlannedStartDate ||
                    this.PlannedStartDate != null &&
                    this.PlannedStartDate.Equals(other.PlannedStartDate)
                ) && 
                (
                    this.PlannedEndDate == other.PlannedEndDate ||
                    this.PlannedEndDate != null &&
                    this.PlannedEndDate.Equals(other.PlannedEndDate)
                ) && 
                (
                    this.Subsystems == other.Subsystems ||
                    this.Subsystems != null &&
                    this.Subsystems.SequenceEqual(other.Subsystems)
                ) && 
                (
                    this.ProjectTemplateId == other.ProjectTemplateId ||
                    this.ProjectTemplateId != null &&
                    this.ProjectTemplateId.Equals(other.ProjectTemplateId)
                ) && 
                (
                    this.ProjectTemplate == other.ProjectTemplate ||
                    this.ProjectTemplate != null &&
                    this.ProjectTemplate.Equals(other.ProjectTemplate)
                ) && 
                (
                    this.ProjectStatusId == other.ProjectStatusId ||
                    this.ProjectStatusId != null &&
                    this.ProjectStatusId.Equals(other.ProjectStatusId)
                ) && 
                (
                    this.ProjectStatus == other.ProjectStatus ||
                    this.ProjectStatus != null &&
                    this.ProjectStatus.Equals(other.ProjectStatus)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
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
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PlannedStartDate != null)
                    hash = hash * 59 + this.PlannedStartDate.GetHashCode();
                if (this.PlannedEndDate != null)
                    hash = hash * 59 + this.PlannedEndDate.GetHashCode();
                if (this.Subsystems != null)
                    hash = hash * 59 + this.Subsystems.GetHashCode();
                if (this.ProjectTemplateId != null)
                    hash = hash * 59 + this.ProjectTemplateId.GetHashCode();
                if (this.ProjectTemplate != null)
                    hash = hash * 59 + this.ProjectTemplate.GetHashCode();
                if (this.ProjectStatusId != null)
                    hash = hash * 59 + this.ProjectStatusId.GetHashCode();
                if (this.ProjectStatus != null)
                    hash = hash * 59 + this.ProjectStatus.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
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