/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.1
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// IntrospectedOAuth2Token : Introspection contains an access token's session data as specified by [IETF RFC 7662](https://tools.ietf.org/html/rfc7662)



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct IntrospectedOAuth2Token {
    /// Active is a boolean indicator of whether or not the presented token is currently active.  The specifics of a token's \"active\" state will vary depending on the implementation of the authorization server and the information it keeps about its tokens, but a \"true\" value return for the \"active\" property will generally indicate that a given token has been issued by this authorization server, has not been revoked by the resource owner, and is within its given time window of validity (e.g., after its issuance time and before its expiration time).
    #[serde(rename = "active")]
    pub active: bool,
    /// Audience contains a list of the token's intended audiences.
    #[serde(rename = "aud", skip_serializing_if = "Option::is_none")]
    pub aud: Option<Vec<String>>,
    /// ID is aclient identifier for the OAuth 2.0 client that requested this token.
    #[serde(rename = "client_id", skip_serializing_if = "Option::is_none")]
    pub client_id: Option<String>,
    /// Expires at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token will expire.
    #[serde(rename = "exp", skip_serializing_if = "Option::is_none")]
    pub exp: Option<i64>,
    /// Extra is arbitrary data set by the session.
    #[serde(rename = "ext", skip_serializing_if = "Option::is_none")]
    pub ext: Option<::std::collections::HashMap<String, serde_json::Value>>,
    /// Issued at is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token was originally issued.
    #[serde(rename = "iat", skip_serializing_if = "Option::is_none")]
    pub iat: Option<i64>,
    /// IssuerURL is a string representing the issuer of this token
    #[serde(rename = "iss", skip_serializing_if = "Option::is_none")]
    pub iss: Option<String>,
    /// NotBefore is an integer timestamp, measured in the number of seconds since January 1 1970 UTC, indicating when this token is not to be used before.
    #[serde(rename = "nbf", skip_serializing_if = "Option::is_none")]
    pub nbf: Option<i64>,
    /// ObfuscatedSubject is set when the subject identifier algorithm was set to \"pairwise\" during authorization. It is the `sub` value of the ID Token that was issued.
    #[serde(rename = "obfuscated_subject", skip_serializing_if = "Option::is_none")]
    pub obfuscated_subject: Option<String>,
    /// Scope is a JSON string containing a space-separated list of scopes associated with this token.
    #[serde(rename = "scope", skip_serializing_if = "Option::is_none")]
    pub scope: Option<String>,
    /// Subject of the token, as defined in JWT [RFC7519]. Usually a machine-readable identifier of the resource owner who authorized this token.
    #[serde(rename = "sub", skip_serializing_if = "Option::is_none")]
    pub sub: Option<String>,
    /// TokenType is the introspected token's type, typically `Bearer`.
    #[serde(rename = "token_type", skip_serializing_if = "Option::is_none")]
    pub token_type: Option<String>,
    /// TokenUse is the introspected token's use, for example `access_token` or `refresh_token`.
    #[serde(rename = "token_use", skip_serializing_if = "Option::is_none")]
    pub token_use: Option<String>,
    /// Username is a human-readable identifier for the resource owner who authorized this token.
    #[serde(rename = "username", skip_serializing_if = "Option::is_none")]
    pub username: Option<String>,
}


impl IntrospectedOAuth2Token {
    /// Introspection contains an access token's session data as specified by [IETF RFC 7662](https://tools.ietf.org/html/rfc7662)
    pub fn new(active: bool) -> IntrospectedOAuth2Token {
        IntrospectedOAuth2Token {
                active,
                aud: None,
                client_id: None,
                exp: None,
                ext: None,
                iat: None,
                iss: None,
                nbf: None,
                obfuscated_subject: None,
                scope: None,
                sub: None,
                token_type: None,
                token_use: None,
                username: None,
        }
    }
}


