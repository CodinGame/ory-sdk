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
  # An identity can be a real human, a service, an IoT device - everything that can be described as an \"actor\" in a system.
  class Identity
    # CreatedAt is a helper struct field for gobuffalo.pop.
    attr_accessor :created_at

    # Credentials represents all credentials that can be used for authenticating this identity.
    attr_accessor :credentials

    attr_accessor :id

    # RecoveryAddresses contains all the addresses that can be used to recover an identity.
    attr_accessor :recovery_addresses

    # SchemaID is the ID of the JSON Schema to be used for validating the identity's traits.
    attr_accessor :schema_id

    # SchemaURL is the URL of the endpoint where the identity's traits schema can be fetched from.  format: url
    attr_accessor :schema_url

    attr_accessor :state

    attr_accessor :state_changed_at

    # Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_url`.
    attr_accessor :traits

    # UpdatedAt is a helper struct field for gobuffalo.pop.
    attr_accessor :updated_at

    # VerifiableAddresses contains all the addresses that can be verified by the user.
    attr_accessor :verifiable_addresses

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'created_at' => :'created_at',
        :'credentials' => :'credentials',
        :'id' => :'id',
        :'recovery_addresses' => :'recovery_addresses',
        :'schema_id' => :'schema_id',
        :'schema_url' => :'schema_url',
        :'state' => :'state',
        :'state_changed_at' => :'state_changed_at',
        :'traits' => :'traits',
        :'updated_at' => :'updated_at',
        :'verifiable_addresses' => :'verifiable_addresses'
      }
    end

    # Returns all the JSON keys this model knows about
    def self.acceptable_attributes
      attribute_map.values
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'created_at' => :'Time',
        :'credentials' => :'Hash<String, IdentityCredentials>',
        :'id' => :'String',
        :'recovery_addresses' => :'Array<RecoveryAddress>',
        :'schema_id' => :'String',
        :'schema_url' => :'String',
        :'state' => :'IdentityState',
        :'state_changed_at' => :'Time',
        :'traits' => :'Object',
        :'updated_at' => :'Time',
        :'verifiable_addresses' => :'Array<VerifiableIdentityAddress>'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'traits',
      ])
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `OryClient::Identity` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `OryClient::Identity`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'created_at')
        self.created_at = attributes[:'created_at']
      end

      if attributes.key?(:'credentials')
        if (value = attributes[:'credentials']).is_a?(Hash)
          self.credentials = value
        end
      end

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'recovery_addresses')
        if (value = attributes[:'recovery_addresses']).is_a?(Array)
          self.recovery_addresses = value
        end
      end

      if attributes.key?(:'schema_id')
        self.schema_id = attributes[:'schema_id']
      end

      if attributes.key?(:'schema_url')
        self.schema_url = attributes[:'schema_url']
      end

      if attributes.key?(:'state')
        self.state = attributes[:'state']
      end

      if attributes.key?(:'state_changed_at')
        self.state_changed_at = attributes[:'state_changed_at']
      end

      if attributes.key?(:'traits')
        self.traits = attributes[:'traits']
      end

      if attributes.key?(:'updated_at')
        self.updated_at = attributes[:'updated_at']
      end

      if attributes.key?(:'verifiable_addresses')
        if (value = attributes[:'verifiable_addresses']).is_a?(Array)
          self.verifiable_addresses = value
        end
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @id.nil?
        invalid_properties.push('invalid value for "id", id cannot be nil.')
      end

      if @schema_id.nil?
        invalid_properties.push('invalid value for "schema_id", schema_id cannot be nil.')
      end

      if @schema_url.nil?
        invalid_properties.push('invalid value for "schema_url", schema_url cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @id.nil?
      return false if @schema_id.nil?
      return false if @schema_url.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          created_at == o.created_at &&
          credentials == o.credentials &&
          id == o.id &&
          recovery_addresses == o.recovery_addresses &&
          schema_id == o.schema_id &&
          schema_url == o.schema_url &&
          state == o.state &&
          state_changed_at == o.state_changed_at &&
          traits == o.traits &&
          updated_at == o.updated_at &&
          verifiable_addresses == o.verifiable_addresses
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [created_at, credentials, id, recovery_addresses, schema_id, schema_url, state, state_changed_at, traits, updated_at, verifiable_addresses].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        elsif type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :Time
        Time.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        # models (e.g. Pet) or oneOf
        klass = OryClient.const_get(type)
        klass.respond_to?(:openapi_one_of) ? klass.build(value) : klass.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end

  end

end
