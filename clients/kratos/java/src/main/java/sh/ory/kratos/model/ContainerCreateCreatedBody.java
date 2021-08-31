/*
 * Ory Kratos API
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.7.3-alpha.5
 * Contact: hi@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.kratos.model;

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
import java.util.ArrayList;
import java.util.List;

/**
 * ContainerCreateCreatedBody OK response to ContainerCreate operation
 */
@ApiModel(description = "ContainerCreateCreatedBody OK response to ContainerCreate operation")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-08-31T15:17:55.750208384Z[Etc/UTC]")
public class ContainerCreateCreatedBody {
  public static final String SERIALIZED_NAME_ID = "Id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_WARNINGS = "Warnings";
  @SerializedName(SERIALIZED_NAME_WARNINGS)
  private List<String> warnings = new ArrayList<>();


  public ContainerCreateCreatedBody id(String id) {
    
    this.id = id;
    return this;
  }

   /**
   * The ID of the created container
   * @return id
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "The ID of the created container")

  public String getId() {
    return id;
  }


  public void setId(String id) {
    this.id = id;
  }


  public ContainerCreateCreatedBody warnings(List<String> warnings) {
    
    this.warnings = warnings;
    return this;
  }

  public ContainerCreateCreatedBody addWarningsItem(String warningsItem) {
    this.warnings.add(warningsItem);
    return this;
  }

   /**
   * Warnings encountered when creating the container
   * @return warnings
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Warnings encountered when creating the container")

  public List<String> getWarnings() {
    return warnings;
  }


  public void setWarnings(List<String> warnings) {
    this.warnings = warnings;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContainerCreateCreatedBody containerCreateCreatedBody = (ContainerCreateCreatedBody) o;
    return Objects.equals(this.id, containerCreateCreatedBody.id) &&
        Objects.equals(this.warnings, containerCreateCreatedBody.warnings);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, warnings);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContainerCreateCreatedBody {\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    warnings: ").append(toIndentedString(warnings)).append("\n");
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

