/**
 * Proiect_licenta
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { AppUserRole } from './appUserRole';


export interface AppRole { 
    id?: number;
    name?: string | null;
    normalizedName?: string | null;
    concurrencyStamp?: string | null;
    userRoles?: Array<AppUserRole> | null;
}
