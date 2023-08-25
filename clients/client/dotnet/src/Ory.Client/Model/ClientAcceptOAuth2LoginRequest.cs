/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.51
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
    /// ClientAcceptOAuth2LoginRequest
    /// </summary>
    [DataContract(Name = "acceptOAuth2LoginRequest")]
    public partial class ClientAcceptOAuth2LoginRequest : IEquatable<ClientAcceptOAuth2LoginRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAcceptOAuth2LoginRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientAcceptOAuth2LoginRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAcceptOAuth2LoginRequest" /> class.
        /// </summary>
        /// <param name="acr">ACR sets the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication..</param>
        /// <param name="amr">amr.</param>
        /// <param name="context">context.</param>
        /// <param name="extendSessionLifespan">Extend OAuth2 authentication session lifespan  If set to &#x60;true&#x60;, the OAuth2 authentication cookie lifespan is extended. This is for example useful if you want the user to be able to use &#x60;prompt&#x3D;none&#x60; continuously.  This value can only be set to &#x60;true&#x60; if the user has an authentication, which is the case if the &#x60;skip&#x60; value is &#x60;true&#x60;..</param>
        /// <param name="forceSubjectIdentifier">ForceSubjectIdentifier forces the \&quot;pairwise\&quot; user ID of the end-user that authenticated. The \&quot;pairwise\&quot; user ID refers to the (Pairwise Identifier Algorithm)[http://openid.net/specs/openid-connect-core-1_0.html#PairwiseAlg] of the OpenID Connect specification. It allows you to set an obfuscated subject (\&quot;user\&quot;) identifier that is unique to the client.  Please note that this changes the user ID on endpoint /userinfo and sub claim of the ID Token. It does not change the sub claim in the OAuth 2.0 Introspection.  Per default, ORY Hydra handles this value with its own algorithm. In case you want to set this yourself you can use this field. Please note that setting this field has no effect if &#x60;pairwise&#x60; is not configured in ORY Hydra or the OAuth 2.0 Client does not expect a pairwise identifier (set via &#x60;subject_type&#x60; key in the client&#39;s configuration).  Please also be aware that ORY Hydra is unable to properly compute this value during authentication. This implies that you have to compute this value on every authentication process (probably depending on the client ID or some other unique value).  If you fail to compute the proper value, then authentication processes which have id_token_hint set might fail..</param>
        /// <param name="identityProviderSessionId">IdentityProviderSessionID is the session ID of the end-user that authenticated. If specified, we will use this value to propagate the logout..</param>
        /// <param name="remember">Remember, if set to true, tells ORY Hydra to remember this user by telling the user agent (browser) to store a cookie with authentication data. If the same user performs another OAuth 2.0 Authorization Request, he/she will not be asked to log in again..</param>
        /// <param name="rememberFor">RememberFor sets how long the authentication should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered for the duration of the browser session (using a session cookie)..</param>
        /// <param name="subject">Subject is the user ID of the end-user that authenticated. (required).</param>
        public ClientAcceptOAuth2LoginRequest(string acr = default(string), List<string> amr = default(List<string>), Object context = default(Object), bool extendSessionLifespan = default(bool), string forceSubjectIdentifier = default(string), string identityProviderSessionId = default(string), bool remember = default(bool), long rememberFor = default(long), string subject = default(string))
        {
            // to ensure "subject" is required (not null)
            if (subject == null) {
                throw new ArgumentNullException("subject is a required property for ClientAcceptOAuth2LoginRequest and cannot be null");
            }
            this.Subject = subject;
            this.Acr = acr;
            this.Amr = amr;
            this.Context = context;
            this.ExtendSessionLifespan = extendSessionLifespan;
            this.ForceSubjectIdentifier = forceSubjectIdentifier;
            this.IdentityProviderSessionId = identityProviderSessionId;
            this.Remember = remember;
            this.RememberFor = rememberFor;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ACR sets the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication.
        /// </summary>
        /// <value>ACR sets the Authentication AuthorizationContext Class Reference value for this authentication session. You can use it to express that, for example, a user authenticated using two factor authentication.</value>
        [DataMember(Name = "acr", EmitDefaultValue = false)]
        public string Acr { get; set; }

        /// <summary>
        /// Gets or Sets Amr
        /// </summary>
        [DataMember(Name = "amr", EmitDefaultValue = false)]
        public List<string> Amr { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public Object Context { get; set; }

        /// <summary>
        /// Extend OAuth2 authentication session lifespan  If set to &#x60;true&#x60;, the OAuth2 authentication cookie lifespan is extended. This is for example useful if you want the user to be able to use &#x60;prompt&#x3D;none&#x60; continuously.  This value can only be set to &#x60;true&#x60; if the user has an authentication, which is the case if the &#x60;skip&#x60; value is &#x60;true&#x60;.
        /// </summary>
        /// <value>Extend OAuth2 authentication session lifespan  If set to &#x60;true&#x60;, the OAuth2 authentication cookie lifespan is extended. This is for example useful if you want the user to be able to use &#x60;prompt&#x3D;none&#x60; continuously.  This value can only be set to &#x60;true&#x60; if the user has an authentication, which is the case if the &#x60;skip&#x60; value is &#x60;true&#x60;.</value>
        [DataMember(Name = "extend_session_lifespan", EmitDefaultValue = true)]
        public bool ExtendSessionLifespan { get; set; }

        /// <summary>
        /// ForceSubjectIdentifier forces the \&quot;pairwise\&quot; user ID of the end-user that authenticated. The \&quot;pairwise\&quot; user ID refers to the (Pairwise Identifier Algorithm)[http://openid.net/specs/openid-connect-core-1_0.html#PairwiseAlg] of the OpenID Connect specification. It allows you to set an obfuscated subject (\&quot;user\&quot;) identifier that is unique to the client.  Please note that this changes the user ID on endpoint /userinfo and sub claim of the ID Token. It does not change the sub claim in the OAuth 2.0 Introspection.  Per default, ORY Hydra handles this value with its own algorithm. In case you want to set this yourself you can use this field. Please note that setting this field has no effect if &#x60;pairwise&#x60; is not configured in ORY Hydra or the OAuth 2.0 Client does not expect a pairwise identifier (set via &#x60;subject_type&#x60; key in the client&#39;s configuration).  Please also be aware that ORY Hydra is unable to properly compute this value during authentication. This implies that you have to compute this value on every authentication process (probably depending on the client ID or some other unique value).  If you fail to compute the proper value, then authentication processes which have id_token_hint set might fail.
        /// </summary>
        /// <value>ForceSubjectIdentifier forces the \&quot;pairwise\&quot; user ID of the end-user that authenticated. The \&quot;pairwise\&quot; user ID refers to the (Pairwise Identifier Algorithm)[http://openid.net/specs/openid-connect-core-1_0.html#PairwiseAlg] of the OpenID Connect specification. It allows you to set an obfuscated subject (\&quot;user\&quot;) identifier that is unique to the client.  Please note that this changes the user ID on endpoint /userinfo and sub claim of the ID Token. It does not change the sub claim in the OAuth 2.0 Introspection.  Per default, ORY Hydra handles this value with its own algorithm. In case you want to set this yourself you can use this field. Please note that setting this field has no effect if &#x60;pairwise&#x60; is not configured in ORY Hydra or the OAuth 2.0 Client does not expect a pairwise identifier (set via &#x60;subject_type&#x60; key in the client&#39;s configuration).  Please also be aware that ORY Hydra is unable to properly compute this value during authentication. This implies that you have to compute this value on every authentication process (probably depending on the client ID or some other unique value).  If you fail to compute the proper value, then authentication processes which have id_token_hint set might fail.</value>
        [DataMember(Name = "force_subject_identifier", EmitDefaultValue = false)]
        public string ForceSubjectIdentifier { get; set; }

        /// <summary>
        /// IdentityProviderSessionID is the session ID of the end-user that authenticated. If specified, we will use this value to propagate the logout.
        /// </summary>
        /// <value>IdentityProviderSessionID is the session ID of the end-user that authenticated. If specified, we will use this value to propagate the logout.</value>
        [DataMember(Name = "identity_provider_session_id", EmitDefaultValue = false)]
        public string IdentityProviderSessionId { get; set; }

        /// <summary>
        /// Remember, if set to true, tells ORY Hydra to remember this user by telling the user agent (browser) to store a cookie with authentication data. If the same user performs another OAuth 2.0 Authorization Request, he/she will not be asked to log in again.
        /// </summary>
        /// <value>Remember, if set to true, tells ORY Hydra to remember this user by telling the user agent (browser) to store a cookie with authentication data. If the same user performs another OAuth 2.0 Authorization Request, he/she will not be asked to log in again.</value>
        [DataMember(Name = "remember", EmitDefaultValue = true)]
        public bool Remember { get; set; }

        /// <summary>
        /// RememberFor sets how long the authentication should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered for the duration of the browser session (using a session cookie).
        /// </summary>
        /// <value>RememberFor sets how long the authentication should be remembered for in seconds. If set to &#x60;0&#x60;, the authorization will be remembered for the duration of the browser session (using a session cookie).</value>
        [DataMember(Name = "remember_for", EmitDefaultValue = false)]
        public long RememberFor { get; set; }

        /// <summary>
        /// Subject is the user ID of the end-user that authenticated.
        /// </summary>
        /// <value>Subject is the user ID of the end-user that authenticated.</value>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

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
            sb.Append("class ClientAcceptOAuth2LoginRequest {\n");
            sb.Append("  Acr: ").Append(Acr).Append("\n");
            sb.Append("  Amr: ").Append(Amr).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ExtendSessionLifespan: ").Append(ExtendSessionLifespan).Append("\n");
            sb.Append("  ForceSubjectIdentifier: ").Append(ForceSubjectIdentifier).Append("\n");
            sb.Append("  IdentityProviderSessionId: ").Append(IdentityProviderSessionId).Append("\n");
            sb.Append("  Remember: ").Append(Remember).Append("\n");
            sb.Append("  RememberFor: ").Append(RememberFor).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as ClientAcceptOAuth2LoginRequest);
        }

        /// <summary>
        /// Returns true if ClientAcceptOAuth2LoginRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAcceptOAuth2LoginRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAcceptOAuth2LoginRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acr == input.Acr ||
                    (this.Acr != null &&
                    this.Acr.Equals(input.Acr))
                ) && 
                (
                    this.Amr == input.Amr ||
                    this.Amr != null &&
                    input.Amr != null &&
                    this.Amr.SequenceEqual(input.Amr)
                ) && 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.ExtendSessionLifespan == input.ExtendSessionLifespan ||
                    this.ExtendSessionLifespan.Equals(input.ExtendSessionLifespan)
                ) && 
                (
                    this.ForceSubjectIdentifier == input.ForceSubjectIdentifier ||
                    (this.ForceSubjectIdentifier != null &&
                    this.ForceSubjectIdentifier.Equals(input.ForceSubjectIdentifier))
                ) && 
                (
                    this.IdentityProviderSessionId == input.IdentityProviderSessionId ||
                    (this.IdentityProviderSessionId != null &&
                    this.IdentityProviderSessionId.Equals(input.IdentityProviderSessionId))
                ) && 
                (
                    this.Remember == input.Remember ||
                    this.Remember.Equals(input.Remember)
                ) && 
                (
                    this.RememberFor == input.RememberFor ||
                    this.RememberFor.Equals(input.RememberFor)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Acr != null)
                {
                    hashCode = (hashCode * 59) + this.Acr.GetHashCode();
                }
                if (this.Amr != null)
                {
                    hashCode = (hashCode * 59) + this.Amr.GetHashCode();
                }
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExtendSessionLifespan.GetHashCode();
                if (this.ForceSubjectIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.ForceSubjectIdentifier.GetHashCode();
                }
                if (this.IdentityProviderSessionId != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityProviderSessionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Remember.GetHashCode();
                hashCode = (hashCode * 59) + this.RememberFor.GetHashCode();
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
