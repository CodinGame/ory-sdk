/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.168
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
    /// ClientAdminCreateIdentityImportCredentialsOidcConfig
    /// </summary>
    [DataContract(Name = "adminCreateIdentityImportCredentialsOidcConfig")]
    public partial class ClientAdminCreateIdentityImportCredentialsOidcConfig : IEquatable<ClientAdminCreateIdentityImportCredentialsOidcConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAdminCreateIdentityImportCredentialsOidcConfig" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="providers">A list of OpenID Connect Providers.</param>
        public ClientAdminCreateIdentityImportCredentialsOidcConfig(ClientAdminCreateIdentityImportCredentialsPasswordConfig config = default(ClientAdminCreateIdentityImportCredentialsPasswordConfig), List<ClientAdminCreateIdentityImportCredentialsOidcProvider> providers = default(List<ClientAdminCreateIdentityImportCredentialsOidcProvider>))
        {
            this.Config = config;
            this.Providers = providers;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public ClientAdminCreateIdentityImportCredentialsPasswordConfig Config { get; set; }

        /// <summary>
        /// A list of OpenID Connect Providers
        /// </summary>
        /// <value>A list of OpenID Connect Providers</value>
        [DataMember(Name = "providers", EmitDefaultValue = false)]
        public List<ClientAdminCreateIdentityImportCredentialsOidcProvider> Providers { get; set; }

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
            sb.Append("class ClientAdminCreateIdentityImportCredentialsOidcConfig {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return this.Equals(input as ClientAdminCreateIdentityImportCredentialsOidcConfig);
        }

        /// <summary>
        /// Returns true if ClientAdminCreateIdentityImportCredentialsOidcConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAdminCreateIdentityImportCredentialsOidcConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAdminCreateIdentityImportCredentialsOidcConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Providers == input.Providers ||
                    this.Providers != null &&
                    input.Providers != null &&
                    this.Providers.SequenceEqual(input.Providers)
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
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.Providers != null)
                {
                    hashCode = (hashCode * 59) + this.Providers.GetHashCode();
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
