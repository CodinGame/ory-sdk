/*
 * ORY Oathkeeper
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.0.0-alpha.57
 * Contact: hi@ory.am
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.oathkeeper.model;

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
import sh.ory.oathkeeper.model.CreateRuleInternalServerErrorBody;

/**
 * The standard error format
 */
@ApiModel(description = "The standard error format")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-08-24T12:39:49.448987137Z[Etc/UTC]")
public class CreateRuleInternalServerError {
  public static final String SERIALIZED_NAME_PAYLOAD = "Payload";
  @SerializedName(SERIALIZED_NAME_PAYLOAD)
  private CreateRuleInternalServerErrorBody payload;


  public CreateRuleInternalServerError payload(CreateRuleInternalServerErrorBody payload) {
    
    this.payload = payload;
    return this;
  }

   /**
   * Get payload
   * @return payload
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public CreateRuleInternalServerErrorBody getPayload() {
    return payload;
  }


  public void setPayload(CreateRuleInternalServerErrorBody payload) {
    this.payload = payload;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreateRuleInternalServerError createRuleInternalServerError = (CreateRuleInternalServerError) o;
    return Objects.equals(this.payload, createRuleInternalServerError.payload);
  }

  @Override
  public int hashCode() {
    return Objects.hash(payload);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreateRuleInternalServerError {\n");
    sb.append("    payload: ").append(toIndentedString(payload)).append("\n");
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

}

