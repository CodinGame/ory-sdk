/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * API version: v0.38.23-beta.1
 * Contact: hi@ory.am
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// Rule struct for Rule
type Rule struct {
	// Authenticators is a list of authentication handlers that will try and authenticate the provided credentials. Authenticators are checked iteratively from index 0 to n and if the first authenticator to return a positive result will be the one used.  If you want the rule to first check a specific authenticator  before \"falling back\" to others, have that authenticator as the first item in the array.
	Authenticators []RuleHandler `json:"authenticators,omitempty"`
	Authorizer *RuleHandler `json:"authorizer,omitempty"`
	// Description is a human readable description of this rule.
	Description *string `json:"description,omitempty"`
	// ID is the unique id of the rule. It can be at most 190 characters long, but the layout of the ID is up to you. You will need this ID later on to update or delete the rule.
	Id *string `json:"id,omitempty"`
	Match *RuleMatch `json:"match,omitempty"`
	// Mutators is a list of mutation handlers that transform the HTTP request. A common use case is generating a new set of credentials (e.g. JWT) which then will be forwarded to the upstream server.  Mutations are performed iteratively from index 0 to n and should all succeed in order for the HTTP request to be forwarded.
	Mutators []RuleHandler `json:"mutators,omitempty"`
	Upstream *Upstream `json:"upstream,omitempty"`
}

// NewRule instantiates a new Rule object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewRule() *Rule {
	this := Rule{}
	return &this
}

// NewRuleWithDefaults instantiates a new Rule object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewRuleWithDefaults() *Rule {
	this := Rule{}
	return &this
}

// GetAuthenticators returns the Authenticators field value if set, zero value otherwise.
func (o *Rule) GetAuthenticators() []RuleHandler {
	if o == nil || o.Authenticators == nil {
		var ret []RuleHandler
		return ret
	}
	return o.Authenticators
}

// GetAuthenticatorsOk returns a tuple with the Authenticators field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetAuthenticatorsOk() ([]RuleHandler, bool) {
	if o == nil || o.Authenticators == nil {
		return nil, false
	}
	return o.Authenticators, true
}

// HasAuthenticators returns a boolean if a field has been set.
func (o *Rule) HasAuthenticators() bool {
	if o != nil && o.Authenticators != nil {
		return true
	}

	return false
}

// SetAuthenticators gets a reference to the given []RuleHandler and assigns it to the Authenticators field.
func (o *Rule) SetAuthenticators(v []RuleHandler) {
	o.Authenticators = v
}

// GetAuthorizer returns the Authorizer field value if set, zero value otherwise.
func (o *Rule) GetAuthorizer() RuleHandler {
	if o == nil || o.Authorizer == nil {
		var ret RuleHandler
		return ret
	}
	return *o.Authorizer
}

// GetAuthorizerOk returns a tuple with the Authorizer field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetAuthorizerOk() (*RuleHandler, bool) {
	if o == nil || o.Authorizer == nil {
		return nil, false
	}
	return o.Authorizer, true
}

// HasAuthorizer returns a boolean if a field has been set.
func (o *Rule) HasAuthorizer() bool {
	if o != nil && o.Authorizer != nil {
		return true
	}

	return false
}

// SetAuthorizer gets a reference to the given RuleHandler and assigns it to the Authorizer field.
func (o *Rule) SetAuthorizer(v RuleHandler) {
	o.Authorizer = &v
}

// GetDescription returns the Description field value if set, zero value otherwise.
func (o *Rule) GetDescription() string {
	if o == nil || o.Description == nil {
		var ret string
		return ret
	}
	return *o.Description
}

// GetDescriptionOk returns a tuple with the Description field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetDescriptionOk() (*string, bool) {
	if o == nil || o.Description == nil {
		return nil, false
	}
	return o.Description, true
}

// HasDescription returns a boolean if a field has been set.
func (o *Rule) HasDescription() bool {
	if o != nil && o.Description != nil {
		return true
	}

	return false
}

// SetDescription gets a reference to the given string and assigns it to the Description field.
func (o *Rule) SetDescription(v string) {
	o.Description = &v
}

// GetId returns the Id field value if set, zero value otherwise.
func (o *Rule) GetId() string {
	if o == nil || o.Id == nil {
		var ret string
		return ret
	}
	return *o.Id
}

// GetIdOk returns a tuple with the Id field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetIdOk() (*string, bool) {
	if o == nil || o.Id == nil {
		return nil, false
	}
	return o.Id, true
}

// HasId returns a boolean if a field has been set.
func (o *Rule) HasId() bool {
	if o != nil && o.Id != nil {
		return true
	}

	return false
}

// SetId gets a reference to the given string and assigns it to the Id field.
func (o *Rule) SetId(v string) {
	o.Id = &v
}

// GetMatch returns the Match field value if set, zero value otherwise.
func (o *Rule) GetMatch() RuleMatch {
	if o == nil || o.Match == nil {
		var ret RuleMatch
		return ret
	}
	return *o.Match
}

// GetMatchOk returns a tuple with the Match field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetMatchOk() (*RuleMatch, bool) {
	if o == nil || o.Match == nil {
		return nil, false
	}
	return o.Match, true
}

// HasMatch returns a boolean if a field has been set.
func (o *Rule) HasMatch() bool {
	if o != nil && o.Match != nil {
		return true
	}

	return false
}

// SetMatch gets a reference to the given RuleMatch and assigns it to the Match field.
func (o *Rule) SetMatch(v RuleMatch) {
	o.Match = &v
}

// GetMutators returns the Mutators field value if set, zero value otherwise.
func (o *Rule) GetMutators() []RuleHandler {
	if o == nil || o.Mutators == nil {
		var ret []RuleHandler
		return ret
	}
	return o.Mutators
}

// GetMutatorsOk returns a tuple with the Mutators field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetMutatorsOk() ([]RuleHandler, bool) {
	if o == nil || o.Mutators == nil {
		return nil, false
	}
	return o.Mutators, true
}

// HasMutators returns a boolean if a field has been set.
func (o *Rule) HasMutators() bool {
	if o != nil && o.Mutators != nil {
		return true
	}

	return false
}

// SetMutators gets a reference to the given []RuleHandler and assigns it to the Mutators field.
func (o *Rule) SetMutators(v []RuleHandler) {
	o.Mutators = v
}

// GetUpstream returns the Upstream field value if set, zero value otherwise.
func (o *Rule) GetUpstream() Upstream {
	if o == nil || o.Upstream == nil {
		var ret Upstream
		return ret
	}
	return *o.Upstream
}

// GetUpstreamOk returns a tuple with the Upstream field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Rule) GetUpstreamOk() (*Upstream, bool) {
	if o == nil || o.Upstream == nil {
		return nil, false
	}
	return o.Upstream, true
}

// HasUpstream returns a boolean if a field has been set.
func (o *Rule) HasUpstream() bool {
	if o != nil && o.Upstream != nil {
		return true
	}

	return false
}

// SetUpstream gets a reference to the given Upstream and assigns it to the Upstream field.
func (o *Rule) SetUpstream(v Upstream) {
	o.Upstream = &v
}

func (o Rule) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Authenticators != nil {
		toSerialize["authenticators"] = o.Authenticators
	}
	if o.Authorizer != nil {
		toSerialize["authorizer"] = o.Authorizer
	}
	if o.Description != nil {
		toSerialize["description"] = o.Description
	}
	if o.Id != nil {
		toSerialize["id"] = o.Id
	}
	if o.Match != nil {
		toSerialize["match"] = o.Match
	}
	if o.Mutators != nil {
		toSerialize["mutators"] = o.Mutators
	}
	if o.Upstream != nil {
		toSerialize["upstream"] = o.Upstream
	}
	return json.Marshal(toSerialize)
}

type NullableRule struct {
	value *Rule
	isSet bool
}

func (v NullableRule) Get() *Rule {
	return v.value
}

func (v *NullableRule) Set(val *Rule) {
	v.value = val
	v.isSet = true
}

func (v NullableRule) IsSet() bool {
	return v.isSet
}

func (v *NullableRule) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableRule(val *Rule) *NullableRule {
	return &NullableRule{value: val, isSet: true}
}

func (v NullableRule) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableRule) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


