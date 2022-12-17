/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.1
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import sh.ory.JSON;

/**
 * NormalizedProjectRevisionHook
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-12-17T12:47:15.295740778Z[Etc/UTC]")
public class NormalizedProjectRevisionHook {
  public static final String SERIALIZED_NAME_CONFIG_KEY = "config_key";
  @SerializedName(SERIALIZED_NAME_CONFIG_KEY)
  private String configKey;

  public static final String SERIALIZED_NAME_CREATED_AT = "created_at";
  @SerializedName(SERIALIZED_NAME_CREATED_AT)
  private OffsetDateTime createdAt;

  public static final String SERIALIZED_NAME_HOOK = "hook";
  @SerializedName(SERIALIZED_NAME_HOOK)
  private String hook;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_PROJECT_REVISION_ID = "project_revision_id";
  @SerializedName(SERIALIZED_NAME_PROJECT_REVISION_ID)
  private String projectRevisionId;

  public static final String SERIALIZED_NAME_UPDATED_AT = "updated_at";
  @SerializedName(SERIALIZED_NAME_UPDATED_AT)
  private OffsetDateTime updatedAt;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_IN = "web_hook_config_auth_api_key_in";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_IN)
  private String webHookConfigAuthApiKeyIn;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_NAME = "web_hook_config_auth_api_key_name";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_NAME)
  private String webHookConfigAuthApiKeyName;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_VALUE = "web_hook_config_auth_api_key_value";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_API_KEY_VALUE)
  private String webHookConfigAuthApiKeyValue;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_BASIC_AUTH_PASSWORD = "web_hook_config_auth_basic_auth_password";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_BASIC_AUTH_PASSWORD)
  private String webHookConfigAuthBasicAuthPassword;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_BASIC_AUTH_USER = "web_hook_config_auth_basic_auth_user";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_BASIC_AUTH_USER)
  private String webHookConfigAuthBasicAuthUser;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_TYPE = "web_hook_config_auth_type";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_AUTH_TYPE)
  private String webHookConfigAuthType;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_BODY = "web_hook_config_body";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_BODY)
  private String webHookConfigBody;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_CAN_INTERRUPT = "web_hook_config_can_interrupt";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_CAN_INTERRUPT)
  private Boolean webHookConfigCanInterrupt;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_METHOD = "web_hook_config_method";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_METHOD)
  private String webHookConfigMethod;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_RESPONSE_IGNORE = "web_hook_config_response_ignore";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_RESPONSE_IGNORE)
  private Boolean webHookConfigResponseIgnore;

  public static final String SERIALIZED_NAME_WEB_HOOK_CONFIG_URL = "web_hook_config_url";
  @SerializedName(SERIALIZED_NAME_WEB_HOOK_CONFIG_URL)
  private String webHookConfigUrl;

  public NormalizedProjectRevisionHook() {
  }

  
  public NormalizedProjectRevisionHook(
     OffsetDateTime createdAt, 
     OffsetDateTime updatedAt
  ) {
    this();
    this.createdAt = createdAt;
    this.updatedAt = updatedAt;
  }

  public NormalizedProjectRevisionHook configKey(String configKey) {
    
    this.configKey = configKey;
    return this;
  }

   /**
   * The Hooks Config Key
   * @return configKey
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The Hooks Config Key")

  public String getConfigKey() {
    return configKey;
  }


  public void setConfigKey(String configKey) {
    this.configKey = configKey;
  }


   /**
   * The Project&#39;s Revision Creation Date
   * @return createdAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The Project's Revision Creation Date")

  public OffsetDateTime getCreatedAt() {
    return createdAt;
  }




  public NormalizedProjectRevisionHook hook(String hook) {
    
    this.hook = hook;
    return this;
  }

   /**
   * The Hook Type
   * @return hook
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The Hook Type")

  public String getHook() {
    return hook;
  }


  public void setHook(String hook) {
    this.hook = hook;
  }


  public NormalizedProjectRevisionHook id(String id) {
    
    this.id = id;
    return this;
  }

   /**
   * ID of the entry
   * @return id
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "ID of the entry")

  public String getId() {
    return id;
  }


  public void setId(String id) {
    this.id = id;
  }


  public NormalizedProjectRevisionHook projectRevisionId(String projectRevisionId) {
    
    this.projectRevisionId = projectRevisionId;
    return this;
  }

   /**
   * The Revision&#39;s ID this schema belongs to
   * @return projectRevisionId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The Revision's ID this schema belongs to")

  public String getProjectRevisionId() {
    return projectRevisionId;
  }


  public void setProjectRevisionId(String projectRevisionId) {
    this.projectRevisionId = projectRevisionId;
  }


   /**
   * Last Time Project&#39;s Revision was Updated
   * @return updatedAt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Last Time Project's Revision was Updated")

  public OffsetDateTime getUpdatedAt() {
    return updatedAt;
  }




  public NormalizedProjectRevisionHook webHookConfigAuthApiKeyIn(String webHookConfigAuthApiKeyIn) {
    
    this.webHookConfigAuthApiKeyIn = webHookConfigAuthApiKeyIn;
    return this;
  }

   /**
   * Whether to send the API Key in the HTTP Header or as a HTTP Cookie
   * @return webHookConfigAuthApiKeyIn
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "header", value = "Whether to send the API Key in the HTTP Header or as a HTTP Cookie")

  public String getWebHookConfigAuthApiKeyIn() {
    return webHookConfigAuthApiKeyIn;
  }


  public void setWebHookConfigAuthApiKeyIn(String webHookConfigAuthApiKeyIn) {
    this.webHookConfigAuthApiKeyIn = webHookConfigAuthApiKeyIn;
  }


  public NormalizedProjectRevisionHook webHookConfigAuthApiKeyName(String webHookConfigAuthApiKeyName) {
    
    this.webHookConfigAuthApiKeyName = webHookConfigAuthApiKeyName;
    return this;
  }

   /**
   * The name of the api key
   * @return webHookConfigAuthApiKeyName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "X-API-Key", value = "The name of the api key")

  public String getWebHookConfigAuthApiKeyName() {
    return webHookConfigAuthApiKeyName;
  }


  public void setWebHookConfigAuthApiKeyName(String webHookConfigAuthApiKeyName) {
    this.webHookConfigAuthApiKeyName = webHookConfigAuthApiKeyName;
  }


  public NormalizedProjectRevisionHook webHookConfigAuthApiKeyValue(String webHookConfigAuthApiKeyValue) {
    
    this.webHookConfigAuthApiKeyValue = webHookConfigAuthApiKeyValue;
    return this;
  }

   /**
   * The value of the api key
   * @return webHookConfigAuthApiKeyValue
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ", value = "The value of the api key")

  public String getWebHookConfigAuthApiKeyValue() {
    return webHookConfigAuthApiKeyValue;
  }


  public void setWebHookConfigAuthApiKeyValue(String webHookConfigAuthApiKeyValue) {
    this.webHookConfigAuthApiKeyValue = webHookConfigAuthApiKeyValue;
  }


  public NormalizedProjectRevisionHook webHookConfigAuthBasicAuthPassword(String webHookConfigAuthBasicAuthPassword) {
    
    this.webHookConfigAuthBasicAuthPassword = webHookConfigAuthBasicAuthPassword;
    return this;
  }

   /**
   * The password to be sent in the HTTP Basic Auth Header
   * @return webHookConfigAuthBasicAuthPassword
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The password to be sent in the HTTP Basic Auth Header")

  public String getWebHookConfigAuthBasicAuthPassword() {
    return webHookConfigAuthBasicAuthPassword;
  }


  public void setWebHookConfigAuthBasicAuthPassword(String webHookConfigAuthBasicAuthPassword) {
    this.webHookConfigAuthBasicAuthPassword = webHookConfigAuthBasicAuthPassword;
  }


  public NormalizedProjectRevisionHook webHookConfigAuthBasicAuthUser(String webHookConfigAuthBasicAuthUser) {
    
    this.webHookConfigAuthBasicAuthUser = webHookConfigAuthBasicAuthUser;
    return this;
  }

   /**
   * The username to be sent in the HTTP Basic Auth Header
   * @return webHookConfigAuthBasicAuthUser
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The username to be sent in the HTTP Basic Auth Header")

  public String getWebHookConfigAuthBasicAuthUser() {
    return webHookConfigAuthBasicAuthUser;
  }


  public void setWebHookConfigAuthBasicAuthUser(String webHookConfigAuthBasicAuthUser) {
    this.webHookConfigAuthBasicAuthUser = webHookConfigAuthBasicAuthUser;
  }


  public NormalizedProjectRevisionHook webHookConfigAuthType(String webHookConfigAuthType) {
    
    this.webHookConfigAuthType = webHookConfigAuthType;
    return this;
  }

   /**
   * HTTP Auth Method to use for the Web-Hook
   * @return webHookConfigAuthType
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "HTTP Auth Method to use for the Web-Hook")

  public String getWebHookConfigAuthType() {
    return webHookConfigAuthType;
  }


  public void setWebHookConfigAuthType(String webHookConfigAuthType) {
    this.webHookConfigAuthType = webHookConfigAuthType;
  }


  public NormalizedProjectRevisionHook webHookConfigBody(String webHookConfigBody) {
    
    this.webHookConfigBody = webHookConfigBody;
    return this;
  }

   /**
   * URI pointing to the JsonNet template used for Web-Hook payload generation. Only used for those HTTP methods, which support HTTP body payloads.
   * @return webHookConfigBody
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "base64://ZnVuY3Rpb24oY3R4KSB7CiAgaWRlbnRpdHlfaWQ6IGlmIGN0eFsiaWRlbnRpdHkiXSAhPSBudWxsIHRoZW4gY3R4LmlkZW50aXR5LmlkLAp9=", value = "URI pointing to the JsonNet template used for Web-Hook payload generation. Only used for those HTTP methods, which support HTTP body payloads.")

  public String getWebHookConfigBody() {
    return webHookConfigBody;
  }


  public void setWebHookConfigBody(String webHookConfigBody) {
    this.webHookConfigBody = webHookConfigBody;
  }


  public NormalizedProjectRevisionHook webHookConfigCanInterrupt(Boolean webHookConfigCanInterrupt) {
    
    this.webHookConfigCanInterrupt = webHookConfigCanInterrupt;
    return this;
  }

   /**
   * If enabled allows the web hook to interrupt / abort the self-service flow. It only applies to certain flows (registration/verification/login/settings) and requires a valid response format.
   * @return webHookConfigCanInterrupt
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "If enabled allows the web hook to interrupt / abort the self-service flow. It only applies to certain flows (registration/verification/login/settings) and requires a valid response format.")

  public Boolean getWebHookConfigCanInterrupt() {
    return webHookConfigCanInterrupt;
  }


  public void setWebHookConfigCanInterrupt(Boolean webHookConfigCanInterrupt) {
    this.webHookConfigCanInterrupt = webHookConfigCanInterrupt;
  }


  public NormalizedProjectRevisionHook webHookConfigMethod(String webHookConfigMethod) {
    
    this.webHookConfigMethod = webHookConfigMethod;
    return this;
  }

   /**
   * The HTTP method to use (GET, POST, etc) for the Web-Hook
   * @return webHookConfigMethod
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "POST", value = "The HTTP method to use (GET, POST, etc) for the Web-Hook")

  public String getWebHookConfigMethod() {
    return webHookConfigMethod;
  }


  public void setWebHookConfigMethod(String webHookConfigMethod) {
    this.webHookConfigMethod = webHookConfigMethod;
  }


  public NormalizedProjectRevisionHook webHookConfigResponseIgnore(Boolean webHookConfigResponseIgnore) {
    
    this.webHookConfigResponseIgnore = webHookConfigResponseIgnore;
    return this;
  }

   /**
   * Whether to ignore the Web Hook response
   * @return webHookConfigResponseIgnore
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Whether to ignore the Web Hook response")

  public Boolean getWebHookConfigResponseIgnore() {
    return webHookConfigResponseIgnore;
  }


  public void setWebHookConfigResponseIgnore(Boolean webHookConfigResponseIgnore) {
    this.webHookConfigResponseIgnore = webHookConfigResponseIgnore;
  }


  public NormalizedProjectRevisionHook webHookConfigUrl(String webHookConfigUrl) {
    
    this.webHookConfigUrl = webHookConfigUrl;
    return this;
  }

   /**
   * The URL the Web-Hook should call
   * @return webHookConfigUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "https://www.example.org/web-hook-listener", value = "The URL the Web-Hook should call")

  public String getWebHookConfigUrl() {
    return webHookConfigUrl;
  }


  public void setWebHookConfigUrl(String webHookConfigUrl) {
    this.webHookConfigUrl = webHookConfigUrl;
  }



  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NormalizedProjectRevisionHook normalizedProjectRevisionHook = (NormalizedProjectRevisionHook) o;
    return Objects.equals(this.configKey, normalizedProjectRevisionHook.configKey) &&
        Objects.equals(this.createdAt, normalizedProjectRevisionHook.createdAt) &&
        Objects.equals(this.hook, normalizedProjectRevisionHook.hook) &&
        Objects.equals(this.id, normalizedProjectRevisionHook.id) &&
        Objects.equals(this.projectRevisionId, normalizedProjectRevisionHook.projectRevisionId) &&
        Objects.equals(this.updatedAt, normalizedProjectRevisionHook.updatedAt) &&
        Objects.equals(this.webHookConfigAuthApiKeyIn, normalizedProjectRevisionHook.webHookConfigAuthApiKeyIn) &&
        Objects.equals(this.webHookConfigAuthApiKeyName, normalizedProjectRevisionHook.webHookConfigAuthApiKeyName) &&
        Objects.equals(this.webHookConfigAuthApiKeyValue, normalizedProjectRevisionHook.webHookConfigAuthApiKeyValue) &&
        Objects.equals(this.webHookConfigAuthBasicAuthPassword, normalizedProjectRevisionHook.webHookConfigAuthBasicAuthPassword) &&
        Objects.equals(this.webHookConfigAuthBasicAuthUser, normalizedProjectRevisionHook.webHookConfigAuthBasicAuthUser) &&
        Objects.equals(this.webHookConfigAuthType, normalizedProjectRevisionHook.webHookConfigAuthType) &&
        Objects.equals(this.webHookConfigBody, normalizedProjectRevisionHook.webHookConfigBody) &&
        Objects.equals(this.webHookConfigCanInterrupt, normalizedProjectRevisionHook.webHookConfigCanInterrupt) &&
        Objects.equals(this.webHookConfigMethod, normalizedProjectRevisionHook.webHookConfigMethod) &&
        Objects.equals(this.webHookConfigResponseIgnore, normalizedProjectRevisionHook.webHookConfigResponseIgnore) &&
        Objects.equals(this.webHookConfigUrl, normalizedProjectRevisionHook.webHookConfigUrl);
  }

  @Override
  public int hashCode() {
    return Objects.hash(configKey, createdAt, hook, id, projectRevisionId, updatedAt, webHookConfigAuthApiKeyIn, webHookConfigAuthApiKeyName, webHookConfigAuthApiKeyValue, webHookConfigAuthBasicAuthPassword, webHookConfigAuthBasicAuthUser, webHookConfigAuthType, webHookConfigBody, webHookConfigCanInterrupt, webHookConfigMethod, webHookConfigResponseIgnore, webHookConfigUrl);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NormalizedProjectRevisionHook {\n");
    sb.append("    configKey: ").append(toIndentedString(configKey)).append("\n");
    sb.append("    createdAt: ").append(toIndentedString(createdAt)).append("\n");
    sb.append("    hook: ").append(toIndentedString(hook)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    projectRevisionId: ").append(toIndentedString(projectRevisionId)).append("\n");
    sb.append("    updatedAt: ").append(toIndentedString(updatedAt)).append("\n");
    sb.append("    webHookConfigAuthApiKeyIn: ").append(toIndentedString(webHookConfigAuthApiKeyIn)).append("\n");
    sb.append("    webHookConfigAuthApiKeyName: ").append(toIndentedString(webHookConfigAuthApiKeyName)).append("\n");
    sb.append("    webHookConfigAuthApiKeyValue: ").append(toIndentedString(webHookConfigAuthApiKeyValue)).append("\n");
    sb.append("    webHookConfigAuthBasicAuthPassword: ").append(toIndentedString(webHookConfigAuthBasicAuthPassword)).append("\n");
    sb.append("    webHookConfigAuthBasicAuthUser: ").append(toIndentedString(webHookConfigAuthBasicAuthUser)).append("\n");
    sb.append("    webHookConfigAuthType: ").append(toIndentedString(webHookConfigAuthType)).append("\n");
    sb.append("    webHookConfigBody: ").append(toIndentedString(webHookConfigBody)).append("\n");
    sb.append("    webHookConfigCanInterrupt: ").append(toIndentedString(webHookConfigCanInterrupt)).append("\n");
    sb.append("    webHookConfigMethod: ").append(toIndentedString(webHookConfigMethod)).append("\n");
    sb.append("    webHookConfigResponseIgnore: ").append(toIndentedString(webHookConfigResponseIgnore)).append("\n");
    sb.append("    webHookConfigUrl: ").append(toIndentedString(webHookConfigUrl)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("config_key");
    openapiFields.add("created_at");
    openapiFields.add("hook");
    openapiFields.add("id");
    openapiFields.add("project_revision_id");
    openapiFields.add("updated_at");
    openapiFields.add("web_hook_config_auth_api_key_in");
    openapiFields.add("web_hook_config_auth_api_key_name");
    openapiFields.add("web_hook_config_auth_api_key_value");
    openapiFields.add("web_hook_config_auth_basic_auth_password");
    openapiFields.add("web_hook_config_auth_basic_auth_user");
    openapiFields.add("web_hook_config_auth_type");
    openapiFields.add("web_hook_config_body");
    openapiFields.add("web_hook_config_can_interrupt");
    openapiFields.add("web_hook_config_method");
    openapiFields.add("web_hook_config_response_ignore");
    openapiFields.add("web_hook_config_url");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("config_key");
    openapiRequiredFields.add("hook");
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to NormalizedProjectRevisionHook
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!NormalizedProjectRevisionHook.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in NormalizedProjectRevisionHook is not found in the empty JSON string", NormalizedProjectRevisionHook.openapiRequiredFields.toString()));
        }
      }

      Set<Entry<String, JsonElement>> entries = jsonObj.entrySet();
      // check to see if the JSON string contains additional fields
      for (Entry<String, JsonElement> entry : entries) {
        if (!NormalizedProjectRevisionHook.openapiFields.contains(entry.getKey())) {
          throw new IllegalArgumentException(String.format("The field `%s` in the JSON string is not defined in the `NormalizedProjectRevisionHook` properties. JSON: %s", entry.getKey(), jsonObj.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : NormalizedProjectRevisionHook.openapiRequiredFields) {
        if (jsonObj.get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonObj.toString()));
        }
      }
      if (!jsonObj.get("config_key").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `config_key` to be a primitive type in the JSON string but got `%s`", jsonObj.get("config_key").toString()));
      }
      if (!jsonObj.get("hook").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `hook` to be a primitive type in the JSON string but got `%s`", jsonObj.get("hook").toString()));
      }
      if ((jsonObj.get("id") != null && !jsonObj.get("id").isJsonNull()) && !jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
      if ((jsonObj.get("project_revision_id") != null && !jsonObj.get("project_revision_id").isJsonNull()) && !jsonObj.get("project_revision_id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `project_revision_id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("project_revision_id").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_api_key_in") != null && !jsonObj.get("web_hook_config_auth_api_key_in").isJsonNull()) && !jsonObj.get("web_hook_config_auth_api_key_in").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_api_key_in` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_api_key_in").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_api_key_name") != null && !jsonObj.get("web_hook_config_auth_api_key_name").isJsonNull()) && !jsonObj.get("web_hook_config_auth_api_key_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_api_key_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_api_key_name").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_api_key_value") != null && !jsonObj.get("web_hook_config_auth_api_key_value").isJsonNull()) && !jsonObj.get("web_hook_config_auth_api_key_value").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_api_key_value` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_api_key_value").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_basic_auth_password") != null && !jsonObj.get("web_hook_config_auth_basic_auth_password").isJsonNull()) && !jsonObj.get("web_hook_config_auth_basic_auth_password").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_basic_auth_password` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_basic_auth_password").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_basic_auth_user") != null && !jsonObj.get("web_hook_config_auth_basic_auth_user").isJsonNull()) && !jsonObj.get("web_hook_config_auth_basic_auth_user").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_basic_auth_user` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_basic_auth_user").toString()));
      }
      if ((jsonObj.get("web_hook_config_auth_type") != null && !jsonObj.get("web_hook_config_auth_type").isJsonNull()) && !jsonObj.get("web_hook_config_auth_type").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_auth_type` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_auth_type").toString()));
      }
      if ((jsonObj.get("web_hook_config_body") != null && !jsonObj.get("web_hook_config_body").isJsonNull()) && !jsonObj.get("web_hook_config_body").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_body` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_body").toString()));
      }
      if ((jsonObj.get("web_hook_config_method") != null && !jsonObj.get("web_hook_config_method").isJsonNull()) && !jsonObj.get("web_hook_config_method").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_method` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_method").toString()));
      }
      if ((jsonObj.get("web_hook_config_url") != null && !jsonObj.get("web_hook_config_url").isJsonNull()) && !jsonObj.get("web_hook_config_url").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `web_hook_config_url` to be a primitive type in the JSON string but got `%s`", jsonObj.get("web_hook_config_url").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!NormalizedProjectRevisionHook.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'NormalizedProjectRevisionHook' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<NormalizedProjectRevisionHook> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(NormalizedProjectRevisionHook.class));

       return (TypeAdapter<T>) new TypeAdapter<NormalizedProjectRevisionHook>() {
           @Override
           public void write(JsonWriter out, NormalizedProjectRevisionHook value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             elementAdapter.write(out, obj);
           }

           @Override
           public NormalizedProjectRevisionHook read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             return thisAdapter.fromJsonTree(jsonObj);
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of NormalizedProjectRevisionHook given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of NormalizedProjectRevisionHook
  * @throws IOException if the JSON string is invalid with respect to NormalizedProjectRevisionHook
  */
  public static NormalizedProjectRevisionHook fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, NormalizedProjectRevisionHook.class);
  }

 /**
  * Convert an instance of NormalizedProjectRevisionHook to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

