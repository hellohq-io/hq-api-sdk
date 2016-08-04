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
    /// ContactPerson
    /// </summary>
    [DataContract]
    public partial class ContactPerson :  IEquatable<ContactPerson>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPerson" /> class.
        /// </summary>
        /// <param name="FirstName">The name of this company type.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Position">Position.</param>
        /// <param name="CompanyId">CompanyId.</param>
        /// <param name="PhoneLandline">PhoneLandline.</param>
        /// <param name="PhoneMobile">PhoneMobile.</param>
        /// <param name="Salutation">Salutation.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Language">Language.</param>
        /// <param name="DefaultAddressId">DefaultAddressId.</param>
        /// <param name="DefaultAddress">The default address of this contact person.</param>
        /// <param name="CustomFields">The customfields associated with this contact person.</param>
        /// <param name="Company">Company.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public ContactPerson(string FirstName = null, string LastName = null, string Position = null, int? CompanyId = null, string PhoneLandline = null, string PhoneMobile = null, string Salutation = null, string Title = null, string Language = null, int? DefaultAddressId = null, CompanyAddress DefaultAddress = null, List<CustomField> CustomFields = null, Company Company = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
            this.CompanyId = CompanyId;
            this.PhoneLandline = PhoneLandline;
            this.PhoneMobile = PhoneMobile;
            this.Salutation = Salutation;
            this.Title = Title;
            this.Language = Language;
            this.DefaultAddressId = DefaultAddressId;
            this.DefaultAddress = DefaultAddress;
            this.CustomFields = CustomFields;
            this.Company = Company;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// The name of this company type
        /// </summary>
        /// <value>The name of this company type</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="Position", EmitDefaultValue=false)]
        public string Position { get; set; }
        /// <summary>
        /// Gets or Sets CompanyId
        /// </summary>
        [DataMember(Name="CompanyId", EmitDefaultValue=false)]
        public int? CompanyId { get; set; }
        /// <summary>
        /// Gets or Sets PhoneLandline
        /// </summary>
        [DataMember(Name="PhoneLandline", EmitDefaultValue=false)]
        public string PhoneLandline { get; set; }
        /// <summary>
        /// Gets or Sets PhoneMobile
        /// </summary>
        [DataMember(Name="PhoneMobile", EmitDefaultValue=false)]
        public string PhoneMobile { get; set; }
        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name="Salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="Language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets DefaultAddressId
        /// </summary>
        [DataMember(Name="DefaultAddressId", EmitDefaultValue=false)]
        public int? DefaultAddressId { get; set; }
        /// <summary>
        /// The default address of this contact person
        /// </summary>
        /// <value>The default address of this contact person</value>
        [DataMember(Name="DefaultAddress", EmitDefaultValue=false)]
        public CompanyAddress DefaultAddress { get; set; }
        /// <summary>
        /// The customfields associated with this contact person
        /// </summary>
        /// <value>The customfields associated with this contact person</value>
        [DataMember(Name="CustomFields", EmitDefaultValue=false)]
        public List<CustomField> CustomFields { get; set; }
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public Company Company { get; set; }
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
            sb.Append("class ContactPerson {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  PhoneLandline: ").Append(PhoneLandline).Append("\n");
            sb.Append("  PhoneMobile: ").Append(PhoneMobile).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  DefaultAddressId: ").Append(DefaultAddressId).Append("\n");
            sb.Append("  DefaultAddress: ").Append(DefaultAddress).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(obj as ContactPerson);
        }

        /// <summary>
        /// Returns true if ContactPerson instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactPerson other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.PhoneLandline == other.PhoneLandline ||
                    this.PhoneLandline != null &&
                    this.PhoneLandline.Equals(other.PhoneLandline)
                ) && 
                (
                    this.PhoneMobile == other.PhoneMobile ||
                    this.PhoneMobile != null &&
                    this.PhoneMobile.Equals(other.PhoneMobile)
                ) && 
                (
                    this.Salutation == other.Salutation ||
                    this.Salutation != null &&
                    this.Salutation.Equals(other.Salutation)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.DefaultAddressId == other.DefaultAddressId ||
                    this.DefaultAddressId != null &&
                    this.DefaultAddressId.Equals(other.DefaultAddressId)
                ) && 
                (
                    this.DefaultAddress == other.DefaultAddress ||
                    this.DefaultAddress != null &&
                    this.DefaultAddress.Equals(other.DefaultAddress)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.PhoneLandline != null)
                    hash = hash * 59 + this.PhoneLandline.GetHashCode();
                if (this.PhoneMobile != null)
                    hash = hash * 59 + this.PhoneMobile.GetHashCode();
                if (this.Salutation != null)
                    hash = hash * 59 + this.Salutation.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.DefaultAddressId != null)
                    hash = hash * 59 + this.DefaultAddressId.GetHashCode();
                if (this.DefaultAddress != null)
                    hash = hash * 59 + this.DefaultAddress.GetHashCode();
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
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
