/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.39
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// Paginated Relationship List
    /// </summary>
    [DataContract(Name = "relationships")]
    public partial class ClientRelationships : IEquatable<ClientRelationships>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRelationships" /> class.
        /// </summary>
        /// <param name="nextPageToken">The opaque token to provide in a subsequent request to get the next page. It is the empty string iff this is the last page..</param>
        /// <param name="relationTuples">relationTuples.</param>
        public ClientRelationships(string nextPageToken = default(string), List<ClientRelationship> relationTuples = default(List<ClientRelationship>))
        {
            this.NextPageToken = nextPageToken;
            this.RelationTuples = relationTuples;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The opaque token to provide in a subsequent request to get the next page. It is the empty string iff this is the last page.
        /// </summary>
        /// <value>The opaque token to provide in a subsequent request to get the next page. It is the empty string iff this is the last page.</value>
        [DataMember(Name = "next_page_token", EmitDefaultValue = false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Gets or Sets RelationTuples
        /// </summary>
        [DataMember(Name = "relation_tuples", EmitDefaultValue = false)]
        public List<ClientRelationship> RelationTuples { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientRelationships {\n");
            sb.Append("  NextPageToken: ").Append(NextPageToken).Append("\n");
            sb.Append("  RelationTuples: ").Append(RelationTuples).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientRelationships);
        }

        /// <summary>
        /// Returns true if ClientRelationships instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientRelationships to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientRelationships input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextPageToken == input.NextPageToken ||
                    (this.NextPageToken != null &&
                    this.NextPageToken.Equals(input.NextPageToken))
                ) && 
                (
                    this.RelationTuples == input.RelationTuples ||
                    this.RelationTuples != null &&
                    input.RelationTuples != null &&
                    this.RelationTuples.SequenceEqual(input.RelationTuples)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NextPageToken != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageToken.GetHashCode();
                }
                if (this.RelationTuples != null)
                {
                    hashCode = (hashCode * 59) + this.RelationTuples.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
