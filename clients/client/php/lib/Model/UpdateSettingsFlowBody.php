<?php
/**
 * UpdateSettingsFlowBody
 *
 * PHP version 7.3
 *
 * @category Class
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.
 *
 * The version of the OpenAPI document: v1.1.1
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 * OpenAPI Generator version: 5.4.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace Ory\Client\Model;

use \ArrayAccess;
use \Ory\Client\ObjectSerializer;

/**
 * UpdateSettingsFlowBody Class Doc Comment
 *
 * @category Class
 * @description Update Settings Flow Request Body
 * @package  Ory\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<TKey, TValue>
 * @template TKey int|null
 * @template TValue mixed|null
 */
class UpdateSettingsFlowBody implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = 'method';

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'updateSettingsFlowBody';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'csrfToken' => 'string',
        'method' => 'string',
        'password' => 'string',
        'traits' => 'object',
        'flow' => 'string',
        'link' => 'string',
        'unlink' => 'string',
        'totpCode' => 'string',
        'totpUnlink' => 'bool',
        'webauthnRegister' => 'string',
        'webauthnRegisterDisplayname' => 'string',
        'webauthnRemove' => 'string',
        'lookupSecretConfirm' => 'bool',
        'lookupSecretDisable' => 'bool',
        'lookupSecretRegenerate' => 'bool',
        'lookupSecretReveal' => 'bool'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'csrfToken' => null,
        'method' => null,
        'password' => null,
        'traits' => null,
        'flow' => null,
        'link' => null,
        'unlink' => null,
        'totpCode' => null,
        'totpUnlink' => null,
        'webauthnRegister' => null,
        'webauthnRegisterDisplayname' => null,
        'webauthnRemove' => null,
        'lookupSecretConfirm' => null,
        'lookupSecretDisable' => null,
        'lookupSecretRegenerate' => null,
        'lookupSecretReveal' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'csrfToken' => 'csrf_token',
        'method' => 'method',
        'password' => 'password',
        'traits' => 'traits',
        'flow' => 'flow',
        'link' => 'link',
        'unlink' => 'unlink',
        'totpCode' => 'totp_code',
        'totpUnlink' => 'totp_unlink',
        'webauthnRegister' => 'webauthn_register',
        'webauthnRegisterDisplayname' => 'webauthn_register_displayname',
        'webauthnRemove' => 'webauthn_remove',
        'lookupSecretConfirm' => 'lookup_secret_confirm',
        'lookupSecretDisable' => 'lookup_secret_disable',
        'lookupSecretRegenerate' => 'lookup_secret_regenerate',
        'lookupSecretReveal' => 'lookup_secret_reveal'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'csrfToken' => 'setCsrfToken',
        'method' => 'setMethod',
        'password' => 'setPassword',
        'traits' => 'setTraits',
        'flow' => 'setFlow',
        'link' => 'setLink',
        'unlink' => 'setUnlink',
        'totpCode' => 'setTotpCode',
        'totpUnlink' => 'setTotpUnlink',
        'webauthnRegister' => 'setWebauthnRegister',
        'webauthnRegisterDisplayname' => 'setWebauthnRegisterDisplayname',
        'webauthnRemove' => 'setWebauthnRemove',
        'lookupSecretConfirm' => 'setLookupSecretConfirm',
        'lookupSecretDisable' => 'setLookupSecretDisable',
        'lookupSecretRegenerate' => 'setLookupSecretRegenerate',
        'lookupSecretReveal' => 'setLookupSecretReveal'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'csrfToken' => 'getCsrfToken',
        'method' => 'getMethod',
        'password' => 'getPassword',
        'traits' => 'getTraits',
        'flow' => 'getFlow',
        'link' => 'getLink',
        'unlink' => 'getUnlink',
        'totpCode' => 'getTotpCode',
        'totpUnlink' => 'getTotpUnlink',
        'webauthnRegister' => 'getWebauthnRegister',
        'webauthnRegisterDisplayname' => 'getWebauthnRegisterDisplayname',
        'webauthnRemove' => 'getWebauthnRemove',
        'lookupSecretConfirm' => 'getLookupSecretConfirm',
        'lookupSecretDisable' => 'getLookupSecretDisable',
        'lookupSecretRegenerate' => 'getLookupSecretRegenerate',
        'lookupSecretReveal' => 'getLookupSecretReveal'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['csrfToken'] = $data['csrfToken'] ?? null;
        $this->container['method'] = $data['method'] ?? null;
        $this->container['password'] = $data['password'] ?? null;
        $this->container['traits'] = $data['traits'] ?? null;
        $this->container['flow'] = $data['flow'] ?? null;
        $this->container['link'] = $data['link'] ?? null;
        $this->container['unlink'] = $data['unlink'] ?? null;
        $this->container['totpCode'] = $data['totpCode'] ?? null;
        $this->container['totpUnlink'] = $data['totpUnlink'] ?? null;
        $this->container['webauthnRegister'] = $data['webauthnRegister'] ?? null;
        $this->container['webauthnRegisterDisplayname'] = $data['webauthnRegisterDisplayname'] ?? null;
        $this->container['webauthnRemove'] = $data['webauthnRemove'] ?? null;
        $this->container['lookupSecretConfirm'] = $data['lookupSecretConfirm'] ?? null;
        $this->container['lookupSecretDisable'] = $data['lookupSecretDisable'] ?? null;
        $this->container['lookupSecretRegenerate'] = $data['lookupSecretRegenerate'] ?? null;
        $this->container['lookupSecretReveal'] = $data['lookupSecretReveal'] ?? null;

        // Initialize discriminator property with the model name.
        $this->container['method'] = static::$openAPIModelName;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['method'] === null) {
            $invalidProperties[] = "'method' can't be null";
        }
        if ($this->container['password'] === null) {
            $invalidProperties[] = "'password' can't be null";
        }
        if ($this->container['traits'] === null) {
            $invalidProperties[] = "'traits' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets csrfToken
     *
     * @return string|null
     */
    public function getCsrfToken()
    {
        return $this->container['csrfToken'];
    }

    /**
     * Sets csrfToken
     *
     * @param string|null $csrfToken CSRFToken is the anti-CSRF token
     *
     * @return self
     */
    public function setCsrfToken($csrfToken)
    {
        $this->container['csrfToken'] = $csrfToken;

        return $this;
    }

    /**
     * Gets method
     *
     * @return string
     */
    public function getMethod()
    {
        return $this->container['method'];
    }

    /**
     * Sets method
     *
     * @param string $method Method  Should be set to \"lookup\" when trying to add, update, or remove a lookup pairing.
     *
     * @return self
     */
    public function setMethod($method)
    {
        $this->container['method'] = $method;

        return $this;
    }

    /**
     * Gets password
     *
     * @return string
     */
    public function getPassword()
    {
        return $this->container['password'];
    }

    /**
     * Sets password
     *
     * @param string $password Password is the updated password
     *
     * @return self
     */
    public function setPassword($password)
    {
        $this->container['password'] = $password;

        return $this;
    }

    /**
     * Gets traits
     *
     * @return object
     */
    public function getTraits()
    {
        return $this->container['traits'];
    }

    /**
     * Sets traits
     *
     * @param object $traits The identity's traits  in: body
     *
     * @return self
     */
    public function setTraits($traits)
    {
        $this->container['traits'] = $traits;

        return $this;
    }

    /**
     * Gets flow
     *
     * @return string|null
     */
    public function getFlow()
    {
        return $this->container['flow'];
    }

    /**
     * Sets flow
     *
     * @param string|null $flow Flow ID is the flow's ID.  in: query
     *
     * @return self
     */
    public function setFlow($flow)
    {
        $this->container['flow'] = $flow;

        return $this;
    }

    /**
     * Gets link
     *
     * @return string|null
     */
    public function getLink()
    {
        return $this->container['link'];
    }

    /**
     * Sets link
     *
     * @param string|null $link Link this provider  Either this or `unlink` must be set.  type: string in: body
     *
     * @return self
     */
    public function setLink($link)
    {
        $this->container['link'] = $link;

        return $this;
    }

    /**
     * Gets unlink
     *
     * @return string|null
     */
    public function getUnlink()
    {
        return $this->container['unlink'];
    }

    /**
     * Sets unlink
     *
     * @param string|null $unlink Unlink this provider  Either this or `link` must be set.  type: string in: body
     *
     * @return self
     */
    public function setUnlink($unlink)
    {
        $this->container['unlink'] = $unlink;

        return $this;
    }

    /**
     * Gets totpCode
     *
     * @return string|null
     */
    public function getTotpCode()
    {
        return $this->container['totpCode'];
    }

    /**
     * Sets totpCode
     *
     * @param string|null $totpCode ValidationTOTP must contain a valid TOTP based on the
     *
     * @return self
     */
    public function setTotpCode($totpCode)
    {
        $this->container['totpCode'] = $totpCode;

        return $this;
    }

    /**
     * Gets totpUnlink
     *
     * @return bool|null
     */
    public function getTotpUnlink()
    {
        return $this->container['totpUnlink'];
    }

    /**
     * Sets totpUnlink
     *
     * @param bool|null $totpUnlink UnlinkTOTP if true will remove the TOTP pairing, effectively removing the credential. This can be used to set up a new TOTP device.
     *
     * @return self
     */
    public function setTotpUnlink($totpUnlink)
    {
        $this->container['totpUnlink'] = $totpUnlink;

        return $this;
    }

    /**
     * Gets webauthnRegister
     *
     * @return string|null
     */
    public function getWebauthnRegister()
    {
        return $this->container['webauthnRegister'];
    }

    /**
     * Sets webauthnRegister
     *
     * @param string|null $webauthnRegister Register a WebAuthn Security Key  It is expected that the JSON returned by the WebAuthn registration process is included here.
     *
     * @return self
     */
    public function setWebauthnRegister($webauthnRegister)
    {
        $this->container['webauthnRegister'] = $webauthnRegister;

        return $this;
    }

    /**
     * Gets webauthnRegisterDisplayname
     *
     * @return string|null
     */
    public function getWebauthnRegisterDisplayname()
    {
        return $this->container['webauthnRegisterDisplayname'];
    }

    /**
     * Sets webauthnRegisterDisplayname
     *
     * @param string|null $webauthnRegisterDisplayname Name of the WebAuthn Security Key to be Added  A human-readable name for the security key which will be added.
     *
     * @return self
     */
    public function setWebauthnRegisterDisplayname($webauthnRegisterDisplayname)
    {
        $this->container['webauthnRegisterDisplayname'] = $webauthnRegisterDisplayname;

        return $this;
    }

    /**
     * Gets webauthnRemove
     *
     * @return string|null
     */
    public function getWebauthnRemove()
    {
        return $this->container['webauthnRemove'];
    }

    /**
     * Sets webauthnRemove
     *
     * @param string|null $webauthnRemove Remove a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.
     *
     * @return self
     */
    public function setWebauthnRemove($webauthnRemove)
    {
        $this->container['webauthnRemove'] = $webauthnRemove;

        return $this;
    }

    /**
     * Gets lookupSecretConfirm
     *
     * @return bool|null
     */
    public function getLookupSecretConfirm()
    {
        return $this->container['lookupSecretConfirm'];
    }

    /**
     * Sets lookupSecretConfirm
     *
     * @param bool|null $lookupSecretConfirm If set to true will save the regenerated lookup secrets
     *
     * @return self
     */
    public function setLookupSecretConfirm($lookupSecretConfirm)
    {
        $this->container['lookupSecretConfirm'] = $lookupSecretConfirm;

        return $this;
    }

    /**
     * Gets lookupSecretDisable
     *
     * @return bool|null
     */
    public function getLookupSecretDisable()
    {
        return $this->container['lookupSecretDisable'];
    }

    /**
     * Sets lookupSecretDisable
     *
     * @param bool|null $lookupSecretDisable Disables this method if true.
     *
     * @return self
     */
    public function setLookupSecretDisable($lookupSecretDisable)
    {
        $this->container['lookupSecretDisable'] = $lookupSecretDisable;

        return $this;
    }

    /**
     * Gets lookupSecretRegenerate
     *
     * @return bool|null
     */
    public function getLookupSecretRegenerate()
    {
        return $this->container['lookupSecretRegenerate'];
    }

    /**
     * Sets lookupSecretRegenerate
     *
     * @param bool|null $lookupSecretRegenerate If set to true will regenerate the lookup secrets
     *
     * @return self
     */
    public function setLookupSecretRegenerate($lookupSecretRegenerate)
    {
        $this->container['lookupSecretRegenerate'] = $lookupSecretRegenerate;

        return $this;
    }

    /**
     * Gets lookupSecretReveal
     *
     * @return bool|null
     */
    public function getLookupSecretReveal()
    {
        return $this->container['lookupSecretReveal'];
    }

    /**
     * Sets lookupSecretReveal
     *
     * @param bool|null $lookupSecretReveal If set to true will reveal the lookup secrets
     *
     * @return self
     */
    public function setLookupSecretReveal($lookupSecretReveal)
    {
        $this->container['lookupSecretReveal'] = $lookupSecretReveal;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


