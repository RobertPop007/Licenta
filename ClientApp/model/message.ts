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
import { AppUser } from './appUser';


export interface Message { 
    id?: number;
    senderId?: number;
    senderUsername?: string | null;
    sender?: AppUser;
    recipientId?: number;
    recipientUsername?: string | null;
    recipient?: AppUser;
    content?: string | null;
    dateRead?: string | null;
    messageSent?: string;
    senderDeleted?: boolean;
    recipientDeleted?: boolean;
}

