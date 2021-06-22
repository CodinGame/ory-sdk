/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.9
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct InlineResponse200 {
    /// Always \"ok\".
    #[serde(rename = "status")]
    pub status: String,
}

impl InlineResponse200 {
    pub fn new(status: String) -> InlineResponse200 {
        InlineResponse200 {
            status,
        }
    }
}

