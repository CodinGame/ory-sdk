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

/**
* FlushInactiveOAuth2TokensRequest FlushInactiveOAuth2TokensRequest FlushInactiveOAuth2TokensRequest FlushInactiveOAuth2TokensRequest FlushInactiveOAuth2TokensRequest flush inactive o auth2 tokens request
*/
export class FlushInactiveOAuth2TokensRequest {
    /**
    * NotAfter sets after which point tokens should not be flushed. This is useful when you want to keep a history of recently issued tokens for auditing. Format: date-time Format: date-time Format: date-time Format: date-time Format: date-time
    */
    'notAfter'?: Date;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "notAfter",
            "baseName": "notAfter",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return FlushInactiveOAuth2TokensRequest.attributeTypeMap;
    }
}

