=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.1.51
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OryClient::JwkApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'JwkApi' do
  before do
    # run before each test
    @api_instance = OryClient::JwkApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of JwkApi' do
    it 'should create an instance of JwkApi' do
      expect(@api_instance).to be_instance_of(OryClient::JwkApi)
    end
  end

  # unit tests for create_json_web_key_set
  # Create JSON Web Key
  # This endpoint is capable of generating JSON Web Key Sets for you. There a different strategies available, such as symmetric cryptographic keys (HS256, HS512) and asymetric cryptographic keys (RS256, ECDSA). If the specified JSON Web Key Set does not exist, it will be created.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set The JSON Web Key Set ID
  # @param create_json_web_key_set 
  # @param [Hash] opts the optional parameters
  # @return [JsonWebKeySet]
  describe 'create_json_web_key_set test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for delete_json_web_key
  # Delete JSON Web Key
  # Use this endpoint to delete a single JSON Web Key.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set The JSON Web Key Set
  # @param kid The JSON Web Key ID (kid)
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'delete_json_web_key test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for delete_json_web_key_set
  # Delete JSON Web Key Set
  # Use this endpoint to delete a complete JSON Web Key Set and all the keys in that set.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set The JSON Web Key Set
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'delete_json_web_key_set test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_json_web_key
  # Get JSON Web Key
  # This endpoint returns a singular JSON Web Key contained in a set. It is identified by the set and the specific key ID (kid).
  # @param set JSON Web Key Set ID
  # @param kid JSON Web Key ID
  # @param [Hash] opts the optional parameters
  # @return [JsonWebKeySet]
  describe 'get_json_web_key test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_json_web_key_set
  # Retrieve a JSON Web Key Set
  # This endpoint can be used to retrieve JWK Sets stored in ORY Hydra.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set JSON Web Key Set ID
  # @param [Hash] opts the optional parameters
  # @return [JsonWebKeySet]
  describe 'get_json_web_key_set test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for set_json_web_key
  # Set JSON Web Key
  # Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set The JSON Web Key Set ID
  # @param kid JSON Web Key ID
  # @param [Hash] opts the optional parameters
  # @option opts [JsonWebKey] :json_web_key 
  # @return [JsonWebKey]
  describe 'set_json_web_key test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for set_json_web_key_set
  # Update a JSON Web Key Set
  # Use this method if you do not want to let Hydra generate the JWKs for you, but instead save your own.  A JSON Web Key (JWK) is a JavaScript Object Notation (JSON) data structure that represents a cryptographic key. A JWK Set is a JSON data structure that represents a set of JWKs. A JSON Web Key is identified by its set and key id. ORY Hydra uses this functionality to store cryptographic keys used for TLS and JSON Web Tokens (such as OpenID Connect ID tokens), and allows storing user-defined keys as well.
  # @param set The JSON Web Key Set ID
  # @param [Hash] opts the optional parameters
  # @option opts [JsonWebKeySet] :json_web_key_set 
  # @return [JsonWebKeySet]
  describe 'set_json_web_key_set test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
