/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.86
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// Version struct for Version
type Version struct {
	// Version is the service's version.
	Version *string `json:"version,omitempty"`
}

// NewVersion instantiates a new Version object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewVersion() *Version {
	this := Version{}
	return &this
}

// NewVersionWithDefaults instantiates a new Version object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewVersionWithDefaults() *Version {
	this := Version{}
	return &this
}

// GetVersion returns the Version field value if set, zero value otherwise.
func (o *Version) GetVersion() string {
	if o == nil || o.Version == nil {
		var ret string
		return ret
	}
	return *o.Version
}

// GetVersionOk returns a tuple with the Version field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *Version) GetVersionOk() (*string, bool) {
	if o == nil || o.Version == nil {
		return nil, false
	}
	return o.Version, true
}

// HasVersion returns a boolean if a field has been set.
func (o *Version) HasVersion() bool {
	if o != nil && o.Version != nil {
		return true
	}

	return false
}

// SetVersion gets a reference to the given string and assigns it to the Version field.
func (o *Version) SetVersion(v string) {
	o.Version = &v
}

func (o Version) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Version != nil {
		toSerialize["version"] = o.Version
	}
	return json.Marshal(toSerialize)
}

type NullableVersion struct {
	value *Version
	isSet bool
}

func (v NullableVersion) Get() *Version {
	return v.value
}

func (v *NullableVersion) Set(val *Version) {
	v.value = val
	v.isSet = true
}

func (v NullableVersion) IsSet() bool {
	return v.isSet
}

func (v *NullableVersion) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableVersion(val *Version) *NullableVersion {
	return &NullableVersion{value: val, isSet: true}
}

func (v NullableVersion) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableVersion) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


