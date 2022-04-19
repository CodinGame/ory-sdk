/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.168
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody {
    /// CSRFToken is the anti-CSRF token
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// Method  Should be set to \"webauthn\" when trying to add, update, or remove a webAuthn pairing.
    #[serde(rename = "method")]
    pub method: String,
    /// The identity's traits
    #[serde(rename = "traits")]
    pub traits: serde_json::Value,
    /// Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
    #[serde(rename = "webauthn_register", skip_serializing_if = "Option::is_none")]
    pub webauthn_register: Option<String>,
    /// Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
    #[serde(rename = "webauthn_register_displayname", skip_serializing_if = "Option::is_none")]
    pub webauthn_register_displayname: Option<String>,
}

impl SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody {
    pub fn new(method: String, traits: serde_json::Value) -> SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody {
        SubmitSelfServiceRegistrationFlowWithWebAuthnMethodBody {
            csrf_token: None,
            method,
            traits,
            webauthn_register: None,
            webauthn_register_displayname: None,
        }
    }
}


