/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.5
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct SelfServiceError {
    /// CreatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    #[serde(rename = "error", skip_serializing_if = "Option::is_none")]
    pub error: Option<serde_json::Value>,
    #[serde(rename = "id")]
    pub id: String,
    /// UpdatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
}

impl SelfServiceError {
    pub fn new(id: String) -> SelfServiceError {
        SelfServiceError {
            created_at: None,
            error: None,
            id,
            updated_at: None,
        }
    }
}


