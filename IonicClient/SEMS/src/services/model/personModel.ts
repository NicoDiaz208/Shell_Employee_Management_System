/**
 * SEMS.WebApi
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

export interface PersonModel { 
    id?: number;
    rowVersion?: string;
    ssn?: string;
    firstName?: string;
    lastName?: string;
    sex?: string;
    telNr?: string;
    address?: string;
    place?: number;
    birthday?: Date;
    note?: string;
    applicationDate?: Date;
    referal?: string;
    beginDate?: Date;
    endDate?: Date;
    reasonForTermination?: string;
}