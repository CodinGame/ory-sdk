/**
 * ORY Hydra
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: latest
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from '../api';
import { JSONWebKey } from './jSONWebKey';

/**
* JSONWebKeySet JSONWebKeySet JSONWebKeySet It is important that this model object is named JSONWebKeySet for \"swagger generate spec\" to generate only on definition of a JSONWebKeySet. Since one with the same name is previously defined as client.Client.JSONWebKeys and this one is last, this one will be effectively written in the swagger spec.
*/
export class JSONWebKeySet {
    /**
    * The value of the \"keys\" parameter is an array of JWK values.  By default, the order of the JWK values within the array does not imply an order of preference among them, although applications of JWK Sets can choose to assign a meaning to the order for their purposes, if desired.
    */
    'keys'?: Array<JSONWebKey>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "keys",
            "baseName": "keys",
            "type": "Array<JSONWebKey>"
        }    ];

    static getAttributeTypeMap() {
        return JSONWebKeySet.attributeTypeMap;
    }
}

