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
import { PhotoDto } from './photoDto';


export interface MemberDto { 
    id?: number;
    username?: string | null;
    photoUrl?: string | null;
    age?: number;
    knownAs?: string | null;
    created?: string;
    lastActive?: string;
    gender?: string | null;
    introduction?: string | null;
    lookingFor?: string | null;
    interests?: string | null;
    city?: string | null;
    country?: string | null;
    profilePicture?: PhotoDto;
    isSubscribedToNewsletter?: boolean;
}

