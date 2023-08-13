/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.1.45
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
import sh.ory.model.UpdateRegistrationFlowWithOidcMethod;
import sh.ory.model.UpdateRegistrationFlowWithPasswordMethod;
import sh.ory.model.UpdateRegistrationFlowWithWebAuthnMethod;

import javax.ws.rs.core.GenericType;

import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;

import sh.ory.JSON;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-08-13T21:50:28.344339006Z[Etc/UTC]")
public class UpdateRegistrationFlowBody extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(UpdateRegistrationFlowBody.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!UpdateRegistrationFlowBody.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'UpdateRegistrationFlowBody' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<UpdateRegistrationFlowWithOidcMethod> adapterUpdateRegistrationFlowWithOidcMethod = gson.getDelegateAdapter(this, TypeToken.get(UpdateRegistrationFlowWithOidcMethod.class));
            final TypeAdapter<UpdateRegistrationFlowWithPasswordMethod> adapterUpdateRegistrationFlowWithPasswordMethod = gson.getDelegateAdapter(this, TypeToken.get(UpdateRegistrationFlowWithPasswordMethod.class));
            final TypeAdapter<UpdateRegistrationFlowWithWebAuthnMethod> adapterUpdateRegistrationFlowWithWebAuthnMethod = gson.getDelegateAdapter(this, TypeToken.get(UpdateRegistrationFlowWithWebAuthnMethod.class));

            return (TypeAdapter<T>) new TypeAdapter<UpdateRegistrationFlowBody>() {
                @Override
                public void write(JsonWriter out, UpdateRegistrationFlowBody value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `UpdateRegistrationFlowWithOidcMethod`
                    if (value.getActualInstance() instanceof UpdateRegistrationFlowWithOidcMethod) {
                        JsonObject obj = adapterUpdateRegistrationFlowWithOidcMethod.toJsonTree((UpdateRegistrationFlowWithOidcMethod)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `UpdateRegistrationFlowWithPasswordMethod`
                    if (value.getActualInstance() instanceof UpdateRegistrationFlowWithPasswordMethod) {
                        JsonObject obj = adapterUpdateRegistrationFlowWithPasswordMethod.toJsonTree((UpdateRegistrationFlowWithPasswordMethod)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    // check if the actual instance is of the type `UpdateRegistrationFlowWithWebAuthnMethod`
                    if (value.getActualInstance() instanceof UpdateRegistrationFlowWithWebAuthnMethod) {
                        JsonObject obj = adapterUpdateRegistrationFlowWithWebAuthnMethod.toJsonTree((UpdateRegistrationFlowWithWebAuthnMethod)value.getActualInstance()).getAsJsonObject();
                        elementAdapter.write(out, obj);
                        return;
                    }

                    throw new IOException("Failed to serialize as the type doesn't match oneOf schemas: UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod");
                }

                @Override
                public UpdateRegistrationFlowBody read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonObject jsonObject = elementAdapter.read(in).getAsJsonObject();

                    int match = 0;
                    ArrayList<String> errorMessages = new ArrayList<>();
                    TypeAdapter actualAdapter = elementAdapter;

                    // deserialize UpdateRegistrationFlowWithOidcMethod
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UpdateRegistrationFlowWithOidcMethod.validateJsonObject(jsonObject);
                        actualAdapter = adapterUpdateRegistrationFlowWithOidcMethod;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UpdateRegistrationFlowWithOidcMethod'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithOidcMethod failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UpdateRegistrationFlowWithOidcMethod'", e);
                    }

                    // deserialize UpdateRegistrationFlowWithPasswordMethod
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UpdateRegistrationFlowWithPasswordMethod.validateJsonObject(jsonObject);
                        actualAdapter = adapterUpdateRegistrationFlowWithPasswordMethod;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UpdateRegistrationFlowWithPasswordMethod'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithPasswordMethod failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UpdateRegistrationFlowWithPasswordMethod'", e);
                    }

                    // deserialize UpdateRegistrationFlowWithWebAuthnMethod
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UpdateRegistrationFlowWithWebAuthnMethod.validateJsonObject(jsonObject);
                        actualAdapter = adapterUpdateRegistrationFlowWithWebAuthnMethod;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UpdateRegistrationFlowWithWebAuthnMethod'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithWebAuthnMethod failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UpdateRegistrationFlowWithWebAuthnMethod'", e);
                    }

                    if (match == 1) {
                        UpdateRegistrationFlowBody ret = new UpdateRegistrationFlowBody();
                        ret.setActualInstance(actualAdapter.fromJsonTree(jsonObject));
                        return ret;
                    }

                    throw new IOException(String.format("Failed deserialization for UpdateRegistrationFlowBody: %d classes match result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", match, errorMessages, jsonObject.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in oneOf
    public static final Map<String, GenericType> schemas = new HashMap<String, GenericType>();

    public UpdateRegistrationFlowBody() {
        super("oneOf", Boolean.FALSE);
    }

    public UpdateRegistrationFlowBody(UpdateRegistrationFlowWithOidcMethod o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public UpdateRegistrationFlowBody(UpdateRegistrationFlowWithPasswordMethod o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    public UpdateRegistrationFlowBody(UpdateRegistrationFlowWithWebAuthnMethod o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("UpdateRegistrationFlowWithOidcMethod", new GenericType<UpdateRegistrationFlowWithOidcMethod>() {
        });
        schemas.put("UpdateRegistrationFlowWithPasswordMethod", new GenericType<UpdateRegistrationFlowWithPasswordMethod>() {
        });
        schemas.put("UpdateRegistrationFlowWithWebAuthnMethod", new GenericType<UpdateRegistrationFlowWithWebAuthnMethod>() {
        });
    }

    @Override
    public Map<String, GenericType> getSchemas() {
        return UpdateRegistrationFlowBody.schemas;
    }

    /**
     * Set the instance that matches the oneOf child schema, check
     * the instance parameter is valid against the oneOf child schemas:
     * UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod
     *
     * It could be an instance of the 'oneOf' schemas.
     * The oneOf child schemas may themselves be a composed schema (allOf, anyOf, oneOf).
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof UpdateRegistrationFlowWithOidcMethod) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UpdateRegistrationFlowWithPasswordMethod) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UpdateRegistrationFlowWithWebAuthnMethod) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod");
    }

    /**
     * Get the actual instance, which can be the following:
     * UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod
     *
     * @return The actual instance (UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod)
     */
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `UpdateRegistrationFlowWithOidcMethod`. If the actual instance is not `UpdateRegistrationFlowWithOidcMethod`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UpdateRegistrationFlowWithOidcMethod`
     * @throws ClassCastException if the instance is not `UpdateRegistrationFlowWithOidcMethod`
     */
    public UpdateRegistrationFlowWithOidcMethod getUpdateRegistrationFlowWithOidcMethod() throws ClassCastException {
        return (UpdateRegistrationFlowWithOidcMethod)super.getActualInstance();
    }

    /**
     * Get the actual instance of `UpdateRegistrationFlowWithPasswordMethod`. If the actual instance is not `UpdateRegistrationFlowWithPasswordMethod`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UpdateRegistrationFlowWithPasswordMethod`
     * @throws ClassCastException if the instance is not `UpdateRegistrationFlowWithPasswordMethod`
     */
    public UpdateRegistrationFlowWithPasswordMethod getUpdateRegistrationFlowWithPasswordMethod() throws ClassCastException {
        return (UpdateRegistrationFlowWithPasswordMethod)super.getActualInstance();
    }

    /**
     * Get the actual instance of `UpdateRegistrationFlowWithWebAuthnMethod`. If the actual instance is not `UpdateRegistrationFlowWithWebAuthnMethod`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UpdateRegistrationFlowWithWebAuthnMethod`
     * @throws ClassCastException if the instance is not `UpdateRegistrationFlowWithWebAuthnMethod`
     */
    public UpdateRegistrationFlowWithWebAuthnMethod getUpdateRegistrationFlowWithWebAuthnMethod() throws ClassCastException {
        return (UpdateRegistrationFlowWithWebAuthnMethod)super.getActualInstance();
    }


 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to UpdateRegistrationFlowBody
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
    // validate oneOf schemas one by one
    int validCount = 0;
    ArrayList<String> errorMessages = new ArrayList<>();
    // validate the json string with UpdateRegistrationFlowWithOidcMethod
    try {
      UpdateRegistrationFlowWithOidcMethod.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithOidcMethod failed with `%s`.", e.getMessage()));
      // continue to the next one
    }
    // validate the json string with UpdateRegistrationFlowWithPasswordMethod
    try {
      UpdateRegistrationFlowWithPasswordMethod.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithPasswordMethod failed with `%s`.", e.getMessage()));
      // continue to the next one
    }
    // validate the json string with UpdateRegistrationFlowWithWebAuthnMethod
    try {
      UpdateRegistrationFlowWithWebAuthnMethod.validateJsonObject(jsonObj);
      validCount++;
    } catch (Exception e) {
      errorMessages.add(String.format("Deserialization for UpdateRegistrationFlowWithWebAuthnMethod failed with `%s`.", e.getMessage()));
      // continue to the next one
    }
    if (validCount != 1) {
      throw new IOException(String.format("The JSON string is invalid for UpdateRegistrationFlowBody with oneOf schemas: UpdateRegistrationFlowWithOidcMethod, UpdateRegistrationFlowWithPasswordMethod, UpdateRegistrationFlowWithWebAuthnMethod. %d class(es) match the result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", validCount, errorMessages, jsonObj.toString()));
    }
  }

 /**
  * Create an instance of UpdateRegistrationFlowBody given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of UpdateRegistrationFlowBody
  * @throws IOException if the JSON string is invalid with respect to UpdateRegistrationFlowBody
  */
  public static UpdateRegistrationFlowBody fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, UpdateRegistrationFlowBody.class);
  }

 /**
  * Convert an instance of UpdateRegistrationFlowBody to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

