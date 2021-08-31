/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.5
 * Contact: hi@ory.sh
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
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosPluginSettings
    /// </summary>
    [DataContract(Name = "PluginSettings")]
    public partial class KratosPluginSettings : IEquatable<KratosPluginSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPluginSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosPluginSettings()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosPluginSettings" /> class.
        /// </summary>
        /// <param name="args">args (required).</param>
        /// <param name="devices">devices (required).</param>
        /// <param name="env">env (required).</param>
        /// <param name="mounts">mounts (required).</param>
        public KratosPluginSettings(List<string> args = default(List<string>), List<KratosPluginDevice> devices = default(List<KratosPluginDevice>), List<string> env = default(List<string>), List<KratosPluginMount> mounts = default(List<KratosPluginMount>))
        {
            // to ensure "args" is required (not null)
            this.Args = args ?? throw new ArgumentNullException("args is a required property for KratosPluginSettings and cannot be null");
            // to ensure "devices" is required (not null)
            this.Devices = devices ?? throw new ArgumentNullException("devices is a required property for KratosPluginSettings and cannot be null");
            // to ensure "env" is required (not null)
            this.Env = env ?? throw new ArgumentNullException("env is a required property for KratosPluginSettings and cannot be null");
            // to ensure "mounts" is required (not null)
            this.Mounts = mounts ?? throw new ArgumentNullException("mounts is a required property for KratosPluginSettings and cannot be null");
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// args
        /// </summary>
        /// <value>args</value>
        [DataMember(Name = "Args", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// devices
        /// </summary>
        /// <value>devices</value>
        [DataMember(Name = "Devices", IsRequired = true, EmitDefaultValue = false)]
        public List<KratosPluginDevice> Devices { get; set; }

        /// <summary>
        /// env
        /// </summary>
        /// <value>env</value>
        [DataMember(Name = "Env", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Env { get; set; }

        /// <summary>
        /// mounts
        /// </summary>
        /// <value>mounts</value>
        [DataMember(Name = "Mounts", IsRequired = true, EmitDefaultValue = false)]
        public List<KratosPluginMount> Mounts { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class KratosPluginSettings {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
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
            return this.Equals(input as KratosPluginSettings);
        }

        /// <summary>
        /// Returns true if KratosPluginSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosPluginSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosPluginSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
                ) && 
                (
                    this.Env == input.Env ||
                    this.Env != null &&
                    input.Env != null &&
                    this.Env.SequenceEqual(input.Env)
                ) && 
                (
                    this.Mounts == input.Mounts ||
                    this.Mounts != null &&
                    input.Mounts != null &&
                    this.Mounts.SequenceEqual(input.Mounts)
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
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Devices != null)
                    hashCode = hashCode * 59 + this.Devices.GetHashCode();
                if (this.Env != null)
                    hashCode = hashCode * 59 + this.Env.GetHashCode();
                if (this.Mounts != null)
                    hashCode = hashCode * 59 + this.Mounts.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
