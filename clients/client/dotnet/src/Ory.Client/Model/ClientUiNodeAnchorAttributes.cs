/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.4.8
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
    /// ClientUiNodeAnchorAttributes
    /// </summary>
    [DataContract(Name = "uiNodeAnchorAttributes")]
    public partial class ClientUiNodeAnchorAttributes : IEquatable<ClientUiNodeAnchorAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAnchorAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUiNodeAnchorAttributes()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAnchorAttributes" /> class.
        /// </summary>
        /// <param name="href">The link&#39;s href (destination) URL.  format: uri (required).</param>
        /// <param name="id">A unique identifier (required).</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;. (required).</param>
        /// <param name="title">title (required).</param>
        public ClientUiNodeAnchorAttributes(string href = default(string), string id = default(string), string nodeType = default(string), ClientUiText title = default(ClientUiText))
        {
            // to ensure "href" is required (not null)
            if (href == null) {
                throw new ArgumentNullException("href is a required property for ClientUiNodeAnchorAttributes and cannot be null");
            }
            this.Href = href;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for ClientUiNodeAnchorAttributes and cannot be null");
            }
            this.Id = id;
            // to ensure "nodeType" is required (not null)
            if (nodeType == null) {
                throw new ArgumentNullException("nodeType is a required property for ClientUiNodeAnchorAttributes and cannot be null");
            }
            this.NodeType = nodeType;
            // to ensure "title" is required (not null)
            if (title == null) {
                throw new ArgumentNullException("title is a required property for ClientUiNodeAnchorAttributes and cannot be null");
            }
            this.Title = title;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The link&#39;s href (destination) URL.  format: uri
        /// </summary>
        /// <value>The link&#39;s href (destination) URL.  format: uri</value>
        [DataMember(Name = "href", IsRequired = true, EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// A unique identifier
        /// </summary>
        /// <value>A unique identifier</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;.
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;a\&quot;.</value>
        [DataMember(Name = "node_type", IsRequired = true, EmitDefaultValue = false)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public ClientUiText Title { get; set; }

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
            sb.Append("class ClientUiNodeAnchorAttributes {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ClientUiNodeAnchorAttributes);
        }

        /// <summary>
        /// Returns true if ClientUiNodeAnchorAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientUiNodeAnchorAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientUiNodeAnchorAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.NodeType != null)
                {
                    hashCode = (hashCode * 59) + this.NodeType.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
