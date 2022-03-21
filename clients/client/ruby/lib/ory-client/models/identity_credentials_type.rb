=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v0.0.1-alpha.142
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.4.0

=end

require 'date'
require 'time'

module OryClient
  class IdentityCredentialsType
    PASSWORD = "password".freeze
    TOTP = "totp".freeze
    OIDC = "oidc".freeze
    WEBAUTHN = "webauthn".freeze
    LOOKUP_SECRET = "lookup_secret".freeze

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def self.build_from_hash(value)
      new.build_from_hash(value)
    end

    # Builds the enum from string
    # @param [String] The enum value in the form of the string
    # @return [String] The enum value
    def build_from_hash(value)
      constantValues = IdentityCredentialsType.constants.select { |c| IdentityCredentialsType::const_get(c) == value }
      raise "Invalid ENUM value #{value} for class #IdentityCredentialsType" if constantValues.empty?
      value
    end
  end
end
