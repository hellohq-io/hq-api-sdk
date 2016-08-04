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
    /// CompanyAddress
    /// </summary>
    [DataContract]
    public partial class CompanyAddress :  IEquatable<CompanyAddress>
    {
        /// <summary>
        /// The document type this address should be used as a standard for
        /// </summary>
        /// <value>The document type this address should be used as a standard for</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StandardForDocumentTypeEnum
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
            NUMBER_14 = 14
        }

        /// <summary>
        /// The document type this address should be used as a standard for
        /// </summary>
        /// <value>The document type this address should be used as a standard for</value>
        [DataMember(Name="StandardForDocumentType", EmitDefaultValue=false)]
        public StandardForDocumentTypeEnum? StandardForDocumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyAddress" /> class.
        /// </summary>
        /// <param name="City">The city of this address.</param>
        /// <param name="Street">The street name of this address.</param>
        /// <param name="HouseNumber">The house number of this address.</param>
        /// <param name="ZipCode">The ZIP or Postal Code of this address.</param>
        /// <param name="AddressLine2">The secondary address line, c/o details, etc..</param>
        /// <param name="Description">The description of this address.</param>
        /// <param name="Country">The country of this address.</param>
        /// <param name="Phone">The phone number of this address.</param>
        /// <param name="Fax">The fax number of this address.</param>
        /// <param name="Email">The email address of this address.</param>
        /// <param name="Website">The website of this address.</param>
        /// <param name="IsStandard">Whether this address is the standard address of a company.</param>
        /// <param name="StandardForDocumentType">The document type this address should be used as a standard for.</param>
        /// <param name="Id">The unique identifier of this entity.</param>
        /// <param name="CreatedBy">The id of the user who created this entity.</param>
        /// <param name="UpdatedBy">The id of the last user who modified this entity.</param>
        /// <param name="CreatedOn">The date and time this entity was created, in UTC.</param>
        /// <param name="UpdatedOn">The last date and time this entity was updated, in UTC.</param>
        public CompanyAddress(string City = null, string Street = null, string HouseNumber = null, string ZipCode = null, string AddressLine2 = null, string Description = null, string Country = null, string Phone = null, string Fax = null, string Email = null, string Website = null, bool? IsStandard = null, StandardForDocumentTypeEnum? StandardForDocumentType = null, int? Id = null, int? CreatedBy = null, int? UpdatedBy = null, DateTime? CreatedOn = null, DateTime? UpdatedOn = null)
        {
            this.City = City;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.ZipCode = ZipCode;
            this.AddressLine2 = AddressLine2;
            this.Description = Description;
            this.Country = Country;
            this.Phone = Phone;
            this.Fax = Fax;
            this.Email = Email;
            this.Website = Website;
            this.IsStandard = IsStandard;
            this.StandardForDocumentType = StandardForDocumentType;
            this.Id = Id;
            this.CreatedBy = CreatedBy;
            this.UpdatedBy = UpdatedBy;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
        }
        
        /// <summary>
        /// The city of this address
        /// </summary>
        /// <value>The city of this address</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// The street name of this address
        /// </summary>
        /// <value>The street name of this address</value>
        [DataMember(Name="Street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// The house number of this address
        /// </summary>
        /// <value>The house number of this address</value>
        [DataMember(Name="HouseNumber", EmitDefaultValue=false)]
        public string HouseNumber { get; set; }
        /// <summary>
        /// The ZIP or Postal Code of this address
        /// </summary>
        /// <value>The ZIP or Postal Code of this address</value>
        [DataMember(Name="ZipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }
        /// <summary>
        /// The secondary address line, c/o details, etc.
        /// </summary>
        /// <value>The secondary address line, c/o details, etc.</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// The description of this address
        /// </summary>
        /// <value>The description of this address</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The country of this address
        /// </summary>
        /// <value>The country of this address</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// The phone number of this address
        /// </summary>
        /// <value>The phone number of this address</value>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// The fax number of this address
        /// </summary>
        /// <value>The fax number of this address</value>
        [DataMember(Name="Fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
        /// <summary>
        /// The email address of this address
        /// </summary>
        /// <value>The email address of this address</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The website of this address
        /// </summary>
        /// <value>The website of this address</value>
        [DataMember(Name="Website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Whether this address is the standard address of a company
        /// </summary>
        /// <value>Whether this address is the standard address of a company</value>
        [DataMember(Name="IsStandard", EmitDefaultValue=false)]
        public bool? IsStandard { get; set; }
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
            sb.Append("class CompanyAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  IsStandard: ").Append(IsStandard).Append("\n");
            sb.Append("  StandardForDocumentType: ").Append(StandardForDocumentType).Append("\n");
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
            return this.Equals(obj as CompanyAddress);
        }

        /// <summary>
        /// Returns true if CompanyAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.HouseNumber == other.HouseNumber ||
                    this.HouseNumber != null &&
                    this.HouseNumber.Equals(other.HouseNumber)
                ) && 
                (
                    this.ZipCode == other.ZipCode ||
                    this.ZipCode != null &&
                    this.ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.IsStandard == other.IsStandard ||
                    this.IsStandard != null &&
                    this.IsStandard.Equals(other.IsStandard)
                ) && 
                (
                    this.StandardForDocumentType == other.StandardForDocumentType ||
                    this.StandardForDocumentType != null &&
                    this.StandardForDocumentType.Equals(other.StandardForDocumentType)
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
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.HouseNumber != null)
                    hash = hash * 59 + this.HouseNumber.GetHashCode();
                if (this.ZipCode != null)
                    hash = hash * 59 + this.ZipCode.GetHashCode();
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.IsStandard != null)
                    hash = hash * 59 + this.IsStandard.GetHashCode();
                if (this.StandardForDocumentType != null)
                    hash = hash * 59 + this.StandardForDocumentType.GetHashCode();
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
