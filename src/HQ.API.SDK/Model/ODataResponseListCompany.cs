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
    /// ODataResponseListCompany
    /// </summary>
    [DataContract]
    public partial class ODataResponseListCompany :  IEquatable<ODataResponseListCompany>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataResponseListCompany" /> class.
        /// </summary>
        /// <param name="OdataContext">OdataContext.</param>
        /// <param name="Value">Value.</param>
        public ODataResponseListCompany(string OdataContext = null, List<Company> Value = null)
        {
            this.OdataContext = OdataContext;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets OdataContext
        /// </summary>
        [DataMember(Name="@odata.context", EmitDefaultValue=false)]
        public string OdataContext { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public List<Company> Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ODataResponseListCompany {\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ODataResponseListCompany);
        }

        /// <summary>
        /// Returns true if ODataResponseListCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of ODataResponseListCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ODataResponseListCompany other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OdataContext == other.OdataContext ||
                    this.OdataContext != null &&
                    this.OdataContext.Equals(other.OdataContext)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.SequenceEqual(other.Value)
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
                if (this.OdataContext != null)
                    hash = hash * 59 + this.OdataContext.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
