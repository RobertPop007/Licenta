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
import { UserFriend } from './userFriend';
import { AppUserAnimeItem } from './appUserAnimeItem';
import { AppUserMangaItem } from './appUserMangaItem';
import { AppUserMovieItem } from './appUserMovieItem';
import { Message } from './message';
import { AppUserRole } from './appUserRole';
import { AppUserTvShowItem } from './appUserTvShowItem';
import { Photo } from './photo';
import { AppUserGameItem } from './appUserGameItem';


export interface AppUser { 
    id?: number;
    userName?: string | null;
    normalizedUserName?: string | null;
    email?: string | null;
    normalizedEmail?: string | null;
    emailConfirmed?: boolean;
    passwordHash?: string | null;
    securityStamp?: string | null;
    concurrencyStamp?: string | null;
    phoneNumber?: string | null;
    phoneNumberConfirmed?: boolean;
    twoFactorEnabled?: boolean;
    lockoutEnd?: string | null;
    lockoutEnabled?: boolean;
    accessFailedCount?: number;
    dateOfBirth?: string;
    knownAs?: string | null;
    created?: string;
    lastActive?: string;
    gender?: string | null;
    introduction?: string | null;
    lookingFor?: string | null;
    interests?: string | null;
    city?: string | null;
    country?: string | null;
    profilePicture?: Photo;
    addedByUsers?: Array<UserFriend> | null;
    addedUsers?: Array<UserFriend> | null;
    messagesSent?: Array<Message> | null;
    messagesReceived?: Array<Message> | null;
    userRoles?: Array<AppUserRole> | null;
    appUserMovie?: Array<AppUserMovieItem> | null;
    appUserTvShow?: Array<AppUserTvShowItem> | null;
    appUserAnime?: Array<AppUserAnimeItem> | null;
    appUserManga?: Array<AppUserMangaItem> | null;
    appUserGame?: Array<AppUserGameItem> | null;
    isSubscribedToNewsletter?: boolean;
}

