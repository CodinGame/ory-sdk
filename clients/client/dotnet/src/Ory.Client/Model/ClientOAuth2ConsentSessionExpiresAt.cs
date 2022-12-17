/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.1
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
    /// ClientOAuth2ConsentSessionExpiresAt
    /// </summary>
    [DataContract(Name = "oAuth2ConsentSession_expires_at")]
    public partial class ClientOAuth2ConsentSessionExpiresAt : IEquatable<ClientOAuth2ConsentSessionExpiresAt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOAuth2ConsentSessionExpiresAt" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="authorizeCode">authorizeCode.</param>
        /// <param name="idToken">idToken.</param>
        /// <param name="parContext">parContext.</param>
        /// <param name="refreshToken">refreshToken.</param>
        public ClientOAuth2ConsentSessionExpiresAt(DateTime accessToken = default(DateTime), DateTime authorizeCode = default(DateTime), DateTime idToken = default(DateTime), DateTime parContext = default(DateTime), DateTime refreshToken = default(DateTime))
        {
            this.AccessToken = accessToken;
            this.AuthorizeCode = authorizeCode;
            this.IdToken = idToken;
            this.ParContext = parContext;
            this.RefreshToken = refreshToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public DateTime AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizeCode
        /// </summary>
        [DataMember(Name = "authorize_code", EmitDefaultValue = false)]
        public DateTime AuthorizeCode { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "id_token", EmitDefaultValue = false)]
        public DateTime IdToken { get; set; }

        /// <summary>
        /// Gets or Sets ParContext
        /// </summary>
        [DataMember(Name = "par_context", EmitDefaultValue = false)]
        public DateTime ParContext { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public DateTime RefreshToken { get; set; }

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
            sb.Append("class ClientOAuth2ConsentSessionExpiresAt {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AuthorizeCode: ").Append(AuthorizeCode).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  ParContext: ").Append(ParContext).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as ClientOAuth2ConsentSessionExpiresAt);
        }

        /// <summary>
        /// Returns true if ClientOAuth2ConsentSessionExpiresAt instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientOAuth2ConsentSessionExpiresAt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientOAuth2ConsentSessionExpiresAt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.AuthorizeCode == input.AuthorizeCode ||
                    (this.AuthorizeCode != null &&
                    this.AuthorizeCode.Equals(input.AuthorizeCode))
                ) && 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.ParContext == input.ParContext ||
                    (this.ParContext != null &&
                    this.ParContext.Equals(input.ParContext))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.AuthorizeCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizeCode.GetHashCode();
                }
                if (this.IdToken != null)
                {
                    hashCode = (hashCode * 59) + this.IdToken.GetHashCode();
                }
                if (this.ParContext != null)
                {
                    hashCode = (hashCode * 59) + this.ParContext.GetHashCode();
                }
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
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
